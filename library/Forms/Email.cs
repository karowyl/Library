using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace library.Forms
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.ActiveControl = textBoxSender;
        }

        OpenFileDialog ofdAttachment;
        String fileName = "";

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                AddFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSender.Text) 
                    || string.IsNullOrWhiteSpace(textBoxPassword.Text) 
                    || string.IsNullOrWhiteSpace(textBoxRecipientEmail.Text))
                {
                    throw new Exception("Please, fill the field");
                }

                Thread email = new Thread(SendMail);
                email.IsBackground = true;
                email.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddFile()
        {
            ofdAttachment = new OpenFileDialog();
            ofdAttachment.Filter = "Images(.jpg, .png)|*.png;*.jpg;|Pdf Files|*.pdf";
            if (ofdAttachment.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdAttachment.FileName;
            }
        }


        /*
         Server Address: smtp-mail.outlook.com
        Username: Your Outlook Email Address (e.g. example@outlook.com)
        Password: Your Outlook Password
        Port Number: 587 (With TLS)
        Alternative Port Number: 25 (Without TLS/SSL)
        Sending Limits: 300 Emails a day or 100 recepients a day.
        -----------------------------------------------------
        SMTP username: Your Gmail address
        SMTP password: Your Gmail password
        SMTP server address: smtp.gmail.com
        Gmail SMTP port (TLS): 587
        SMTP port (SSL): 465
        SMTP TLS/SSL required: yes
        */
        public void SendMail()
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp-mail.outlook.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(textBoxSender.Text.Trim(), textBoxPassword.Text.Trim());

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(textBoxSender.Text.Trim());
                mailDetails.To.Add(textBoxRecipientEmail.Text.Trim());
                mailDetails.Subject = textBoxSubject.Text.Trim();
                mailDetails.Body = textBoxMessage.Text.Trim();

                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }

                clientDetails.Send(mailDetails);
                MessageBox.Show("Your mail has been sent.");
                fileName = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxRecipientEmail.Focus();
            }
        }

        private void textBoxRecipientEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxSubject.Focus();
            }
        }

        private void textBoxSubject_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxRecipientEmail.Focus();
            }
        }

        private void textBoxRecipientEmail_KeyUp(object sender, KeyEventArgs e)
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
                textBoxSender.Focus();
            }
        }
    }
}
