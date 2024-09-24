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
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName.ToString();
                txtDescription.Text = SelectedBook.Description.ToString();
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
