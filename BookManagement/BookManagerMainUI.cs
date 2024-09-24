using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        private Book _selected = null;
        public BookManagerMainUI()
        {
            InitializeComponent();
        }


        private void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = service.GetAllBooks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                BookDetailForm f = new BookDetailForm();
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit!", "Select on book", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => (x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower()))).ToList();
            dgvBookList.DataSource = books.Where(x =>
                x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) ||
                 x.Description.ToLower().Contains(txtDescription.Text.ToLower())
                ).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
