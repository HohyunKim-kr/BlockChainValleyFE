using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using BlockChainValleyFE.Models;
using Newtonsoft.Json;

namespace BlockChainValleyFE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog(); // 모달로 열기
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginDto = new
            {
                phoneNumber = txtPhoneNumber.Text,
                password = txtPassword.Text
            };

            using (HttpClient client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5233/api/Auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var auth = JsonConvert.DeserializeObject<AuthResponseDto>(result);

                    MessageBox.Show($"로그인 성공! 역할: {auth.role}");

                    if (auth.role == "President" || auth.role == "VicePresident")
                        new AdminDashboardForm().ShowDialog();
                    else
                        new MemberDashboardForm().ShowDialog();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("로그인 실패! 정보를 다시 확인해주세요.");
                }
            }
        }
    }
}
