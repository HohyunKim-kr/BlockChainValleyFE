using System.Windows.Forms;
using System.Drawing;

namespace BlockChainValleyFE
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtTelegram;
        private TextBox txtTwitter;
        private TextBox txtWallet;
        private Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtPhone = new TextBox();
            this.txtPassword = new TextBox();
            this.txtTelegram = new TextBox();
            this.txtTwitter = new TextBox();
            this.txtWallet = new TextBox();
            this.btnRegister = new Button();

            // 
            // RegisterForm
            // 
            this.Text = "Register";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(400, 400);
            this.Controls.AddRange(new Control[]
            {
                txtName, txtPhone, txtPassword, txtTelegram, txtTwitter, txtWallet, btnRegister
            });

            // Input Fields
            int top = 30;
            int spacing = 40;
            int width = 280;
            int height = 23;
            int left = 60;

            txtName.Location = new Point(left, top);
            txtPhone.Location = new Point(left, top += spacing);
            txtPassword.Location = new Point(left, top += spacing);
            txtPassword.UseSystemPasswordChar = true;
            txtTelegram.Location = new Point(left, top += spacing);
            txtTwitter.Location = new Point(left, top += spacing);
            txtWallet.Location = new Point(left, top += spacing);

            foreach (var tb in new[] { txtName, txtPhone, txtPassword, txtTelegram, txtTwitter, txtWallet })
            {
                tb.Size = new Size(width, height);
            }

            // Placeholders (수동 구현)
            SetPlaceholder(txtName, "Name");
            SetPlaceholder(txtPhone, "Phone Number");
            SetPlaceholder(txtPassword, "Password");
            SetPlaceholder(txtTelegram, "Telegram Handle (optional)");
            SetPlaceholder(txtTwitter, "Twitter Handle (optional)");
            SetPlaceholder(txtWallet, "Wallet Address (optional)");

            // 
            // btnRegister
            // 
            btnRegister.Text = "Register";
            btnRegister.Location = new Point(left, top + 50);
            btnRegister.Size = new Size(width, 35);
            btnRegister.BackColor = Color.FromArgb(76, 175, 80);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        }
    }
}
