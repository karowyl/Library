using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form_client : Form
    {
        public Client Client { get; set; }
        public Form_client(Client client)
        {
            Client = client;
            InitializeComponent();
            ShowBooksInList();
            ShowBorrowedBooksInList();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        public void ShowBooksInList()
        {
            Database database = new Database();
            string query = "SELECT * FROM books WHERE Available = 1";
            List<Book> books = database.GetBooks(query);
            listViewAvailableBooks.Items.Clear();
            foreach (Book book in books)
            {
                var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                var listViewBooks = new ListViewItem(row);
                listViewBooks.Tag = book;
                listViewAvailableBooks.Items.Add(listViewBooks);
            }
        }

        public void ShowBorrowedBooksInList()
        {
            Database database = new Database();
            List<Book> books = database.GetBorrowedBooks(Client);
            listOfBrrowedBooks.Items.Clear();
            foreach (Book book in books)
            {
                var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                var listViewBooks = new ListViewItem(row);
                listViewBooks.Tag = book;
                listOfBrrowedBooks.Items.Add(listViewBooks);
            }
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(textBoxId.Text))
                {
                    throw new Exception("Please, fill the field");
                }
                else if(!Regex.IsMatch(textBoxId.Text, @"^\d+$"))
                {
                    throw new Exception("Incorrect data");
                }

                Database database = new Database();
                int idBook = Convert.ToInt32(textBoxId.Text);
                bool isFound = false;
                List<Book> books = database.GetBorrowedBooks(Client);

                foreach(var book in books)
                {
                    if(book.Book_id == idBook)
                    {
                        isFound = true;
                        break;
                    }
                }

                if(!isFound)
                {
                    throw new Exception("You do not have borrrowed this book");
                }

                database.ReturnBook(idBook);
                ShowBooksInList();
                ShowBorrowedBooksInList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();

                if (database.IsBorrowed(Convert.ToInt32(txtBoxOpinions.Text)))
                {
                    throw new Exception("This book is borrowed!");
                }

                database.BorrowBook(Client, Convert.ToInt32(txtBoxOpinions.Text));
                ShowBooksInList();
                ShowBorrowedBooksInList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }


        private void buttonAddOpinion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxId.Text))
                {
                    throw new Exception("Please, fill the field");
                }
                else if (!Regex.IsMatch(textBoxId.Text, @"^\d+$"))
                {
                    throw new Exception("Incorrect data");
                }

                Database database = new Database();
                database.AddOpinion(Client, Convert.ToInt32(textBoxId.Text), textBoxOpinion.Text);
                MessageBox.Show("You added opinion");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void buttonSeeOpinions_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxOpinions.Text))
                {
                    throw new Exception("Please, fill the field");
                }
                else if (!Regex.IsMatch(txtBoxOpinions.Text, @"^\d+$"))
                {
                    throw new Exception("Incorrect data");
                }

                Database database = new Database();
                List<Opinion> opinions = database.GetOpinions(Convert.ToInt32(txtBoxOpinions.Text));
                listViewOpinions.Items.Clear();

                foreach (var opinion in opinions)
                {
                    string[] arr = new string[3];
                    ListViewItem item;
                    arr[0] = opinion.GetUser(opinion.UserId);
                    arr[1] = opinion.GetBook(opinion.BookId);
                    arr[2] = opinion.Description;
                    item = new ListViewItem(arr);
                    listViewOpinions.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
        public void findBook(string phrase)
        {
            Database database = new Database();
            string query = "SELECT * FROM books WHERE Available = 1";
            List<Book> books = database.GetBooks(query);
            listViewAvailableBooks.Items.Clear();


            var selectedBooks = books.Where(x =>
            phrase != null &&
            x.Author.ToLower() == phrase ||
            x.Title.ToLower() == phrase ||
            x.Date.ToLower() == phrase ||
            x.Type.ToLower() == phrase ||
            x.Pages.ToString().ToLower() == phrase).ToList();

            if (phrase == "")
            {
                foreach (Book book in books)
                {
                    var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                    var listViewBooks = new ListViewItem(row);
                    listViewBooks.Tag = book;
                    listViewAvailableBooks.Items.Add(listViewBooks);
                }
            }
            else
            {
                foreach (var book in selectedBooks)
                {
                    var row = new string[] { book.Book_id.ToString(), book.Author, book.Title, book.Type, book.Date, book.Pages.ToString() };
                    var listViewBooks = new ListViewItem(row);
                    listViewBooks.Tag = book;
                    listViewAvailableBooks.Items.Add(listViewBooks);
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
                findBook(textBoxPhrase.Text.ToLower());
            
        }
    }
}
