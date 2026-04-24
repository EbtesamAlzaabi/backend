namespace StudentManagementSystem
{
    partial class Form1
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
            Label label2;
            label1 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtMajor = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new Button();
            btnShowAll = new Button();
            dgvStudents = new DataGridView();
            txtSearchBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Major";
            // 
            // txtID
            // 
            txtID.Location = new Point(54, 103);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(323, 103);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(100, 23);
            txtMajor.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(309, 175);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(75, 23);
            txtSearch.TabIndex = 8;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = true;
            txtSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(443, 175);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
           
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(34, 260);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(531, 338);
            dgvStudents.TabIndex = 10;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(486, 103);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search by name...";
            txtSearchBox.Size = new Size(112, 23);
            txtSearchBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 649);
            Controls.Add(txtSearchBox);
            Controls.Add(dgvStudents);
            Controls.Add(btnShowAll);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtMajor);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtMajor;
        private Button btnAdd;
        private Button btnDelete;
        private Button txtSearch;
        private Button btnShowAll;
        private DataGridView dgvStudents;
        private TextBox txtSearchBox;
    }
}
