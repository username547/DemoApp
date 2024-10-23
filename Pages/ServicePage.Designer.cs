namespace DemoApp.Pages
{
    partial class ServicePage
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
            label1 = new Label();
            DeleteServiceBtn = new Button();
            UpdateServiceBtn = new Button();
            CreateServiceBtn = new Button();
            serviceContentPanel = new Panel();
            CreateCommentBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 2;
            label1.Text = "Заявки";
            // 
            // DeleteServiceBtn
            // 
            DeleteServiceBtn.Location = new Point(230, 27);
            DeleteServiceBtn.Name = "DeleteServiceBtn";
            DeleteServiceBtn.Size = new Size(94, 29);
            DeleteServiceBtn.TabIndex = 10;
            DeleteServiceBtn.Text = "Удалить";
            DeleteServiceBtn.UseVisualStyleBackColor = true;
            DeleteServiceBtn.Click += DeleteServiceBtn_Click;
            // 
            // UpdateServiceBtn
            // 
            UpdateServiceBtn.Location = new Point(103, 27);
            UpdateServiceBtn.Name = "UpdateServiceBtn";
            UpdateServiceBtn.Size = new Size(121, 29);
            UpdateServiceBtn.TabIndex = 9;
            UpdateServiceBtn.Text = "Редактировать";
            UpdateServiceBtn.UseVisualStyleBackColor = true;
            UpdateServiceBtn.Click += UpdateServiceBtn_Click;
            // 
            // CreateServiceBtn
            // 
            CreateServiceBtn.Location = new Point(3, 27);
            CreateServiceBtn.Name = "CreateServiceBtn";
            CreateServiceBtn.Size = new Size(94, 29);
            CreateServiceBtn.TabIndex = 8;
            CreateServiceBtn.Text = "Добавить";
            CreateServiceBtn.UseVisualStyleBackColor = true;
            CreateServiceBtn.Click += CreateServiceBtn_Click;
            // 
            // serviceContentPanel
            // 
            serviceContentPanel.Location = new Point(3, 62);
            serviceContentPanel.Name = "serviceContentPanel";
            serviceContentPanel.Size = new Size(934, 475);
            serviceContentPanel.TabIndex = 11;
            // 
            // CreateCommentBtn
            // 
            CreateCommentBtn.Location = new Point(330, 27);
            CreateCommentBtn.Name = "CreateCommentBtn";
            CreateCommentBtn.Size = new Size(197, 29);
            CreateCommentBtn.TabIndex = 12;
            CreateCommentBtn.Text = "Добавить комментарий";
            CreateCommentBtn.UseVisualStyleBackColor = true;
            CreateCommentBtn.Click += CreateCommentBtn_Click;
            // 
            // ServicePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateCommentBtn);
            Controls.Add(serviceContentPanel);
            Controls.Add(DeleteServiceBtn);
            Controls.Add(UpdateServiceBtn);
            Controls.Add(CreateServiceBtn);
            Controls.Add(label1);
            Name = "ServicePage";
            Size = new Size(940, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button DeleteServiceBtn;
        private Button UpdateServiceBtn;
        private Button CreateServiceBtn;
        private Panel serviceContentPanel;
        private Button CreateCommentBtn;
    }
}
