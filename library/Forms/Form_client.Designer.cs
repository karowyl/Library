namespace library
{
    partial class Form_client
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
            this.buttonSeeOpinions = new System.Windows.Forms.Button();
            this.buttonAddOpinion = new System.Windows.Forms.Button();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.listOfBrrowedBooks = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAvailableBooks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxOpinions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOpinion = new System.Windows.Forms.TextBox();
            this.listViewOpinions = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opinion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeeOpinions
            // 
            this.buttonSeeOpinions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeeOpinions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSeeOpinions.Location = new System.Drawing.Point(498, 502);
            this.buttonSeeOpinions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSeeOpinions.Name = "buttonSeeOpinions";
            this.buttonSeeOpinions.Size = new System.Drawing.Size(121, 27);
            this.buttonSeeOpinions.TabIndex = 24;
            this.buttonSeeOpinions.Text = "See opinions";
            this.buttonSeeOpinions.UseVisualStyleBackColor = true;
            this.buttonSeeOpinions.Click += new System.EventHandler(this.buttonSeeOpinions_Click);
            // 
            // buttonAddOpinion
            // 
            this.buttonAddOpinion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddOpinion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOpinion.Location = new System.Drawing.Point(498, 206);
            this.buttonAddOpinion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddOpinion.Name = "buttonAddOpinion";
            this.buttonAddOpinion.Size = new System.Drawing.Size(121, 27);
            this.buttonAddOpinion.TabIndex = 27;
            this.buttonAddOpinion.Text = "Add opinion";
            this.buttonAddOpinion.UseVisualStyleBackColor = true;
            this.buttonAddOpinion.Click += new System.EventHandler(this.buttonAddOpinion_Click);
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrowBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBorrowBook.Location = new System.Drawing.Point(623, 502);
            this.buttonBorrowBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(82, 27);
            this.buttonBorrowBook.TabIndex = 28;
            this.buttonBorrowBook.Text = "Borrow";
            this.buttonBorrowBook.UseVisualStyleBackColor = true;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturnBook.Location = new System.Drawing.Point(623, 206);
            this.buttonReturnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(82, 27);
            this.buttonReturnBook.TabIndex = 29;
            this.buttonReturnBook.Text = "Return ";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // listOfBrrowedBooks
            // 
            this.listOfBrrowedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Author,
            this.Title,
            this.Type,
            this.Date,
            this.Pages});
            this.listOfBrrowedBooks.HideSelection = false;
            this.listOfBrrowedBooks.Location = new System.Drawing.Point(7, 39);
            this.listOfBrrowedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOfBrrowedBooks.Name = "listOfBrrowedBooks";
            this.listOfBrrowedBooks.Size = new System.Drawing.Size(698, 121);
            this.listOfBrrowedBooks.TabIndex = 30;
            this.listOfBrrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listOfBrrowedBooks.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 164;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 250;
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
            // 
            // listViewAvailableBooks
            // 
            this.listViewAvailableBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAvailableBooks.HideSelection = false;
            this.listViewAvailableBooks.Location = new System.Drawing.Point(7, 275);
            this.listViewAvailableBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewAvailableBooks.Name = "listViewAvailableBooks";
            this.listViewAvailableBooks.Size = new System.Drawing.Size(698, 121);
            this.listViewAvailableBooks.TabIndex = 31;
            this.listViewAvailableBooks.UseCompatibleStateImageBehavior = false;
            this.listViewAvailableBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 264;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pages";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogOut.Image = global::library.Properties.Resources.logout;
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(593, 1);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(112, 34);
            this.buttonLogOut.TabIndex = 32;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(562, 174);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(143, 20);
            this.textBoxId.TabIndex = 33;
            // 
            // txtBoxOpinions
            // 
            this.txtBoxOpinions.Location = new System.Drawing.Point(562, 473);
            this.txtBoxOpinions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxOpinions.Name = "txtBoxOpinions";
            this.txtBoxOpinions.Size = new System.Drawing.Size(141, 20);
            this.txtBoxOpinions.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(533, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(533, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "Your books:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 36);
            this.label3.TabIndex = 38;
            this.label3.Text = "Books available:";
            // 
            // textBoxOpinion
            // 
            this.textBoxOpinion.Location = new System.Drawing.Point(7, 167);
            this.textBoxOpinion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOpinion.Multiline = true;
            this.textBoxOpinion.Name = "textBoxOpinion";
            this.textBoxOpinion.Size = new System.Drawing.Size(487, 66);
            this.textBoxOpinion.TabIndex = 39;
            // 
            // listViewOpinions
            // 
            this.listViewOpinions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Book,
            this.Opinion});
            this.listViewOpinions.HideSelection = false;
            this.listViewOpinions.Location = new System.Drawing.Point(7, 452);
            this.listViewOpinions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewOpinions.Name = "listViewOpinions";
            this.listViewOpinions.Size = new System.Drawing.Size(487, 90);
            this.listViewOpinions.TabIndex = 40;
            this.listViewOpinions.UseCompatibleStateImageBehavior = false;
            this.listViewOpinions.View = System.Windows.Forms.View.Details;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 50;
            // 
            // Book
            // 
            this.Book.Text = "Book";
            this.Book.Width = 182;
            // 
            // Opinion
            // 
            this.Opinion.Text = "Opinion";
            this.Opinion.Width = 250;
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Location = new System.Drawing.Point(102, 413);
            this.textBoxPhrase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(392, 20);
            this.textBoxPhrase.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Search:";
            // 
            // buttonFind
            // 
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFind.Location = new System.Drawing.Point(537, 409);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(168, 27);
            this.buttonFind.TabIndex = 43;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // Form_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 553);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.txtBoxOpinions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPhrase);
            this.Controls.Add(this.listViewOpinions);
            this.Controls.Add(this.textBoxOpinion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.listViewAvailableBooks);
            this.Controls.Add(this.listOfBrrowedBooks);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.buttonAddOpinion);
            this.Controls.Add(this.buttonSeeOpinions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_client";
            this.Text = "Clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSeeOpinions;
        private System.Windows.Forms.Button buttonAddOpinion;
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.ListView listOfBrrowedBooks;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Pages;
        private System.Windows.Forms.ListView listViewAvailableBooks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox txtBoxOpinions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOpinion;
        private System.Windows.Forms.ListView listViewOpinions;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.ColumnHeader Opinion;
        private System.Windows.Forms.TextBox textBoxPhrase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonFind;
    }
}