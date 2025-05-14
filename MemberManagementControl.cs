using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using BlockChainValleyFE.Models;

namespace BlockChainValleyFE
{
    public partial class MemberManagementControl : UserControl
    {
        private List<MemberDto> members = new List<MemberDto>();

        public MemberManagementControl()
        {
            InitializeComponent();
            SetupPlaceholderEvents();
            _ = LoadMembersAsync();
        }

        private void SetupPlaceholderEvents()
        {
            txtSearch.GotFocus += RemovePlaceholderText;
            txtSearch.LostFocus += AddPlaceholderText;
            btnRefresh.Click += async (s, e) => await LoadMembersAsync();
            btnSearch.Click += async (s, e) => await LoadMembersAsync(txtSearch.Text.Trim());
            btnSave.Click += async (s, e) => await SaveRolesAsync();
            dataGridMembers.CellDoubleClick += DataGridMembers_CellDoubleClick;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            if (txtSearch.Text == "이름 또는 전화번호 입력")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholderText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "이름 또는 전화번호 입력";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private async Task LoadMembersAsync(string filter = null)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync("http://localhost:5233/api/Members");
                    members = JsonConvert.DeserializeObject<List<MemberDto>>(response);

                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        members = members.FindAll(m =>
                            m.Name.Contains(filter) ||
                            m.PhoneNumber.Contains(filter));
                    }

                    dataGridMembers.AutoGenerateColumns = false;
                    dataGridMembers.Columns.Clear();
                    dataGridMembers.DataSource = null;
                    dataGridMembers.DataSource = members;

                    dataGridMembers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "이름", DataPropertyName = "Name" });
                    dataGridMembers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "전화번호", DataPropertyName = "PhoneNumber" });
                    dataGridMembers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "텔레그램", DataPropertyName = "TelegramHandle" });
                    dataGridMembers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "트위터", DataPropertyName = "TwitterHandle" });
                    dataGridMembers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "지갑주소", DataPropertyName = "WalletAddress" });

                    var comboCol = new DataGridViewComboBoxColumn
                    {
                        HeaderText = "역할",
                        DataPropertyName = "Role",
                        Name = "Role",
                    };
                    comboCol.Items.AddRange("Member", "TeamLeader", "President", "VicePresident");
                    dataGridMembers.Columns.Add(comboCol);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("불러오기 실패: " + ex.Message);
                }
            }
        }

        private async Task SaveRolesAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridMembers.Rows)
                    {
                        if (row.DataBoundItem is MemberDto member && row.Cells["Role"].Value is string newRole)
                        {
                            member.Role = newRole;
                            var json = JsonConvert.SerializeObject(member);
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            await client.PutAsync($"http://localhost:5233/api/Members/{member.Id}", content);
                        }
                    }

                    MessageBox.Show("저장 완료!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("저장 실패: " + ex.Message);
                }
            }
        }

        private void DataGridMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridMembers.Rows[e.RowIndex].DataBoundItem is MemberDto member)
            {
                var detailForm = new MemberDetailForm(member);
                detailForm.TopLevel = false;
                detailForm.FormBorderStyle = FormBorderStyle.None;
                detailForm.Dock = DockStyle.Fill;

                this.Controls.Clear();
                this.Controls.Add(detailForm);
                detailForm.Show();
            }
        }
    }
}
