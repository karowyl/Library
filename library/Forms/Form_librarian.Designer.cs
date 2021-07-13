namespace library
{
    partial class Form_librarian
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
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase});
            this.ssMain.Location = new System.Drawing.Point(0, 562);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssMain.Size = new System.Drawing.Size(763, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(105, 20);
            this.tsslVersion.Text = "Version: 1.0.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(154, 20);
            this.tsslDatabase.Text = "Data: database.library";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(763, 562);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 22);
            this.tcTabs.Location = new System.Drawing.Point(0, 80);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(763, 482);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tpTab_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tpTab_MouseDown);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.buttonLogOut);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnBooks);
            this.tpGeneral.Controls.Add(this.btnAccounts);
            this.tpGeneral.Location = new System.Drawing.Point(4, 32);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(755, 45);
            this.tpGeneral.TabIndex = 1;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.White;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogOut.Image = global::library.Properties.Resources.logout;
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(626, 3);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(126, 39);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(229, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 39);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(222, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 39);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.White;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBooks.Image = global::library.Properties.Resources.Contracts_32;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(124, 3);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(98, 39);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.White;
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccounts.Image = global::library.Properties.Resources.Emplyees_32;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(3, 3);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(121, 39);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(763, 81);
            this.tcMain.TabIndex = 0;
            // 
            // Form_librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 588);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form_librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.Button buttonLogOut;
    }
}