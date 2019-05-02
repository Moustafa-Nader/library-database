namespace WindowsFormsApplication1
{
    partial class Update_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Book));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.ShowList = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.UpdateBookButton = new System.Windows.Forms.Button();
            this.PublicationDate = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.ISBNTextBox);
            this.MainPanel.Controls.Add(this.ISBN);
            this.MainPanel.Controls.Add(this.ShowList);
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Controls.Add(this.DateTimePicker);
            this.MainPanel.Controls.Add(this.PublisherTextBox);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.IDTextBox);
            this.MainPanel.Controls.Add(this.UpdateBookButton);
            this.MainPanel.Controls.Add(this.PublicationDate);
            this.MainPanel.Controls.Add(this.Publisher);
            this.MainPanel.Controls.Add(this.BookName);
            this.MainPanel.Controls.Add(this.AuthorID);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(11, 27);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(659, 359);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(262, 14);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(244, 22);
            this.ISBNTextBox.TabIndex = 24;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.BackColor = System.Drawing.Color.Transparent;
            this.ISBN.Location = new System.Drawing.Point(128, 14);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(39, 17);
            this.ISBN.TabIndex = 23;
            this.ISBN.Text = "ISBN";
            // 
            // ShowList
            // 
            this.ShowList.ForeColor = System.Drawing.Color.Black;
            this.ShowList.Location = new System.Drawing.Point(285, 165);
            this.ShowList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(108, 25);
            this.ShowList.TabIndex = 22;
            this.ShowList.Text = "Show List";
            this.ShowList.UseVisualStyleBackColor = true;
            this.ShowList.Click += new System.EventHandler(this.ShowList_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Location = new System.Drawing.Point(25, 200);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(601, 154);
            this.DataGridView.TabIndex = 21;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(262, 135);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.DateTimePicker.TabIndex = 18;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(262, 104);
            this.PublisherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(244, 22);
            this.PublisherTextBox.TabIndex = 17;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(262, 74);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(244, 22);
            this.NameTextBox.TabIndex = 16;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(262, 46);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(244, 22);
            this.IDTextBox.TabIndex = 15;
            // 
            // UpdateBookButton
            // 
            this.UpdateBookButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateBookButton.Location = new System.Drawing.Point(399, 165);
            this.UpdateBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBookButton.Name = "UpdateBookButton";
            this.UpdateBookButton.Size = new System.Drawing.Size(108, 25);
            this.UpdateBookButton.TabIndex = 14;
            this.UpdateBookButton.Text = "Update";
            this.UpdateBookButton.UseVisualStyleBackColor = true;
            this.UpdateBookButton.Click += new System.EventHandler(this.UpdateBookButton_Click);
            // 
            // PublicationDate
            // 
            this.PublicationDate.AutoSize = true;
            this.PublicationDate.BackColor = System.Drawing.Color.Transparent;
            this.PublicationDate.Location = new System.Drawing.Point(128, 135);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(111, 17);
            this.PublicationDate.TabIndex = 13;
            this.PublicationDate.Text = "Publication Date";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Publisher.Location = new System.Drawing.Point(128, 104);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(67, 17);
            this.Publisher.TabIndex = 12;
            this.Publisher.Text = "Publisher";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.BackColor = System.Drawing.Color.Transparent;
            this.BookName.Location = new System.Drawing.Point(128, 74);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(79, 17);
            this.BookName.TabIndex = 11;
            this.BookName.Text = "Book name";
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.BackColor = System.Drawing.Color.Transparent;
            this.AuthorID.Location = new System.Drawing.Point(128, 46);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(67, 17);
            this.AuthorID.TabIndex = 10;
            this.AuthorID.Text = "Author ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Update_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Book_FormClosing);
            this.Load += new System.EventHandler(this.Update_Book_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button UpdateBookButton;
        private System.Windows.Forms.Label PublicationDate;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.Button ShowList;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Button button1;
    }
}