namespace DemoApp.Pages
{
    partial class ListServicePage
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
            ServiceDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ServiceDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 0;
            label1.Text = "Список заявок";
            // 
            // ServiceDataGrid
            // 
            ServiceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceDataGrid.Location = new Point(3, 27);
            ServiceDataGrid.Name = "ServiceDataGrid";
            ServiceDataGrid.RowHeadersWidth = 51;
            ServiceDataGrid.Size = new Size(928, 445);
            ServiceDataGrid.TabIndex = 1;
            ServiceDataGrid.SelectionChanged += ServiceDataGrid_SelectionChanged;
            // 
            // ListServicePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ServiceDataGrid);
            Controls.Add(label1);
            Name = "ListServicePage";
            Size = new Size(934, 475);
            ((System.ComponentModel.ISupportInitialize)ServiceDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ServiceDataGrid;
    }
}
