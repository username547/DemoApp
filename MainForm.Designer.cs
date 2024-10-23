namespace DemoApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            mainContentPanel = new Panel();
            LoginBtn = new Button();
            mainControlPanel = new FlowLayoutPanel();
            ServiceBtn = new Button();
            LogoutBtn = new Button();
            mainControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(502, 34);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Учет заявок на ремонт оборудования";
            // 
            // mainContentPanel
            // 
            mainContentPanel.BackColor = Color.WhiteSmoke;
            mainContentPanel.Location = new Point(123, 64);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(940, 540);
            mainContentPanel.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(3, 3);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(87, 29);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Вход";
            LoginBtn.TextAlign = ContentAlignment.TopCenter;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // mainControlPanel
            // 
            mainControlPanel.BackColor = Color.WhiteSmoke;
            mainControlPanel.Controls.Add(LoginBtn);
            mainControlPanel.Controls.Add(ServiceBtn);
            mainControlPanel.Controls.Add(LogoutBtn);
            mainControlPanel.FlowDirection = FlowDirection.TopDown;
            mainControlPanel.Location = new Point(12, 64);
            mainControlPanel.Name = "mainControlPanel";
            mainControlPanel.Size = new Size(105, 540);
            mainControlPanel.TabIndex = 5;
            // 
            // ServiceBtn
            // 
            ServiceBtn.Location = new Point(3, 38);
            ServiceBtn.Name = "ServiceBtn";
            ServiceBtn.Size = new Size(87, 29);
            ServiceBtn.TabIndex = 5;
            ServiceBtn.Text = "Заявки";
            ServiceBtn.UseVisualStyleBackColor = true;
            ServiceBtn.Visible = false;
            ServiceBtn.Click += ServiceBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(3, 73);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(87, 29);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "Выйти";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Visible = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1071, 612);
            Controls.Add(mainControlPanel);
            Controls.Add(mainContentPanel);
            Controls.Add(titleLabel);
            Name = "MainForm";
            Text = "MainForm";
            mainControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Panel mainContentPanel;
        private Button LoginBtn;
        private FlowLayoutPanel mainControlPanel;
        private Button ServiceBtn;
        private Button LogoutBtn;
    }
}
