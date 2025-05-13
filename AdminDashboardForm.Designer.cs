namespace BlockChainValleyFE
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageBoards;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageBoards = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Text = "👑 관리자 전용 대시보드";

            // btnManageMembers
            this.btnManageMembers.Location = new System.Drawing.Point(30, 80);
            this.btnManageMembers.Size = new System.Drawing.Size(200, 40);
            this.btnManageMembers.Text = "학회원 관리";

            // btnManageBoards
            this.btnManageBoards.Location = new System.Drawing.Point(30, 130);
            this.btnManageBoards.Size = new System.Drawing.Size(200, 40);
            this.btnManageBoards.Text = "게시판 관리";

            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManageMembers);
            this.Controls.Add(this.btnManageBoards);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자 대시보드";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
