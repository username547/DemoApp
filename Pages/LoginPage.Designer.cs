namespace DemoApp.Pages
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginInput = new TextBox();
            passwordInput = new TextBox();
            loginLbl = new Label();
            passwordLbl = new Label();
            loginBtn = new Button();
            LoginPageTitle = new Label();
            SuspendLayout();
            // 
            // loginInput
            // 
            loginInput.Location = new Point(3, 47);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(220, 27);
            loginInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(3, 100);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(220, 27);
            passwordInput.TabIndex = 1;
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Location = new Point(3, 24);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(52, 20);
            loginLbl.TabIndex = 2;
            loginLbl.Text = "Логин";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(3, 77);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(62, 20);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "Пароль";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(3, 133);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(62, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Войти";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginPageTitle
            // 
            LoginPageTitle.AutoSize = true;
            LoginPageTitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginPageTitle.Location = new Point(0, 0);
            LoginPageTitle.Name = "LoginPageTitle";
            LoginPageTitle.Size = new Size(54, 24);
            LoginPageTitle.TabIndex = 5;
            LoginPageTitle.Text = "Вход";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginPageTitle);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(loginLbl);
            Controls.Add(passwordInput);
            Controls.Add(loginInput);
            Name = "LoginPage";
            Size = new Size(250, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginInput;
        private TextBox passwordInput;
        private Label loginLbl;
        private Label passwordLbl;
        private Button loginBtn;
        private Label LoginPageTitle;
    }
}
