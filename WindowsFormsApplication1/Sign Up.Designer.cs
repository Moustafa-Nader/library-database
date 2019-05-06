namespace WindowsFormsApplication1
{
    partial class Sign_Up
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Last_NameTextbox = new System.Windows.Forms.TextBox();
            this.First_NameTextbox = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DoBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DoB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox2 = new System.Windows.Forms.TextBox();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.Last_NameTextbox);
            this.MainPanel.Controls.Add(this.First_NameTextbox);
            this.MainPanel.Controls.Add(this.Last_Name);
            this.MainPanel.Controls.Add(this.First_Name);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DoBTimePicker);
            this.MainPanel.Controls.Add(this.DoB);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.LevelComboBox);
            this.MainPanel.Controls.Add(this.EmailTextbox);
            this.MainPanel.Controls.Add(this.Passwordtextbox);
            this.MainPanel.Controls.Add(this.PasswordTextbox2);
            this.MainPanel.Controls.Add(this.IDTextbox);
            this.MainPanel.Controls.Add(this.UsernameTextbox);
            this.MainPanel.Controls.Add(this.Level);
            this.MainPanel.Controls.Add(this.ID);
            this.MainPanel.Controls.Add(this.ConfirmPassword);
            this.MainPanel.Controls.Add(this.Password);
            this.MainPanel.Controls.Add(this.Email);
            this.MainPanel.Controls.Add(this.Username);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(268, 38);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(365, 561);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Last_NameTextbox
            // 
            this.Last_NameTextbox.Location = new System.Drawing.Point(206, 157);
            this.Last_NameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Last_NameTextbox.Multiline = true;
            this.Last_NameTextbox.Name = "Last_NameTextbox";
            this.Last_NameTextbox.Size = new System.Drawing.Size(130, 23);
            this.Last_NameTextbox.TabIndex = 25;
            // 
            // First_NameTextbox
            // 
            this.First_NameTextbox.Location = new System.Drawing.Point(206, 119);
            this.First_NameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.First_NameTextbox.Multiline = true;
            this.First_NameTextbox.Name = "First_NameTextbox";
            this.First_NameTextbox.Size = new System.Drawing.Size(130, 23);
            this.First_NameTextbox.TabIndex = 24;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.BackColor = System.Drawing.Color.Transparent;
            this.Last_Name.Location = new System.Drawing.Point(38, 157);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(86, 20);
            this.Last_Name.TabIndex = 23;
            this.Last_Name.Text = "Last Name";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.BackColor = System.Drawing.Color.Transparent;
            this.First_Name.Location = new System.Drawing.Point(39, 119);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(86, 20);
            this.First_Name.TabIndex = 22;
            this.First_Name.Text = "First Name";
            this.First_Name.Click += new System.EventHandler(this.First_Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DoBTimePicker
            // 
            this.DoBTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBTimePicker.Location = new System.Drawing.Point(206, 437);
            this.DoBTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoBTimePicker.MaxDate = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            this.DoBTimePicker.Name = "DoBTimePicker";
            this.DoBTimePicker.Size = new System.Drawing.Size(130, 23);
            this.DoBTimePicker.TabIndex = 20;
            this.DoBTimePicker.ValueChanged += new System.EventHandler(this.DoBTimePicker_ValueChanged);
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.BackColor = System.Drawing.Color.Transparent;
            this.DoB.Location = new System.Drawing.Point(39, 437);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(99, 20);
            this.DoB.TabIndex = 19;
            this.DoB.Text = "Date of Birth";
            this.DoB.Click += new System.EventHandler(this.DoB_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(102, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five"});
            this.LevelComboBox.Location = new System.Drawing.Point(206, 401);
            this.LevelComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(130, 23);
            this.LevelComboBox.TabIndex = 15;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(206, 238);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextbox.Multiline = true;
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(130, 23);
            this.EmailTextbox.TabIndex = 11;
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Location = new System.Drawing.Point(206, 281);
            this.Passwordtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passwordtextbox.Multiline = true;
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(130, 23);
            this.Passwordtextbox.TabIndex = 10;
            // 
            // PasswordTextbox2
            // 
            this.PasswordTextbox2.Location = new System.Drawing.Point(206, 325);
            this.PasswordTextbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextbox2.Multiline = true;
            this.PasswordTextbox2.Name = "PasswordTextbox2";
            this.PasswordTextbox2.Size = new System.Drawing.Size(130, 23);
            this.PasswordTextbox2.TabIndex = 9;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(206, 363);
            this.IDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextbox.Multiline = true;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(130, 23);
            this.IDTextbox.TabIndex = 8;
            this.IDTextbox.TextChanged += new System.EventHandler(this.IDTextbox_TextChanged);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(206, 197);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextbox.Multiline = true;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(130, 23);
            this.UsernameTextbox.TabIndex = 7;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.Location = new System.Drawing.Point(39, 401);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(46, 20);
            this.Level.TabIndex = 6;
            this.Level.Text = "Level";
            this.Level.Click += new System.EventHandler(this.Level_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Location = new System.Drawing.Point(38, 363);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(87, 20);
            this.ID.TabIndex = 4;
            this.ID.Text = "Student ID";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPassword.Location = new System.Drawing.Point(38, 325);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(147, 20);
            this.ConfirmPassword.TabIndex = 3;
            this.ConfirmPassword.Text = "Re-Enter Password";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(38, 281);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Location = new System.Drawing.Point(38, 238);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Location = new System.Drawing.Point(38, 197);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 69);
            this.label1.TabIndex = 18;
            this.label1.Text = "ULM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.Back.TabIndex = 19;
            this.Back.Text = "< Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 619);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sign_Up_FormClosing);
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.TextBox PasswordTextbox2;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DoBTimePicker;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.TextBox Last_NameTextbox;
        private System.Windows.Forms.TextBox First_NameTextbox;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back;
    }
}