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
            this.sidebar = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnRegisterMember = new System.Windows.Forms.Button();
            this.btnManagePosts = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Controls.Add(this.btnManageMembers);
            this.sidebar.Controls.Add(this.btnRegisterMember);
            this.sidebar.Controls.Add(this.btnManagePosts);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(220, 600);
            this.sidebar.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(20, 58);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.Color.White;
            this.btnManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageMembers.ForeColor = System.Drawing.Color.Black;
            this.btnManageMembers.Location = new System.Drawing.Point(20, 110);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(180, 40);
            this.btnManageMembers.TabIndex = 1;
            this.btnManageMembers.Text = "학회원 관리";
            this.btnManageMembers.UseVisualStyleBackColor = false;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnRegisterMember
            // 
            this.btnRegisterMember.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterMember.Name = "btnRegisterMember";
            this.btnRegisterMember.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterMember.TabIndex = 2;
            // 
            // btnManagePosts
            // 
            this.btnManagePosts.Location = new System.Drawing.Point(0, 0);
            this.btnManagePosts.Name = "btnManagePosts";
            this.btnManagePosts.Size = new System.Drawing.Size(75, 23);
            this.btnManagePosts.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(240, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(394, 30);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "👑 Blockchain Valley 관리자 대시보드";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(240, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(740, 500);
            this.contentPanel.TabIndex = 2;
            // 
            // AdminDashboardForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.contentPanel);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자 대시보드";
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
