namespace BlockChainValleyFE
{
    partial class MemberDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewPublicBoards;
        private System.Windows.Forms.Button btnViewMyTeamBoard;

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
            this.btnViewPublicBoards = new System.Windows.Forms.Button();
            this.btnViewMyTeamBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Text = "🎓 학회원 전용 대시보드";

            // btnViewPublicBoards
            this.btnViewPublicBoards.Location = new System.Drawing.Point(30, 80);
            this.btnViewPublicBoards.Size = new System.Drawing.Size(200, 40);
            this.btnViewPublicBoards.Text = "공개 게시판 보기";

            // btnViewMyTeamBoard
            this.btnViewMyTeamBoard.Location = new System.Drawing.Point(30, 130);
            this.btnViewMyTeamBoard.Size = new System.Drawing.Size(200, 40);
            this.btnViewMyTeamBoard.Text = "내 팀 게시판";
            this.btnViewMyTeamBoard.Click += new System.EventHandler(this.btnViewMyTeamBoard_Click); // ✅ 이 줄 추가

            // MemberDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewPublicBoards);
            this.Controls.Add(this.btnViewMyTeamBoard);
            this.Name = "MemberDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학회원 대시보드";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
