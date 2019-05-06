namespace WindowsFormsApplication1
{
    partial class Add_Admin
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AdminID_TextBox = new System.Windows.Forms.TextBox();
            this.ADMIN_ID = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.Error);
            this.MainPanel.Controls.Add(this.EmailtextBox);
            this.MainPanel.Controls.Add(this.Email);
            this.MainPanel.Controls.Add(this.PasswordtextBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Controls.Add(this.AdminID_TextBox);
            this.MainPanel.Controls.Add(this.ADMIN_ID);
            this.MainPanel.Controls.Add(this.LastName_TextBox);
            this.MainPanel.Controls.Add(this.FirstName_TextBox);
            this.MainPanel.Controls.Add(this.Username_TextBox);
            this.MainPanel.Controls.Add(this.AddBookButton);
            this.MainPanel.Controls.Add(this.LastName);
            this.MainPanel.Controls.Add(this.FirstName);
            this.MainPanel.Controls.Add(this.Username);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(12, 38);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(741, 444);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(355, 177);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(44, 20);
            this.Error.TabIndex = 26;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(523, 28);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(180, 26);
            this.EmailtextBox.TabIndex = 25;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Location = new System.Drawing.Point(374, 28);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 24;
            this.Email.Text = "Email";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(523, 62);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(180, 26);
            this.PasswordtextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(374, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
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
            this.DataGridView.Location = new System.Drawing.Point(30, 222);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(670, 210);
            this.DataGridView.TabIndex = 21;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AdminID_TextBox
            // 
            this.AdminID_TextBox.Location = new System.Drawing.Point(179, 25);
            this.AdminID_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminID_TextBox.Name = "AdminID_TextBox";
            this.AdminID_TextBox.Size = new System.Drawing.Size(180, 26);
            this.AdminID_TextBox.TabIndex = 20;
            // 
            // ADMIN_ID
            // 
            this.ADMIN_ID.AutoSize = true;
            this.ADMIN_ID.BackColor = System.Drawing.Color.Transparent;
            this.ADMIN_ID.Location = new System.Drawing.Point(30, 25);
            this.ADMIN_ID.Name = "ADMIN_ID";
            this.ADMIN_ID.Size = new System.Drawing.Size(75, 20);
            this.ADMIN_ID.TabIndex = 19;
            this.ADMIN_ID.Text = "Admin ID";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(179, 132);
            this.LastName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(180, 26);
            this.LastName_TextBox.TabIndex = 17;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(179, 95);
            this.FirstName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(180, 26);
            this.FirstName_TextBox.TabIndex = 16;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(179, 59);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(180, 26);
            this.Username_TextBox.TabIndex = 15;
            // 
            // AddBookButton
            // 
            this.AddBookButton.ForeColor = System.Drawing.Color.Black;
            this.AddBookButton.Location = new System.Drawing.Point(578, 172);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(122, 31);
            this.AddBookButton.TabIndex = 14;
            this.AddBookButton.Text = "Add";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Location = new System.Drawing.Point(30, 132);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 12;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Location = new System.Drawing.Point(30, 95);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(86, 20);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "First Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Location = new System.Drawing.Point(30, 59);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Back.Location = new System.Drawing.Point(8, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(58, 20);
            this.Back.TabIndex = 19;
            this.Back.Text = "< Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Admin";
            this.Text = "Add_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Admin_FormClosing);
            this.Load += new System.EventHandler(this.Add_Admin_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox AdminID_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label ADMIN_ID;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error;
    }
}