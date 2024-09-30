namespace BookManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grbAccountInfo = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            btnSearch = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.Yellow;
            lblTitle.Location = new Point(307, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 62);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Login";
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(btnSearch);
            grbAccountInfo.Controls.Add(txtPassword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbAccountInfo.ForeColor = Color.Yellow;
            grbAccountInfo.Location = new Point(170, 115);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(413, 282);
            grbAccountInfo.TabIndex = 0;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = "Account info";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(242, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 50);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(53, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(778, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(193, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(172, 38);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 38);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.Location = new Point(17, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmail.Location = new Point(17, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(762, 490);
            Controls.Add(grbAccountInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private GroupBox grbAccountInfo;
        private Button btnSearch;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnCancel;
        private Button btnLogin;
    }
}