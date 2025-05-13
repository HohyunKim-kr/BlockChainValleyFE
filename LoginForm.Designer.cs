namespace BlockChainValleyFE
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGoToRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();

            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panelLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";

            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Location = new System.Drawing.Point(25, 25);
            this.panelLogin.Size = new System.Drawing.Size(350, 450);
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.lblPhone);
            this.panelLogin.Controls.Add(this.txtPhoneNumber);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnGoToRegister);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Welcome to BlockchainValley";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.AutoSize = true;

            // 
            // lblPhone
            // 
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Location = new System.Drawing.Point(30, 90);
            this.lblPhone.AutoSize = true;

            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(30, 115);
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 23);
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(30, 165);
            this.lblPassword.AutoSize = true;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 190);
            this.txtPassword.Size = new System.Drawing.Size(280, 23);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Login";
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 250);
            this.btnLogin.Size = new System.Drawing.Size(280, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // btnGoToRegister
            // 
            this.btnGoToRegister = new System.Windows.Forms.Button();
            this.btnGoToRegister.Text = "회원가입";
            this.btnGoToRegister.Location = new System.Drawing.Point(30, 300); // X: 30으로 정렬, Y도 위로
            this.btnGoToRegister.Size = new System.Drawing.Size(280, 30);
            this.btnGoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToRegister.BackColor = System.Drawing.Color.LightGray;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);

            this.panelLogin.Controls.Add(this.btnGoToRegister);
        }
    }
}
