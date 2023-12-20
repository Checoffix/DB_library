namespace WindowsFormsApp4
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TakeBook = new System.Windows.Forms.Label();
            this.GiveBook = new System.Windows.Forms.Label();
            this.WorkWithReaders = new System.Windows.Forms.Label();
            this.WorkWithBooks = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TakeBook);
            this.panel1.Controls.Add(this.GiveBook);
            this.panel1.Controls.Add(this.WorkWithReaders);
            this.panel1.Controls.Add(this.WorkWithBooks);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 399);
            this.panel1.TabIndex = 1;
            // 
            // TakeBook
            // 
            this.TakeBook.AutoSize = true;
            this.TakeBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TakeBook.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBook.Location = new System.Drawing.Point(17, 143);
            this.TakeBook.Name = "TakeBook";
            this.TakeBook.Size = new System.Drawing.Size(148, 19);
            this.TakeBook.TabIndex = 4;
            this.TakeBook.Text = "Приём литературы";
            this.TakeBook.Click += new System.EventHandler(this.TakeBook_Click);
            // 
            // GiveBook
            // 
            this.GiveBook.AutoSize = true;
            this.GiveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GiveBook.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveBook.Location = new System.Drawing.Point(17, 101);
            this.GiveBook.Name = "GiveBook";
            this.GiveBook.Size = new System.Drawing.Size(155, 19);
            this.GiveBook.TabIndex = 3;
            this.GiveBook.Text = "Выдача литературы";
            this.GiveBook.Click += new System.EventHandler(this.GiveBook_Click);
            // 
            // WorkWithReaders
            // 
            this.WorkWithReaders.AutoSize = true;
            this.WorkWithReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkWithReaders.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkWithReaders.Location = new System.Drawing.Point(17, 59);
            this.WorkWithReaders.Name = "WorkWithReaders";
            this.WorkWithReaders.Size = new System.Drawing.Size(163, 19);
            this.WorkWithReaders.TabIndex = 2;
            this.WorkWithReaders.Text = "Работа с читателями";
            this.WorkWithReaders.Click += new System.EventHandler(this.WorkWithReaders_Click);
            // 
            // WorkWithBooks
            // 
            this.WorkWithBooks.AutoSize = true;
            this.WorkWithBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkWithBooks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkWithBooks.Location = new System.Drawing.Point(17, 18);
            this.WorkWithBooks.Name = "WorkWithBooks";
            this.WorkWithBooks.Size = new System.Drawing.Size(249, 19);
            this.WorkWithBooks.TabIndex = 1;
            this.WorkWithBooks.Text = "Работа с библиотечным фондом";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(71)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "NSTU Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.Label TakeBook;
        private System.Windows.Forms.Label GiveBook;
        private System.Windows.Forms.Label WorkWithReaders;
        private System.Windows.Forms.Label WorkWithBooks;
    }
}