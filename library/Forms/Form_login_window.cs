using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPasswordLog.PasswordChar = '*';
            this.ActiveControl = textBoxUsername;
        }

        private void buttonSingIn(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                Database db = new Database();
                User user = db.Login(textBoxUsername.Text);

                if (Permission() == 1)
                {
                    Librarian librarian = new Librarian(user);

                    this.Hide();
                    Form_librarian ss = new Form_librarian();
                    ss.ShowDialog();
                }
                else if(Permission() == 0)
                {
                    Client client = new Client(user);
                    this.Hide();
                    Form_client ss = new Form_client(client);
                    ss.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Account does not exist", "Error");
                }
            }
        }


        private void buttonSingUp(object sender, EventArgs e)
        {
            this.Hide();
                Registration ss = new Registration();
            ss.Show();
        }

        private bool ValidateDate()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPasswordLog.Text))
                    throw new Exception("All fields have to be filled");
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }
        private int Permission()
        {
            string permission = "SELECT * FROM Users" ;

            Database db = new Database();
            

            db.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(permission, db.myConnection);
            var results = cmd.ExecuteReader();

            while (results.Read())
            {

                if (results["login"].ToString() == textBoxUsername.Text && results["password"].ToString() == Protection.CreateMD5(textBoxPasswordLog.Text))
                {
                    if (results["Permission"].ToString() == "0")
                    {
                        db.CloseConnection();
                        return 0;
                    }
                    else
                    {
                        db.CloseConnection();
                        return 1;
                    }
                }
            }

            db.CloseConnection();
            return -1;
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPasswordLog.Focus();
            }
        }

        private void textBoxPasswordLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SingIn.PerformClick();
            }
        }

        private void textBoxPasswordLog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxUsername.Focus();
            }
        }
    }

    
}
