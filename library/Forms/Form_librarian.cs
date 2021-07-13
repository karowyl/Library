using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form_librarian : Form
    {
        //public Librarian Librarian { get; set; }

        private string _closeButtonFullPath = @"C:\Users\Użytkownik\Desktop\CP4\grafika\close_16.png";
        TabPage _tpBooks;
        TabPage _tpAccounts;
        public Form_librarian()
        {
           // Librarian = librarian;
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (Form_accounts.IsNull)
            {
                _tpAccounts = new TabPage();
                ShowFormInTabPage(_tpAccounts, Form_accounts.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpAccounts;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if(Form_books.IsNull)
            {
                _tpBooks = new TabPage();
                ShowFormInTabPage(_tpBooks, Form_books.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpBooks;
            }
            
        }

        private void tpTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);

                var closeImage = new Bitmap(_closeButtonFullPath);
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tpTab_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(_closeButtonFullPath);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {

                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void ShowFormInTabPage(TabPage tpTab, Form frm)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ss = new Form1();
            ss.ShowDialog();

        }

    
    }
}
