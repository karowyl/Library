namespace library
{
    partial class Form_books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBooks = new System.Windows.Forms.TableLayoutPanel();
            this.pBooks = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.butcREATE = new System.Windows.Forms.Button();
            this.listOfBooks = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxIdBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.label7 = new System.Windows.Forms.Label();
            this.tlpBooks.SuspendLayout();
            this.pBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBooks
            // 
            this.tlpBooks.ColumnCount = 1;
            this.tlpBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBooks.Controls.Add(this.pBooks, 0, 0);
            this.tlpBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBooks.Location = new System.Drawing.Point(0, 0);
            this.tlpBooks.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBooks.Name = "tlpBooks";
            this.tlpBooks.RowCount = 1;
            this.tlpBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpBooks.Size = new System.Drawing.Size(747, 30);
            this.tlpBooks.TabIndex = 0;
            // 
            // pBooks
            // 
            this.pBooks.Controls.Add(this.btnRefresh);
            this.pBooks.Controls.Add(this.btnFind);
            this.pBooks.Controls.Add(this.btnRemove);
            this.pBooks.Controls.Add(this.btnModify);
            this.pBooks.Controls.Add(this.butcREATE);
            this.pBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBooks.Location = new System.Drawing.Point(2, 2);
            this.pBooks.Margin = new System.Windows.Forms.Padding(2);
            this.pBooks.Name = "pBooks";
            this.pBooks.Size = new System.Drawing.Size(743, 28);
            this.pBooks.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::library.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(413, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFind.Image = global::library.Properties.Resources.finder;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(310, 0);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(103, 28);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::library.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(208, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::library.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(102, 0);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(106, 28);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = " Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // butcREATE
            // 
            this.butcREATE.BackColor = System.Drawing.Color.White;
            this.butcREATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butcREATE.Dock = System.Windows.Forms.DockStyle.Left;
            this.butcREATE.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butcREATE.Image = global::library.Properties.Resources.add_24;
            this.butcREATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butcREATE.Location = new System.Drawing.Point(0, 0);
            this.butcREATE.Margin = new System.Windows.Forms.Padding(2);
            this.butcREATE.Name = "butcREATE";
            this.butcREATE.Size = new System.Drawing.Size(102, 28);
            this.butcREATE.TabIndex = 1;
            this.butcREATE.Text = "Add";
            this.butcREATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butcREATE.UseVisualStyleBackColor = false;
            this.butcREATE.Click += new System.EventHandler(this.butcREATE_Click);
            // 
            // listOfBooks
            // 
            this.listOfBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Author,
            this.Title,
            this.Type,
            this.Date,
            this.Pages});
            this.listOfBooks.HideSelection = false;
            this.listOfBooks.Location = new System.Drawing.Point(2, 34);
            this.listOfBooks.Margin = new System.Windows.Forms.Padding(2);
            this.listOfBooks.Name = "listOfBooks";
            this.listOfBooks.Size = new System.Drawing.Size(746, 323);
            this.listOfBooks.TabIndex = 1;
            this.listOfBooks.UseCompatibleStateImageBehavior = false;
            this.listOfBooks.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 180;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 262;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 70;
            // 
            // Pages
            // 
            this.Pages.Text = "Pages";
            this.Pages.Width = 80;
            // 
            // textBoxIdBook
            // 
            this.textBoxIdBook.Location = new System.Drawing.Point(3, 446);
            this.textBoxIdBook.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdBook.Name = "textBoxIdBook";
            this.textBoxIdBook.Size = new System.Drawing.Size(119, 20);
            this.textBoxIdBook.TabIndex = 6;
            this.textBoxIdBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIdBook_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-1, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(126, 446);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(119, 20);
            this.textBoxAuthor.TabIndex = 21;
            this.textBoxAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthor_KeyDown);
            this.textBoxAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthor_KeyUp);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(249, 446);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(130, 20);
            this.textBoxTitle.TabIndex = 22;
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyUp);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(506, 445);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(119, 20);
            this.textBoxDate.TabIndex = 24;
            this.textBoxDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDate_KeyDown);
            this.textBoxDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDate_KeyUp);
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(629, 445);
            this.textBoxPages.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(119, 20);
            this.textBoxPages.TabIndex = 25;
            this.textBoxPages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPages_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(122, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(245, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(379, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(502, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(625, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Pages:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Book",
            "Audiobook"});
            this.comboBoxType.Location = new System.Drawing.Point(383, 445);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxType.TabIndex = 31;
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Location = new System.Drawing.Point(76, 379);
            this.textBoxPhrase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(672, 20);
            this.textBoxPhrase.TabIndex = 32;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(-1, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Search:";
            // 
            // Form_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPhrase);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdBook);
            this.Controls.Add(this.listOfBooks);
            this.Controls.Add(this.tlpBooks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_books";
            this.Text = "Books";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_books_FormClosed);
            this.tlpBooks.ResumeLayout(false);
            this.pBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBooks;
        private System.Windows.Forms.Panel pBooks;
        private System.Windows.Forms.Button butcREATE;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listOfBooks;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Pages;
        private System.Windows.Forms.TextBox textBoxIdBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxPhrase;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label7;
    }
}