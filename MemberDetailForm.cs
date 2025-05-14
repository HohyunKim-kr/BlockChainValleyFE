using BlockChainValleyFE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChainValleyFE
{
    public partial class MemberDetailForm : Form
    {
        private MemberDto member;

        public MemberDetailForm(MemberDto member)
        {
            InitializeComponent();
            this.member = member;
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtName.Text = member.Name;
            txtPhone.Text = member.PhoneNumber;
            txtTelegram.Text = member.TelegramHandle;
            txtTwitter.Text = member.TwitterHandle;
            txtWallet.Text = member.WalletAddress;
            //cmbRole.SelectedItem = ConvertRoleIntToString(member.Role);
        }

        private string ConvertRoleIntToString(int role)
        {
            switch (role)
            {
                case 0: return "Member";
                case 1: return "TeamLeader";
                case 2: return "President";
                case 3: return "VicePresident";
                default: return "Member";
            }
        }

        private int ConvertRoleStringToInt(string role)
        {
            switch (role)
            {
                case "Member": return 0;
                case "TeamLeader": return 1;
                case "President": return 2;
                case "VicePresident": return 3;
                default: return 0;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            member.Name = txtName.Text;
            member.PhoneNumber = txtPhone.Text;
            member.TelegramHandle = txtTelegram.Text;
            member.TwitterHandle = txtTwitter.Text;
            member.WalletAddress = txtWallet.Text;
            //member.Role = ConvertRoleStringToInt(cmbRole.SelectedItem?.ToString());

            //if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            //{
            //    member.Password = txtPassword.Text;
            //}

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(member);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await client.PutAsync($"http://localhost:5233/api/Members/{member.Id}", content);
                if (res.IsSuccessStatusCode)
                    MessageBox.Show("수정 완료");
                else
                    MessageBox.Show("수정 실패: " + res.StatusCode);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var client = new HttpClient())
                {
                    var res = await client.DeleteAsync($"http://localhost:5233/api/Members/{member.Id}");
                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("삭제 완료");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패: " + res.StatusCode);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
