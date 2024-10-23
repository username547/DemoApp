namespace DemoApp.Pages
{
    partial class CreateCommentPage
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
            CommentInput = new TextBox();
            label1 = new Label();
            CreateCommentBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // CommentInput
            // 
            CommentInput.Location = new Point(3, 27);
            CommentInput.Multiline = true;
            CommentInput.Name = "CommentInput";
            CommentInput.Size = new Size(374, 135);
            CommentInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 1;
            label1.Text = "Добавление комментария";
            // 
            // CreateCommentBtn
            // 
            CreateCommentBtn.Location = new Point(3, 168);
            CreateCommentBtn.Name = "CreateCommentBtn";
            CreateCommentBtn.Size = new Size(91, 29);
            CreateCommentBtn.TabIndex = 2;
            CreateCommentBtn.Text = "Добавить";
            CreateCommentBtn.UseVisualStyleBackColor = true;
            CreateCommentBtn.Click += CreateCommentBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(100, 168);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(68, 29);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CreateCommentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackBtn);
            Controls.Add(CreateCommentBtn);
            Controls.Add(label1);
            Controls.Add(CommentInput);
            Name = "CreateCommentPage";
            Size = new Size(380, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CommentInput;
        private Label label1;
        private Button CreateCommentBtn;
        private Button BackBtn;
    }
}
