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
            dataGridMembers.DataError += (s, e) =>
            {
                MessageBox.Show("역할 값이 잘못되었습니다. 콤보박스에서 정확한 값을 선택하세요.");
                e.ThrowException = false;
            };
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

        private bool IsValidRole(string role)
        {
            return role == "Member" || role == "TeamLeader" || role == "President" || role == "VicePresident";
        }

        private async Task LoadMembersAsync(string filter = null)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync("http://localhost:5233/api/Members");
                    members = JsonConvert.DeserializeObject<List<MemberDto>>(response);

                    //foreach (var m in members)
                    //{
                    //    m.Role = ConvertRoleIntToString(m.Role);
                    //}

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
                        DataPropertyName = "RoleText", 
                        Name = "Role",
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
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
                        if (row.DataBoundItem is MemberDto member)
                        {
                            var cellValue = row.Cells["Role"].Value?.ToString();
                            if (string.IsNullOrWhiteSpace(cellValue) || !IsValidRole(cellValue))
                                continue;

                            var originalMember = new MemberDto
                            {
                                Id = member.Id,
                                Name = member.Name,
                                PhoneNumber = member.PhoneNumber,
                                TelegramHandle = member.TelegramHandle,
                                TwitterHandle = member.TwitterHandle,
                                WalletAddress = member.WalletAddress,
                                //Password = member.Password,
                                Role = ConvertRoleStringToInt(cellValue)
                            };

                            var json = JsonConvert.SerializeObject(originalMember);
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            var res = await client.PutAsync($"http://localhost:5233/api/Members/{member.Id}", content);

                            if (!res.IsSuccessStatusCode)
                            {
                                MessageBox.Show($"저장 실패: {res.StatusCode} {await res.Content.ReadAsStringAsync()}");
                            }
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
