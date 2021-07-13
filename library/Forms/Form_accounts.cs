using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using library.Forms;
using System.Threading;

namespace library
{
    public partial class Form_accounts : Form
    {

        private static Form_accounts _instance = null;
        public static Form_accounts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form_accounts();
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
        public Form_accounts()
        {
            InitializeComponent();
            ShowUsersInList();
        }

        private void Form_accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowUsersInList();
        }

        public void ShowUsersInList()
        {
            Database database = new Database();
            List<User> users = database.GetUsers();
            listOfUsers.Items.Clear();


            foreach (User user in users)
            {
                string[] arr = new string[7];
                ListViewItem item;
                arr[0] = user.User_id.ToString();
                arr[1] = user.Login;
                arr[2] = user.FirstName;
                arr[3] = user.LastName;
                arr[5] = user.PhoneNumber;
                arr[4] = user.EmailAddress;
                arr[6] = user.Permission.ToString();
                item = new ListViewItem(arr);
                listOfUsers.Items.Add(item);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxIdUser.Text))
                {
                    throw new Exception("Please, put user Id");
                }
                Database database = new Database();
                database.RemoveUser(Convert.ToInt32(textBoxIdUser.Text));
                MessageBox.Show("You have removed the acccount");
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
                if (string.IsNullOrWhiteSpace(textBoxIdUser.Text) 
                    || string.IsNullOrWhiteSpace(textBoxLogin.Text) 
                    || string.IsNullOrWhiteSpace(textBoxFirstName.Text) 
                    || string.IsNullOrWhiteSpace(textBoxLastName.Text) 
                    || string.IsNullOrWhiteSpace(textBoxPhoneNr.Text) 
                    || string.IsNullOrWhiteSpace(textBoxPermission.Text) 
                    || string.IsNullOrWhiteSpace(textBoxEmailAddress.Text))
                {
                    throw new Exception("Please, fill all needed fields");
                }
                Database database = new Database();
                database.ModifyUser(Convert.ToInt32(textBoxIdUser.Text), textBoxLogin.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNr.Text, textBoxEmailAddress.Text, textBoxPermission.Text);
                MessageBox.Show("You have modified the acccount");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            //this.Hide();
            //Email ss = new Email();
            //ss.Show();
        }
        private static void ThreadStart()
        {
            Application.Run(new Email()); // <-- other form started on its own UI thread
        }

        public void findUser(string phrase)
        {
            Database database = new Database();
            List<User> users = database.GetUsers();
            listOfUsers.Items.Clear();

            var selectedUsers = users.Where(x =>
            x.Login.ToLower() == phrase ||
            x.FirstName.ToLower() == phrase ||
            x.LastName.ToLower() == phrase ||
            x.PhoneNumber.ToLower() == phrase ||
            x.EmailAddress.ToLower() == phrase ||
            x.Permission.ToString().ToLower() == phrase).ToList();

            foreach (var user in selectedUsers)
            {
                string[] arr = new string[7];
                ListViewItem item;
                arr[0] = user.User_id.ToString();
                arr[1] = user.Login;
                arr[2] = user.FirstName;
                arr[3] = user.LastName;
                arr[5] = user.PhoneNumber;
                arr[4] = user.EmailAddress;
                arr[6] = user.Permission.ToString();
                item = new ListViewItem(arr);
                listOfUsers.Items.Add(item);
            }

        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            findUser(textBoxPhrase.Text.ToLower());
        }

        private void textBoxIdUser_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.Up)
            {

                textBoxIdUser.Focus();
            }
            else if(e.KeyCode == Keys.Right)
            {
                textBoxLogin.Focus();
            }
        }

        private void textBoxLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxFirstName.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                textBoxPhoneNr.Focus();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPhoneNr.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {

                textBoxFirstName.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                textBoxEmailAddress.Focus();
            }
        }

        private void textBoxPhoneNr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxLogin.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {

                textBoxLastName.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                textBoxPermission.Focus();
            }
        }

        private void textBoxEmailAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxLogin.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                textBoxPermission.Focus();
            }
        }

        private void textBoxPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBoxPhoneNr.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                textBoxEmailAddress.Focus();
            }
        }
    }
}
