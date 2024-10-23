namespace DemoApp.Pages
{
    partial class UpdateServicePage
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
            BackBtn = new Button();
            PriceTextBox = new TextBox();
            label9 = new Label();
            UpdateBtn = new Button();
            ReasonTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            DescTextBox = new TextBox();
            EmployeeComboBox = new ComboBox();
            label6 = new Label();
            TypeComboBox = new ComboBox();
            label5 = new Label();
            DeviceComboBox = new ComboBox();
            label4 = new Label();
            PriorityComboBox = new ComboBox();
            label3 = new Label();
            ClientComboBox = new ComboBox();
            label2 = new Label();
            label10 = new Label();
            StatusComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "Редактирование заявки";
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(129, 383);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(61, 29);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(333, 156);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(320, 27);
            PriceTextBox.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(333, 132);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 36;
            label9.Text = "Стоимость";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(0, 383);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(123, 29);
            UpdateBtn.TabIndex = 35;
            UpdateBtn.Text = "Редактировать";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ReasonTextBox
            // 
            ReasonTextBox.Location = new Point(333, 263);
            ReasonTextBox.Multiline = true;
            ReasonTextBox.Name = "ReasonTextBox";
            ReasonTextBox.Size = new Size(320, 114);
            ReasonTextBox.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 240);
            label8.Name = "label8";
            label8.Size = new Size(183, 20);
            label8.TabIndex = 33;
            label8.Text = "Причина неисправности";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 240);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 32;
            label7.Text = "Описание проблемы";
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(3, 263);
            DescTextBox.Multiline = true;
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(320, 114);
            DescTextBox.TabIndex = 31;
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Items.AddRange(new object[] { "нет", "низкий", "ниже среднего", "средний", "выше среднего", "высокий" });
            EmployeeComboBox.Location = new Point(333, 47);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new Size(320, 28);
            EmployeeComboBox.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 24);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 29;
            label6.Text = "Сотрудник";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Малая поломка", "Средняя поломка", "Крупная поломка", "Потеря работоспособности", "Индивидуальное" });
            TypeComboBox.Location = new Point(3, 155);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(320, 28);
            TypeComboBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 27;
            label5.Text = "Тип неисправности";
            // 
            // DeviceComboBox
            // 
            DeviceComboBox.FormattingEnabled = true;
            DeviceComboBox.Items.AddRange(new object[] { "нет", "низкий", "ниже среднего", "средний", "выше среднего", "высокий" });
            DeviceComboBox.Location = new Point(333, 101);
            DeviceComboBox.Name = "DeviceComboBox";
            DeviceComboBox.Size = new Size(320, 28);
            DeviceComboBox.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 78);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 25;
            label4.Text = "Оборудование";
            // 
            // PriorityComboBox
            // 
            PriorityComboBox.FormattingEnabled = true;
            PriorityComboBox.Items.AddRange(new object[] { "нет", "низкий", "ниже среднего", "средний", "выше среднего", "высокий" });
            PriorityComboBox.Location = new Point(3, 101);
            PriorityComboBox.Name = "PriorityComboBox";
            PriorityComboBox.Size = new Size(320, 28);
            PriorityComboBox.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 78);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 23;
            label3.Text = "Приоритет";
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(3, 47);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(320, 28);
            ClientComboBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 21;
            label2.Text = "Клиент";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 186);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 38;
            label10.Text = "Статус заявки";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Малая поломка", "Средняя поломка", "Крупная поломка", "Потеря работоспособности", "Индивидуальное" });
            StatusComboBox.Location = new Point(3, 209);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(320, 28);
            StatusComboBox.TabIndex = 39;
            // 
            // UpdateServicePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StatusComboBox);
            Controls.Add(label10);
            Controls.Add(PriceTextBox);
            Controls.Add(label9);
            Controls.Add(UpdateBtn);
            Controls.Add(ReasonTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(DescTextBox);
            Controls.Add(EmployeeComboBox);
            Controls.Add(label6);
            Controls.Add(TypeComboBox);
            Controls.Add(label5);
            Controls.Add(DeviceComboBox);
            Controls.Add(label4);
            Controls.Add(PriorityComboBox);
            Controls.Add(label3);
            Controls.Add(ClientComboBox);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(label1);
            Name = "UpdateServicePage";
            Size = new Size(662, 416);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackBtn;
        private TextBox PriceTextBox;
        private Label label9;
        private Button UpdateBtn;
        private TextBox ReasonTextBox;
        private Label label8;
        private Label label7;
        private TextBox DescTextBox;
        private ComboBox EmployeeComboBox;
        private Label label6;
        private ComboBox TypeComboBox;
        private Label label5;
        private ComboBox DeviceComboBox;
        private Label label4;
        private ComboBox PriorityComboBox;
        private Label label3;
        private ComboBox ClientComboBox;
        private Label label2;
        private Label label10;
        private ComboBox StatusComboBox;
    }
}
