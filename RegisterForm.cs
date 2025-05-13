using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace BlockChainValleyFE
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            // Placeholders (수동 구현)
            SetPlaceholder(txtName, "Name");
            SetPlaceholder(txtPhone, "Phone Number");
            SetPlaceholder(txtPassword, "Password");
            SetPlaceholder(txtTelegram, "Telegram Handle (optional)");
            SetPlaceholder(txtTwitter, "Twitter Handle (optional)");
            SetPlaceholder(txtWallet, "Wallet Address (optional)");
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var registerDto = new
            {
                name = txtName.Text,
                phoneNumber = txtPhone.Text,
                password = txtPassword.Text,
                telegramHandle = txtTelegram.Text,
                twitterHandle = txtTwitter.Text,
                walletAddress = txtWallet.Text
            };

            using (HttpClient client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(registerDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5233/api/Auth/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("회원가입 성공!");
                    this.Close(); // 가입 후 폼 닫기
                }
                else
                {
                    MessageBox.Show("회원가입 실패!");
                }
            }
        }
    }
}
