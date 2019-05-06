namespace WindowsFormsApplication1
{
    partial class Add_Book
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.PublicationDate = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.Error);
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Controls.Add(this.ISBNTextBox);
            this.MainPanel.Controls.Add(this.ISBN);
            this.MainPanel.Controls.Add(this.DateTimePicker);
            this.MainPanel.Controls.Add(this.PublisherTextBox);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.IDTextBox);
            this.MainPanel.Controls.Add(this.AddBookButton);
            this.MainPanel.Controls.Add(this.PublicationDate);
            this.MainPanel.Controls.Add(this.Publisher);
            this.MainPanel.Controls.Add(this.BookName);
            this.MainPanel.Controls.Add(this.AuthorID);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(12, 34);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(741, 448);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Location = new System.Drawing.Point(30, 239);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(670, 196);
            this.DataGridView.TabIndex = 21;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(294, 18);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(274, 26);
            this.ISBNTextBox.TabIndex = 20;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.BackColor = System.Drawing.Color.Transparent;
            this.ISBN.Location = new System.Drawing.Point(145, 18);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(47, 20);
            this.ISBN.TabIndex = 19;
            this.ISBN.Text = "ISBN";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(294, 165);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.DateTimePicker.TabIndex = 18;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(294, 126);
            this.PublisherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(274, 26);
            this.PublisherTextBox.TabIndex = 17;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(294, 89);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(274, 26);
            this.NameTextBox.TabIndex = 16;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(294, 53);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(274, 26);
            this.IDTextBox.TabIndex = 15;
            // 
            // AddBookButton
            // 
            this.AddBookButton.ForeColor = System.Drawing.Color.Black;
            this.AddBookButton.Location = new System.Drawing.Point(446, 197);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(122, 31);
            this.AddBookButton.TabIndex = 14;
            this.AddBookButton.Text = "Add";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // PublicationDate
            // 
            this.PublicationDate.AutoSize = true;
            this.PublicationDate.BackColor = System.Drawing.Color.Transparent;
            this.PublicationDate.Location = new System.Drawing.Point(145, 165);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(125, 20);
            this.PublicationDate.TabIndex = 13;
            this.PublicationDate.Text = "Publication Date";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Publisher.Location = new System.Drawing.Point(145, 126);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(74, 20);
            this.Publisher.TabIndex = 12;
            this.Publisher.Text = "Publisher";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.BackColor = System.Drawing.Color.Transparent;
            this.BookName.Location = new System.Drawing.Point(145, 89);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(90, 20);
            this.BookName.TabIndex = 11;
            this.BookName.Text = "Book name";
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.BackColor = System.Drawing.Color.Transparent;
            this.AuthorID.Location = new System.Drawing.Point(145, 53);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(78, 20);
            this.AuthorID.TabIndex = 10;
            this.AuthorID.Text = "Author ID";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(58, 20);
            this.Back.TabIndex = 22;
            this.Back.Text = "< Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(249, 202);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(44, 20);
            this.Error.TabIndex = 27;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Book_FormClosing);
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label PublicationDate;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label Error;
    }
}