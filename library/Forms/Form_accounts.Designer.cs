namespace library
{
    partial class Form_accounts
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pAccounts = new System.Windows.Forms.Panel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tlpAccounts = new System.Windows.Forms.TableLayoutPanel();
            this.listOfUsers = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Permission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNr = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPermission = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.pAccounts.SuspendLayout();
            this.tlpAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(623, 449);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // pAccounts
            // 
            this.pAccounts.Controls.Add(this.btnSendEmail);
            this.pAccounts.Controls.Add(this.btnRefresh);
            this.pAccounts.Controls.Add(this.btnRemove);
            this.pAccounts.Controls.Add(this.btnFind);
            this.pAccounts.Controls.Add(this.btnModify);
            this.pAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAccounts.Location = new System.Drawing.Point(3, 2);
            this.pAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAccounts.Name = "pAccounts";
            this.pAccounts.Size = new System.Drawing.Size(990, 36);
            this.pAccounts.TabIndex = 0;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.White;
            this.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendEmail.Image = global::library.Properties.Resources.email_24;
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendEmail.Location = new System.Drawing.Point(815, 0);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(175, 36);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Send email ";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::library.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(401, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::library.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(264, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFind.Image = global::library.Properties.Resources.finder;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(139, 0);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFind.Size = new System.Drawing.Size(125, 36);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::library.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(0, 0);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(139, 36);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = " Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tlpAccounts
            // 
            this.tlpAccounts.ColumnCount = 1;
            this.tlpAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccounts.Controls.Add(this.pAccounts, 0, 0);
            this.tlpAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAccounts.Location = new System.Drawing.Point(0, 0);
            this.tlpAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAccounts.Name = "tlpAccounts";
            this.tlpAccounts.RowCount = 1;
            this.tlpAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpAccounts.Size = new System.Drawing.Size(996, 41);
            this.tlpAccounts.TabIndex = 0;
            // 
            // listOfUsers
            // 
            this.listOfUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Login,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.PhoneNumber,
            this.Permission});
            this.listOfUsers.HideSelection = false;
            this.listOfUsers.Location = new System.Drawing.Point(0, 44);
            this.listOfUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfUsers.Name = "listOfUsers";
            this.listOfUsers.Size = new System.Drawing.Size(996, 358);
            this.listOfUsers.TabIndex = 2;
            this.listOfUsers.UseCompatibleStateImageBehavior = false;
            this.listOfUsers.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Login
            // 
            this.Login.Text = "Login";
            this.Login.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 110;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 104;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DisplayIndex = 4;
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 100;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DisplayIndex = 5;
            this.EmailAddress.Text = "EmailAddress";
            this.EmailAddress.Width = 200;
            // 
            // Permission
            // 
            this.Permission.Text = "Permission";
            this.Permission.Width = 100;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(147, 512);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(157, 22);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFirstName_KeyDown);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(147, 560);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(157, 22);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLastName_KeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(497, 516);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(157, 22);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogin_KeyDown);
            // 
            // textBoxPhoneNr
            // 
            this.textBoxPhoneNr.Location = new System.Drawing.Point(497, 560);
            this.textBoxPhoneNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhoneNr.Name = "textBoxPhoneNr";
            this.textBoxPhoneNr.Size = new System.Drawing.Size(157, 22);
            this.textBoxPhoneNr.TabIndex = 7;
            this.textBoxPhoneNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhoneNr_KeyDown);
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(839, 518);
            this.textBoxEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(157, 22);
            this.textBoxEmailAddress.TabIndex = 8;
            this.textBoxEmailAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmailAddress_KeyDown);
            // 
            // textBoxPermission
            // 
            this.textBoxPermission.Location = new System.Drawing.Point(839, 560);
            this.textBoxPermission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermission.Name = "textBoxPermission";
            this.textBoxPermission.Size = new System.Drawing.Size(157, 22);
            this.textBoxPermission.TabIndex = 9;
            this.textBoxPermission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPermission_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(369, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(369, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone nr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(679, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(679, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Permission:";
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Location = new System.Drawing.Point(147, 469);
            this.textBoxIdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(157, 22);
            this.textBoxIdUser.TabIndex = 23;
            this.textBoxIdUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIdUser_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Search:";
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Location = new System.Drawing.Point(147, 430);
            this.textBoxPhrase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(849, 22);
            this.textBoxPhrase.TabIndex = 35;
            // 
            // Form_accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 587);
            this.Controls.Add(this.textBoxPhrase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIdUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPermission);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxPhoneNr);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.listOfUsers);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tlpAccounts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_accounts";
            this.Text = "Accounts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_accounts_FormClosed);
            this.pAccounts.ResumeLayout(false);
            this.tlpAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel pAccounts;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TableLayoutPanel tlpAccounts;
        private System.Windows.Forms.ListView listOfUsers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader Permission;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPhoneNr;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPermission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhrase;
    }
}