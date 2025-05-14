using BlockChainValleyFE.Models;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: 저장 로직 구현
            MessageBox.Show("저장 버튼이 클릭되었습니다.");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"http://localhost:5233/api/Members/{member.Id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        this.Parent?.Controls.Remove(this);
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패: " + response.ReasonPhrase);
                    }
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            // 현재 폼 제거 (UserControl처럼 작동)
            this.Parent?.Controls.Remove(this);
        }
        private void PopulateFields()
        {
            lblName.Text = $"이름: {member.Name}";
            lblPhone.Text = $"전화번호: {member.PhoneNumber}";
            lblTelegram.Text = $"텔레그램: {member.TelegramHandle}";
            lblTwitter.Text = $"트위터: {member.TwitterHandle}";
            lblWallet.Text = $"지갑주소: {member.WalletAddress}";
            lblRole.Text = $"역할: {member.Role}";
        }
    }
}
