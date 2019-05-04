namespace WindowsFormsApplication1
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UserCardExpiryDate = new System.Windows.Forms.Label();
            this.RentedBooksButton = new System.Windows.Forms.Button();
            this.ExpirationDate = new System.Windows.Forms.Label();
            this.Slogan = new System.Windows.Forms.Label();
            this.UML = new System.Windows.Forms.Label();
            this.RentBookButton = new System.Windows.Forms.Button();
            this.BrowseBooksButton = new System.Windows.Forms.Button();
            this.ShowListButton = new System.Windows.Forms.Button();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UserID = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.Label();
            this.UserLevel = new System.Windows.Forms.Label();
            this.UserDoB = new System.Windows.Forms.Label();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.DoBTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.UserCardExpiryDate);
            this.MainPanel.Controls.Add(this.RentedBooksButton);
            this.MainPanel.Controls.Add(this.ExpirationDate);
            this.MainPanel.Controls.Add(this.Slogan);
            this.MainPanel.Controls.Add(this.UML);
            this.MainPanel.Controls.Add(this.RentBookButton);
            this.MainPanel.Controls.Add(this.BrowseBooksButton);
            this.MainPanel.Controls.Add(this.ShowListButton);
            this.MainPanel.Location = new System.Drawing.Point(210, 11);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(441, 349);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UserCardExpiryDate
            // 
            this.UserCardExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.UserCardExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCardExpiryDate.ForeColor = System.Drawing.Color.Gray;
            this.UserCardExpiryDate.Location = new System.Drawing.Point(356, 330);
            this.UserCardExpiryDate.Name = "UserCardExpiryDate";
            this.UserCardExpiryDate.Size = new System.Drawing.Size(82, 14);
            this.UserCardExpiryDate.TabIndex = 14;
            this.UserCardExpiryDate.Text = "xDate";
            // 
            // RentedBooksButton
            // 
            this.RentedBooksButton.Location = new System.Drawing.Point(119, 225);
            this.RentedBooksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentedBooksButton.Name = "RentedBooksButton";
            this.RentedBooksButton.Size = new System.Drawing.Size(199, 25);
            this.RentedBooksButton.TabIndex = 5;
            this.RentedBooksButton.Text = "My Rents";
            this.RentedBooksButton.UseVisualStyleBackColor = true;
            this.RentedBooksButton.Click += new System.EventHandler(this.RentedBooksButton_Click);
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSize = true;
            this.ExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExpirationDate.Location = new System.Drawing.Point(289, 330);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(61, 13);
            this.ExpirationDate.TabIndex = 6;
            this.ExpirationDate.Text = "Expiry Date";
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.BackColor = System.Drawing.Color.Transparent;
            this.Slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Slogan.Location = new System.Drawing.Point(22, 86);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(348, 15);
            this.Slogan.TabIndex = 4;
            this.Slogan.Text = "Use our services to enrich your research and save yourself time";
            this.Slogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UML
            // 
            this.UML.AutoSize = true;
            this.UML.BackColor = System.Drawing.Color.Transparent;
            this.UML.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UML.Location = new System.Drawing.Point(149, 30);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(131, 58);
            this.UML.TabIndex = 2;
            this.UML.Text = "ULM";
            this.UML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RentBookButton
            // 
            this.RentBookButton.Location = new System.Drawing.Point(119, 195);
            this.RentBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentBookButton.Name = "RentBookButton";
            this.RentBookButton.Size = new System.Drawing.Size(199, 25);
            this.RentBookButton.TabIndex = 3;
            this.RentBookButton.Text = "Rent book";
            this.RentBookButton.UseVisualStyleBackColor = true;
            this.RentBookButton.Click += new System.EventHandler(this.RentBookButton_Click);
            // 
            // BrowseBooksButton
            // 
            this.BrowseBooksButton.Location = new System.Drawing.Point(119, 166);
            this.BrowseBooksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseBooksButton.Name = "BrowseBooksButton";
            this.BrowseBooksButton.Size = new System.Drawing.Size(199, 25);
            this.BrowseBooksButton.TabIndex = 2;
            this.BrowseBooksButton.Text = "Browse books ";
            this.BrowseBooksButton.UseVisualStyleBackColor = true;
            this.BrowseBooksButton.Click += new System.EventHandler(this.BrowseBooksButton_Click);
            // 
            // ShowListButton
            // 
            this.ShowListButton.Location = new System.Drawing.Point(119, 137);
            this.ShowListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowListButton.Name = "ShowListButton";
            this.ShowListButton.Size = new System.Drawing.Size(199, 25);
            this.ShowListButton.TabIndex = 1;
            this.ShowListButton.Text = "Show list of books";
            this.ShowListButton.UseVisualStyleBackColor = true;
            this.ShowListButton.Click += new System.EventHandler(this.ShowListButton_Click);
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileIcon.Image = global::WindowsFormsApplication1.Properties.Resources.businessman1;
            this.ProfileIcon.Location = new System.Drawing.Point(36, 16);
            this.ProfileIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(76, 66);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileIcon.TabIndex = 0;
            this.ProfileIcon.TabStop = false;
            this.ProfileIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Username.Location = new System.Drawing.Point(15, 85);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(112, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "xUsername";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.UserID);
            this.UserPanel.Controls.Add(this.UserAge);
            this.UserPanel.Controls.Add(this.UserLevel);
            this.UserPanel.Controls.Add(this.UserDoB);
            this.UserPanel.Controls.Add(this.LevelTextBox);
            this.UserPanel.Controls.Add(this.DoBTextBox);
            this.UserPanel.Controls.Add(this.EditButton);
            this.UserPanel.Controls.Add(this.ID);
            this.UserPanel.Controls.Add(this.DoB);
            this.UserPanel.Controls.Add(this.Age);
            this.UserPanel.Controls.Add(this.Level);
            this.UserPanel.Controls.Add(this.Username);
            this.UserPanel.Controls.Add(this.ProfileIcon);
            this.UserPanel.Controls.Add(this.UpdateButton);
            this.UserPanel.Location = new System.Drawing.Point(25, 11);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(155, 349);
            this.UserPanel.TabIndex = 0;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.Color.Transparent;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.Gray;
            this.UserID.Location = new System.Drawing.Point(19, 138);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(94, 21);
            this.UserID.TabIndex = 13;
            this.UserID.Text = "xID";
            this.UserID.Click += new System.EventHandler(this.label11_Click);
            // 
            // UserAge
            // 
            this.UserAge.BackColor = System.Drawing.Color.Transparent;
            this.UserAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAge.ForeColor = System.Drawing.Color.Gray;
            this.UserAge.Location = new System.Drawing.Point(18, 263);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(94, 21);
            this.UserAge.TabIndex = 12;
            this.UserAge.Text = "xAge";
            // 
            // UserLevel
            // 
            this.UserLevel.BackColor = System.Drawing.Color.Transparent;
            this.UserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.ForeColor = System.Drawing.Color.Gray;
            this.UserLevel.Location = new System.Drawing.Point(15, 221);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Size = new System.Drawing.Size(94, 21);
            this.UserLevel.TabIndex = 11;
            this.UserLevel.Text = "xLevel";
            // 
            // UserDoB
            // 
            this.UserDoB.BackColor = System.Drawing.Color.Transparent;
            this.UserDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDoB.ForeColor = System.Drawing.Color.Gray;
            this.UserDoB.Location = new System.Drawing.Point(15, 181);
            this.UserDoB.Name = "UserDoB";
            this.UserDoB.Size = new System.Drawing.Size(94, 21);
            this.UserDoB.TabIndex = 10;
            this.UserDoB.Text = "xDoB";
            this.UserDoB.Click += new System.EventHandler(this.label8_Click);
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(15, 221);
            this.LevelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.Size = new System.Drawing.Size(95, 22);
            this.LevelTextBox.TabIndex = 8;
            this.LevelTextBox.Visible = false;
            this.LevelTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DoBTextBox
            // 
            this.DoBTextBox.Location = new System.Drawing.Point(15, 181);
            this.DoBTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoBTextBox.Name = "DoBTextBox";
            this.DoBTextBox.Size = new System.Drawing.Size(95, 22);
            this.DoBTextBox.TabIndex = 7;
            this.DoBTextBox.Visible = false;
            this.DoBTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(32, 309);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(90, 26);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ID.Location = new System.Drawing.Point(12, 120);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(107, 18);
            this.ID.TabIndex = 5;
            this.ID.Text = "Identity number";
            this.ID.Click += new System.EventHandler(this.label7_Click);
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.BackColor = System.Drawing.Color.Transparent;
            this.DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DoB.Location = new System.Drawing.Point(12, 160);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(90, 18);
            this.DoB.TabIndex = 4;
            this.DoB.Text = "Date of Birth";
            this.DoB.Click += new System.EventHandler(this.label6_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Age.Location = new System.Drawing.Point(12, 245);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 18);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.label5_Click);
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Level.Location = new System.Drawing.Point(12, 203);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(42, 18);
            this.Level.TabIndex = 2;
            this.Level.Text = "Level";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(32, 309);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 26);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.UserPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_FormClosing);
            this.Load += new System.EventHandler(this.Student_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox ProfileIcon;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button BrowseBooksButton;
        private System.Windows.Forms.Button ShowListButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button RentBookButton;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button RentedBooksButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.TextBox DoBTextBox;
        private System.Windows.Forms.Label UserAge;
        private System.Windows.Forms.Label UserLevel;
        private System.Windows.Forms.Label UserDoB;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label UserCardExpiryDate;
        private System.Windows.Forms.Label ExpirationDate;
        private System.Windows.Forms.Button button1;
    }
}