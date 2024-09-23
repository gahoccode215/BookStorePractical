namespace BookManagement
{
    partial class BookManagerMainUI
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
            lblTitle = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            txtBookList = new Label();
            txtCopyright = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.Yellow;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(597, 106);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Manager";
            lblTitle.Click += label1_Click;
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(33, 118);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1011, 114);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Search Criteria";
            grbSearchCriteria.Enter += groupBox1_Enter;
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
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(564, 50);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(172, 38);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(162, 50);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(172, 38);
            txtBookName.TabIndex = 0;
            txtBookName.TextChanged += textBox1_TextChanged;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookDescription.Location = new Point(358, 50);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(200, 31);
            lblBookDescription.TabIndex = 1;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookName.Location = new Point(17, 50);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "Book Name";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(811, 252);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(193, 50);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(811, 329);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(811, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(811, 486);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(33, 269);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(752, 267);
            dgvBookList.TabIndex = 1;
            // 
            // txtBookList
            // 
            txtBookList.AutoSize = true;
            txtBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            txtBookList.ForeColor = Color.Yellow;
            txtBookList.Location = new Point(33, 235);
            txtBookList.Name = "txtBookList";
            txtBookList.Size = new Size(107, 31);
            txtBookList.TabIndex = 5;
            txtBookList.Text = "Book list";
            // 
            // txtCopyright
            // 
            txtCopyright.AutoSize = true;
            txtCopyright.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            txtCopyright.ForeColor = Color.Yellow;
            txtCopyright.Location = new Point(33, 547);
            txtCopyright.Name = "txtCopyright";
            txtCopyright.Size = new Size(263, 31);
            txtCopyright.TabIndex = 10;
            txtCopyright.Text = "© 2024 GaHocCode215";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1107, 587);
            Controls.Add(txtCopyright);
            Controls.Add(txtBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblTitle);
            ForeColor = Color.Black;
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbSearchCriteria;
        private Label lblBookName;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private TextBox txtBookDescription;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label txtBookList;
        private Label txtCopyright;
    }
}
