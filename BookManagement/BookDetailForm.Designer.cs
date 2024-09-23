namespace BookManagement
{
    partial class BookDetailForm
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
            txtBookList = new Label();
            grbBookInfo = new GroupBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookId = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            dtpPublicationDate = new DateTimePicker();
            cboBookCategoryId = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtBookList
            // 
            txtBookList.AutoSize = true;
            txtBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            txtBookList.ForeColor = Color.Yellow;
            txtBookList.Location = new Point(27, 571);
            txtBookList.Name = "txtBookList";
            txtBookList.Size = new Size(107, 31);
            txtBookList.TabIndex = 8;
            txtBookList.Text = "Book list";
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(48, 108);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1011, 460);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(226, 40);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(715, 38);
            txtBookId.TabIndex = 0;
            txtBookId.TextChanged += txtBookName_TextChanged;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookName.Location = new Point(17, 93);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookId.Location = new Point(17, 43);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(100, 31);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Book ID";
            lblBookId.Click += lblBookName_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.Yellow;
            lblTitle.Location = new Point(27, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(597, 106);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Book Manager";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDescription.Location = new Point(18, 145);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPublicationDate.Location = new Point(18, 257);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(193, 31);
            lblPublicationDate.TabIndex = 4;
            lblPublicationDate.Text = "Publication Date";
            lblPublicationDate.Click += label2_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblQuantity.Location = new Point(18, 308);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPrice.Location = new Point(557, 308);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblAuthor.Location = new Point(18, 360);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCategory.Location = new Point(18, 405);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(226, 93);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(715, 38);
            txtBookName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(226, 145);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(715, 106);
            txtDescription.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(227, 305);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(306, 38);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(655, 305);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(287, 38);
            txtPrice.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(227, 360);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(715, 38);
            txtAuthor.TabIndex = 6;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(227, 257);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(306, 38);
            dtpPublicationDate.TabIndex = 3;
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(227, 405);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(306, 39);
            cboBookCategoryId.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1094, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1094, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1336, 625);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBookList);
            Controls.Add(grbBookInfo);
            Controls.Add(lblTitle);
            Name = "BookDetailForm";
            Text = "Add | Update A Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtBookList;
        private GroupBox grbBookInfo;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookId;
        private Label lblTitle;
        private Label lblPublicationDate;
        private Label lblDescription;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPublicationDate;
        private Button btnSave;
        private Button btnCancel;
    }
}