using Services;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
