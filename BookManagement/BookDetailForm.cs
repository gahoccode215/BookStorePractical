using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;

namespace BookManagement
{
    public partial class BookDetailForm : Form
    {
        public Book SelectedBook { get; set; } = null;
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void lblBookName_Click(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {

            BookCategoryService cat = new BookCategoryService();
            cboBookCategoryId.DataSource = cat.GetAllCategories();
            cboBookCategoryId.DisplayMember = "BookGenreType";
            cboBookCategoryId.ValueMember = "BookCategoryId";
            //cboBookCategoryId.SelectedValue = 5;
            if (SelectedBook != null)
            {
                lblTitle.Text = "Update a selected book";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookId.Enabled = false;
                txtBookName.Text = SelectedBook.BookName.ToString();
                txtDescription.Text = SelectedBook.Description.ToString();
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
                lblTitle.Text = "Create a new book";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString())
            };
            BookService service = new();
            if(SelectedBook != null)
                service.UpdateBook(book);
            else
                service.AddBook(book);
            Close();
        }
    }
}
