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
            this.RentedBooksButton = new System.Windows.Forms.Button();
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
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.DoBTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExpirationDate = new System.Windows.Forms.Label();
            this.UserCardExpiryDate = new System.Windows.Forms.Label();
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
            this.MainPanel.Location = new System.Drawing.Point(236, 22);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(496, 446);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RentedBooksButton
            // 
            this.RentedBooksButton.Location = new System.Drawing.Point(134, 281);
            this.RentedBooksButton.Name = "RentedBooksButton";
            this.RentedBooksButton.Size = new System.Drawing.Size(224, 31);
            this.RentedBooksButton.TabIndex = 5;
            this.RentedBooksButton.Text = "Rented books";
            this.RentedBooksButton.UseVisualStyleBackColor = true;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.BackColor = System.Drawing.Color.Transparent;
            this.Slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Slogan.Location = new System.Drawing.Point(25, 107);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(411, 17);
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
            this.UML.Location = new System.Drawing.Point(168, 38);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(156, 69);
            this.UML.TabIndex = 2;
            this.UML.Text = "ULM";
            this.UML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RentBookButton
            // 
            this.RentBookButton.Location = new System.Drawing.Point(134, 244);
            this.RentBookButton.Name = "RentBookButton";
            this.RentBookButton.Size = new System.Drawing.Size(224, 31);
            this.RentBookButton.TabIndex = 3;
            this.RentBookButton.Text = "Rent book";
            this.RentBookButton.UseVisualStyleBackColor = true;
            // 
            // BrowseBooksButton
            // 
            this.BrowseBooksButton.Location = new System.Drawing.Point(134, 207);
            this.BrowseBooksButton.Name = "BrowseBooksButton";
            this.BrowseBooksButton.Size = new System.Drawing.Size(224, 31);
            this.BrowseBooksButton.TabIndex = 2;
            this.BrowseBooksButton.Text = "Browse books ";
            this.BrowseBooksButton.UseVisualStyleBackColor = true;
            // 
            // ShowListButton
            // 
            this.ShowListButton.Location = new System.Drawing.Point(134, 171);
            this.ShowListButton.Name = "ShowListButton";
            this.ShowListButton.Size = new System.Drawing.Size(224, 31);
            this.ShowListButton.TabIndex = 1;
            this.ShowListButton.Text = "Show list of books";
            this.ShowListButton.UseVisualStyleBackColor = true;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileIcon.Image = global::WindowsFormsApplication1.Properties.Resources.businessman1;
            this.ProfileIcon.Location = new System.Drawing.Point(41, 20);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(86, 83);
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
            this.Username.Location = new System.Drawing.Point(17, 106);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(135, 29);
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
            this.UserPanel.Controls.Add(this.AgeTextBox);
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
            this.UserPanel.Location = new System.Drawing.Point(28, 22);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(174, 446);
            this.UserPanel.TabIndex = 0;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.Color.Transparent;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.Gray;
            this.UserID.Location = new System.Drawing.Point(21, 172);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(106, 26);
            this.UserID.TabIndex = 13;
            this.UserID.Text = "xID";
            this.UserID.Click += new System.EventHandler(this.label11_Click);
            // 
            // UserAge
            // 
            this.UserAge.BackColor = System.Drawing.Color.Transparent;
            this.UserAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAge.ForeColor = System.Drawing.Color.Gray;
            this.UserAge.Location = new System.Drawing.Point(17, 331);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(106, 26);
            this.UserAge.TabIndex = 12;
            this.UserAge.Text = "xAge";
            // 
            // UserLevel
            // 
            this.UserLevel.BackColor = System.Drawing.Color.Transparent;
            this.UserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.ForeColor = System.Drawing.Color.Gray;
            this.UserLevel.Location = new System.Drawing.Point(17, 276);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Size = new System.Drawing.Size(106, 26);
            this.UserLevel.TabIndex = 11;
            this.UserLevel.Text = "xLevel";
            // 
            // UserDoB
            // 
            this.UserDoB.BackColor = System.Drawing.Color.Transparent;
            this.UserDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDoB.ForeColor = System.Drawing.Color.Gray;
            this.UserDoB.Location = new System.Drawing.Point(17, 226);
            this.UserDoB.Name = "UserDoB";
            this.UserDoB.Size = new System.Drawing.Size(106, 26);
            this.UserDoB.TabIndex = 10;
            this.UserDoB.Text = "xDoB";
            this.UserDoB.Click += new System.EventHandler(this.label8_Click);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(17, 331);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(106, 26);
            this.AgeTextBox.TabIndex = 9;
            this.AgeTextBox.Visible = false;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(17, 276);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.Size = new System.Drawing.Size(106, 26);
            this.LevelTextBox.TabIndex = 8;
            this.LevelTextBox.Visible = false;
            this.LevelTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DoBTextBox
            // 
            this.DoBTextBox.Location = new System.Drawing.Point(17, 226);
            this.DoBTextBox.Name = "DoBTextBox";
            this.DoBTextBox.Size = new System.Drawing.Size(106, 26);
            this.DoBTextBox.TabIndex = 7;
            this.DoBTextBox.Visible = false;
            this.DoBTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(36, 386);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(101, 32);
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
            this.ID.Location = new System.Drawing.Point(13, 150);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(132, 22);
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
            this.DoB.Location = new System.Drawing.Point(13, 200);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(110, 22);
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
            this.Age.Location = new System.Drawing.Point(13, 306);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 22);
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
            this.Level.Location = new System.Drawing.Point(13, 254);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(53, 22);
            this.Level.TabIndex = 2;
            this.Level.Text = "Level";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(36, 386);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(101, 32);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSize = true;
            this.ExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExpirationDate.Location = new System.Drawing.Point(381, 419);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(69, 15);
            this.ExpirationDate.TabIndex = 6;
            this.ExpirationDate.Text = "Expiry Date";
            // 
            // UserCardExpiryDate
            // 
            this.UserCardExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.UserCardExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCardExpiryDate.ForeColor = System.Drawing.Color.Gray;
            this.UserCardExpiryDate.Location = new System.Drawing.Point(448, 419);
            this.UserCardExpiryDate.Name = "UserCardExpiryDate";
            this.UserCardExpiryDate.Size = new System.Drawing.Size(45, 18);
            this.UserCardExpiryDate.TabIndex = 14;
            this.UserCardExpiryDate.Text = "xDate";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 495);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.UserPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.TextBox DoBTextBox;
        private System.Windows.Forms.Label UserAge;
        private System.Windows.Forms.Label UserLevel;
        private System.Windows.Forms.Label UserDoB;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label UserCardExpiryDate;
        private System.Windows.Forms.Label ExpirationDate;
    }
}