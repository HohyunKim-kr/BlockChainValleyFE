using System.Drawing;
using System.Windows.Forms;
using System;

namespace BlockChainValleyFE
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel sidebar;
        private Button btnManageMembers;
        private Button btnRegisterMember;
        private Button btnManagePosts;
        private Label lblHeader;
        private PictureBox logo;
        private Panel contentPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new Panel();
            this.btnManageMembers = new Button();
            this.btnRegisterMember = new Button();
            this.btnManagePosts = new Button();
            this.lblHeader = new Label();
            this.logo = new PictureBox();
            this.contentPanel = new Panel();

            // AdminDashboardForm
            this.SuspendLayout();
            this.ClientSize = new Size(1000, 600);
            this.Text = "관리자 대시보드";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // sidebar
            this.sidebar.BackColor = Color.FromArgb(51, 0, 0);
            this.sidebar.Dock = DockStyle.Left;
            this.sidebar.Width = 220;

            // logo
            //this.logo.Image = Image.FromFile("blockchainvalley_logo.png");
            this.logo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.logo.Size = new Size(180, 80);
            this.logo.Location = new Point(20, 10);

            // btnManageMembers
            this.btnManageMembers.Text = "학회원 관리";
            this.btnManageMembers.Size = new Size(180, 40);
            this.btnManageMembers.Location = new Point(20, 110);
            this.btnManageMembers.BackColor = Color.White;
            this.btnManageMembers.ForeColor = Color.Black;
            this.btnManageMembers.FlatStyle = FlatStyle.Flat;
            this.btnManageMembers.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnManageMembers.Click += new EventHandler(this.btnManageMembers_Click);

            // btnRegisterMember
            this.btnRegisterMember.Text = "Role 등록 / 멤버 등록";
            this.btnRegisterMember.Size = new Size(180, 40);
            this.btnRegisterMember.Location = new Point(20, 160);
            this.btnRegisterMember.BackColor = Color.White;
            this.btnRegisterMember.ForeColor = Color.Black;
            this.btnRegisterMember.FlatStyle = FlatStyle.Flat;
            this.btnRegisterMember.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnRegisterMember.Click += new EventHandler(this.btnRegisterMember_Click);

            // btnManagePosts
            this.btnManagePosts.Text = "게시판 글 관리";
            this.btnManagePosts.Size = new Size(180, 40);
            this.btnManagePosts.Location = new Point(20, 210);
            this.btnManagePosts.BackColor = Color.White;
            this.btnManagePosts.ForeColor = Color.Black;
            this.btnManagePosts.FlatStyle = FlatStyle.Flat;
            this.btnManagePosts.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnManagePosts.Click += new EventHandler(this.btnManagePosts_Click);

            // lblHeader
            this.lblHeader.Text = "👑 Blockchain Valley 관리자 대시보드";
            this.lblHeader.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.FromArgb(51, 0, 0);
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new Point(240, 30);

            // contentPanel
            this.contentPanel.Location = new Point(240, 80);
            this.contentPanel.Size = new Size(740, 500);
            this.contentPanel.BackColor = Color.White;

            // Add controls
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Controls.Add(this.btnManageMembers);
            this.sidebar.Controls.Add(this.btnRegisterMember);
            this.sidebar.Controls.Add(this.btnManagePosts);

            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.contentPanel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
