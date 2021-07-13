using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace library
{
    public partial class Form_books : Form
    {
        private static Form_books _instance = null;
        public static Form_books Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form_books();
                }
                return _instance;
                
            }
        }
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private Form_books()
        {
            InitializeComponent();
            ShowBooksInList();
            this.ActiveControl = textBoxPhrase;
        }

        private void Form_books_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        public void ShowBooksInList()
        {
            Database database = new Database();
            string query = "SELECT * FROM books";
            List<Book> books = database.GetBooks(query);
            listOfBooks.Items.Clear();

            foreach (Book book in books)
            {
                var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                var listViewBooks = new ListViewItem(row);
                listViewBooks.Tag = book;
                listOfBooks.Items.Add(listViewBooks);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxIdBook.Text))
                {
                    throw new Exception("Please, put book Id");
                }

                Database database = new Database();
                database.RemoveBook(Convert.ToInt32(textBoxIdBook.Text));
                MessageBox.Show("You have removed the book");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxIdBook.Text)
                    || string.IsNullOrWhiteSpace(textBoxAuthor.Text)
                    || string.IsNullOrWhiteSpace(textBoxTitle.Text)
                    || string.IsNullOrWhiteSpace(comboBoxType.Text)
                    || string.IsNullOrWhiteSpace(textBoxDate.Text)
                    || string.IsNullOrWhiteSpace(textBoxPages.Text))
                {
                    throw new Exception("Please, fill all needed fields");
                }

                Database database = new Database();
                database.ModifyBook(Convert.ToInt32(textBoxIdBook.Text), textBoxAuthor.Text, textBoxTitle.Text, comboBoxType.Text, textBoxDate.Text, Convert.ToInt32(textBoxPages.Text));
                MessageBox.Show("You have modified the book");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowBooksInList();
        }

        private void butcREATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxAuthor.Text) || string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(comboBoxType.Text) || string.IsNullOrWhiteSpace(textBoxDate.Text) || string.IsNullOrWhiteSpace(textBoxPages.Text))
                {
                    throw new Exception("Please, fill all the fields");
                }

                Book book = new Book(textBoxAuthor.Text, textBoxTitle.Text, comboBoxType.Text, textBoxDate.Text, Convert.ToInt32(textBoxPages.Text), 1);

                Database db = new Database();

                db.AddBook(book);
                MessageBox.Show("You have added new book");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void findBook(string phrase)
        {
            Database database = new Database();
            string query = "SELECT * FROM books";
            List<Book> books = database.GetBooks(query);
            listOfBooks.Items.Clear();

            var selectedBooks = books.Where(x => 
            x.Author.ToLower() == phrase || 
            x.Title.ToLower() == phrase || 
            x.Date.ToLower() == phrase || 
            x.Type.ToLower() == phrase || 
            x.Pages.ToString().ToLower() == phrase).ToList();

            foreach (var book in selectedBooks)
            {
                var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                var listViewBooks = new ListViewItem(row);
                listViewBooks.Tag = book;
                listOfBooks.Items.Add(listViewBooks);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            findBook(textBoxPhrase.Text.ToLower());
        }

        private void textBoxIdBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                textBoxAuthor.Focus();
            }
        }

        private void textBoxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                textBoxTitle.Focus();
            }
        }

        private void textBoxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                textBoxDate.Focus();
            }
        }

        private void textBoxDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                textBoxPages.Focus();
            }
        }

        private void textBoxPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxDate.Focus();
            }
        }

        private void textBoxDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxTitle.Focus();
            }
        }

        private void textBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxAuthor.Focus();
            }
        }

        private void textBoxAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxIdBook.Focus();
            }
        }
    }
}
