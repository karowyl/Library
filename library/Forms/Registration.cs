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
using System.IO;
using System.Text.RegularExpressions;

namespace library
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.ActiveControl = textBoxLogin;
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button_Aplly(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (IsLoginUnique())
                {
                    User user = new User(textBoxLogin.Text, textBoxPassword.Text.ToString(), textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNr.Text, textBoxEmail.Text);

                    Database db = new Database();

                    db.Registration(user);
                    MessageBox.Show("You have created account", "Please, back to menu");
                }
            }
        }

        // data validation
        private bool ValidateData()
        {
            try
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniMaxChars = new Regex(@".{8,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                var hasNineDigits = new Regex(@"^(\d{ 9 })$");

                if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPhoneNr.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    throw new Exception("All fields have to be filled");
                }
                else if (!hasLowerChar.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password should contain at least one lower case letter.");
                }
                else if (!hasUpperChar.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password should contain at least one upper case letter.");
                }
                else if (!hasMiniMaxChars.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception ("Password should not be lesser than 8 or greater than 15 characters.");
                }
                else if (!hasNumber.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password should contain at least one numeric value.");
                }
                else if (!hasSymbols.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password should contain at least one special case character.");
                }
                else if (!Regex.Match(textBoxPhoneNr.Text, @"^(\d{9})$").Success)
                {
                    throw new Exception("Phone number has to contain 9 digits.");
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }

        // checks if username is occupied
        private bool IsLoginUnique()
        {
            string query = "SELECT * FROM Users";

            Database db = new Database();
            SQLiteCommand cmd = new SQLiteCommand(query, db.myConnection);

            db.OpenConnection();
            var results = cmd.ExecuteReader();

            if (results.HasRows)
            {
                while (results.Read())
                {
                    if (results["login"].ToString() == textBoxLogin.Text)
                    {
                        MessageBox.Show("Username is already in use", "Registration error");
                        db.CloseConnection();
                        return false;
                    }
                }
            }
            db.CloseConnection();
            return true;
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxFirstName.Focus();
            }
        }

        private void textBoxFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxLastName.Focus();
            }
        }

        private void textBoxLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPhoneNr.Focus();
            }
        }

        private void textBoxPhoneNr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxLastName.Focus();
            }
        }

        private void textBoxLastName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxFirstName.Focus();
            }
        }

        private void textBoxFirstName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxLogin.Focus();
            }
        }

        private void textBoxPhoneNr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Apply.PerformClick();
            }
            
        }
    }
}
