using System.Drawing;
using System.Windows.Forms;

namespace BlockChainValleyFE
{
    partial class MemberDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private Label lblPhone;
        private Label lblTelegram;
        private Label lblTwitter;
        private Label lblWallet;
        private Label lblRole;

        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtTelegram;
        private TextBox txtTwitter;
        private TextBox txtWallet;
        private TextBox txtRole;

        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblPhone = new Label();
            this.lblTelegram = new Label();
            this.lblTwitter = new Label();
            this.lblWallet = new Label();
            this.lblRole = new Label();

            this.txtName = new TextBox();
            this.txtPhone = new TextBox();
            this.txtTelegram = new TextBox();
            this.txtTwitter = new TextBox();
            this.txtWallet = new TextBox();
            this.txtRole = new TextBox();

            this.btnSave = new Button();
            this.btnBack = new Button();

            Font labelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            Font inputFont = new Font("Segoe UI", 10F);

            // lblName
            this.lblName.Text = "이름";
            this.lblName.Font = labelFont;
            this.lblName.Location = new Point(30, 30);
            this.lblName.Size = new Size(100, 30);
            this.Controls.Add(this.lblName);

            // txtName
            this.txtName.Font = inputFont;
            this.txtName.Location = new Point(150, 30);
            this.txtName.Size = new Size(400, 30);
            this.Controls.Add(this.txtName);

            // lblPhone
            this.lblPhone.Text = "전화번호";
            this.lblPhone.Font = labelFont;
            this.lblPhone.Location = new Point(30, 70);
            this.lblPhone.Size = new Size(100, 30);
            this.Controls.Add(this.lblPhone);

            // txtPhone
            this.txtPhone.Font = inputFont;
            this.txtPhone.Location = new Point(150, 70);
            this.txtPhone.Size = new Size(400, 30);
            this.Controls.Add(this.txtPhone);

            // lblTelegram
            this.lblTelegram.Text = "텔레그램";
            this.lblTelegram.Font = labelFont;
            this.lblTelegram.Location = new Point(30, 110);
            this.lblTelegram.Size = new Size(100, 30);
            this.Controls.Add(this.lblTelegram);

            // txtTelegram
            this.txtTelegram.Font = inputFont;
            this.txtTelegram.Location = new Point(150, 110);
            this.txtTelegram.Size = new Size(400, 30);
            this.Controls.Add(this.txtTelegram);

            // lblTwitter
            this.lblTwitter.Text = "트위터";
            this.lblTwitter.Font = labelFont;
            this.lblTwitter.Location = new Point(30, 150);
            this.lblTwitter.Size = new Size(100, 30);
            this.Controls.Add(this.lblTwitter);

            // txtTwitter
            this.txtTwitter.Font = inputFont;
            this.txtTwitter.Location = new Point(150, 150);
            this.txtTwitter.Size = new Size(400, 30);
            this.Controls.Add(this.txtTwitter);

            // lblWallet
            this.lblWallet.Text = "지갑주소";
            this.lblWallet.Font = labelFont;
            this.lblWallet.Location = new Point(30, 190);
            this.lblWallet.Size = new Size(100, 30);
            this.Controls.Add(this.lblWallet);

            // txtWallet
            this.txtWallet.Font = inputFont;
            this.txtWallet.Location = new Point(150, 190);
            this.txtWallet.Size = new Size(400, 30);
            this.Controls.Add(this.txtWallet);

            // lblRole
            this.lblRole.Text = "역할";
            this.lblRole.Font = labelFont;
            this.lblRole.Location = new Point(30, 230);
            this.lblRole.Size = new Size(100, 30);
            this.Controls.Add(this.lblRole);

            // txtRole
            this.txtRole.Font = inputFont;
            this.txtRole.Location = new Point(150, 230);
            this.txtRole.Size = new Size(400, 30);
            this.Controls.Add(this.txtRole);

            // btnSave
            this.btnSave.Text = "💾 저장";
            this.btnSave.Font = labelFont;
            this.btnSave.Size = new Size(120, 40);
            this.btnSave.BackColor = Color.MediumSeaGreen;
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Location = new Point(150, 280);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.Controls.Add(this.btnSave);

            // btnDelete
            this.btnDelete = new Button();
            this.btnDelete.Text = "🗑 삭제";
            this.btnDelete.Font = labelFont;
            this.btnDelete.Size = new Size(120, 40);
            this.btnDelete.BackColor = Color.IndianRed;
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Location = new Point(290, 280);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.Controls.Add(this.btnDelete);

            // btnBack
            this.btnBack.Text = "⬅ 돌아가기";
            this.btnBack.Font = labelFont;
            this.btnBack.Size = new Size(120, 40);
            this.btnBack.BackColor = Color.LightGray;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Location = new Point(430, 280);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.Controls.Add(this.btnBack);

            // Form
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(600, 360);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "MemberDetailForm";
            this.Text = "회원 상세 정보";
            this.ResumeLayout(false);
        }
    }
}
