using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        private BookService _service = new BookService();
        private Book _selected = null;
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetBooks();
        }

        private void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            //BookService service = new BookService();
            //dgvBookList.DataSource = null;
            //dgvBookList.DataSource = service.GetBooks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
            FillDataGridView();
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
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit!", "Select on book", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var books = new BookService().GetBooks();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Please select a certain book to delete!", "Select one book", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult answer = MessageBox.Show("Do you really want to delete this book", "Delete confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                return;
            }
            _service.DeleteBook(_selected);
            FillDataGridView();
            _selected = null;
        }
    }
}
