namespace WindowsFormsApplication1
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UML = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.ListofBooks = new System.Windows.Forms.Button();
            this.ShowListButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.UML);
            this.MainPanel.Controls.Add(this.AddBook);
            this.MainPanel.Controls.Add(this.UpdateBook);
            this.MainPanel.Controls.Add(this.ListofBooks);
            this.MainPanel.Controls.Add(this.ShowListButton);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(196, 12);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(287, 371);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // UML
            // 
            this.UML.AutoSize = true;
            this.UML.BackColor = System.Drawing.Color.Transparent;
            this.UML.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UML.Location = new System.Drawing.Point(72, 42);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(131, 58);
            this.UML.TabIndex = 9;
            this.UML.Text = "ULM";
            this.UML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddBook
            // 
            this.AddBook.ForeColor = System.Drawing.Color.Black;
            this.AddBook.Location = new System.Drawing.Point(39, 155);
            this.AddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(208, 28);
            this.AddBook.TabIndex = 8;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // UpdateBook
            // 
            this.UpdateBook.ForeColor = System.Drawing.Color.Black;
            this.UpdateBook.Location = new System.Drawing.Point(39, 218);
            this.UpdateBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(208, 28);
            this.UpdateBook.TabIndex = 7;
            this.UpdateBook.Text = "Update Book";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // ListofBooks
            // 
            this.ListofBooks.ForeColor = System.Drawing.Color.Black;
            this.ListofBooks.Location = new System.Drawing.Point(39, 122);
            this.ListofBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListofBooks.Name = "ListofBooks";
            this.ListofBooks.Size = new System.Drawing.Size(208, 28);
            this.ListofBooks.TabIndex = 6;
            this.ListofBooks.Text = "Show List";
            this.ListofBooks.UseVisualStyleBackColor = true;
            this.ListofBooks.Click += new System.EventHandler(this.ListofBooks_Click);
            // 
            // ShowListButton
            // 
            this.ShowListButton.ForeColor = System.Drawing.Color.Black;
            this.ShowListButton.Location = new System.Drawing.Point(39, 188);
            this.ShowListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowListButton.Name = "ShowListButton";
            this.ShowListButton.Size = new System.Drawing.Size(208, 26);
            this.ShowListButton.TabIndex = 5;
            this.ShowListButton.Text = "Delete Book";
            this.ShowListButton.UseVisualStyleBackColor = true;
            this.ShowListButton.Click += new System.EventHandler(this.ShowListButton_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button ListofBooks;
        private System.Windows.Forms.Button ShowListButton;
        private System.Windows.Forms.Button button2;
    }
}