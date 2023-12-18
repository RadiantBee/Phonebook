namespace Exam
{
    partial class Form3
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
            this.PhonebookDataGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PhonebookDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PhonebookDataGrid
            // 
            this.PhonebookDataGrid.AllowUserToAddRows = false;
            this.PhonebookDataGrid.AllowUserToDeleteRows = false;
            this.PhonebookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhonebookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AddressColumn,
            this.GenderColumn,
            this.NumberColumn});
            this.PhonebookDataGrid.Location = new System.Drawing.Point(12, 11);
            this.PhonebookDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhonebookDataGrid.Name = "PhonebookDataGrid";
            this.PhonebookDataGrid.ReadOnly = true;
            this.PhonebookDataGrid.RowHeadersWidth = 51;
            this.PhonebookDataGrid.RowTemplate.Height = 29;
            this.PhonebookDataGrid.Size = new System.Drawing.Size(684, 302);
            this.PhonebookDataGrid.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Surname and name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 175;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MinimumWidth = 6;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 225;
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.MinimumWidth = 6;
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            this.GenderColumn.Width = 80;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Number";
            this.NumberColumn.MinimumWidth = 6;
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 327);
            this.Controls.Add(this.PhonebookDataGrid);
            this.Name = "Form3";
            this.Text = "Search results";
            ((System.ComponentModel.ISupportInitialize)(this.PhonebookDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView PhonebookDataGrid;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewTextBoxColumn NumberColumn;
    }
}