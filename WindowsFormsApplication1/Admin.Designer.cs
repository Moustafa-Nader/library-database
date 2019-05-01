namespace WindowsFormsApplication1
{
    partial class Admin
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
            this.AddAdmin = new System.Windows.Forms.Button();
            this.UML = new System.Windows.Forms.Label();
            this.ManageAuthors = new System.Windows.Forms.Button();
            this.ManageBooks = new System.Windows.Forms.Button();
            this.ManageStudents = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UserID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AddAdmin);
            this.MainPanel.Controls.Add(this.UML);
            this.MainPanel.Controls.Add(this.ManageAuthors);
            this.MainPanel.Controls.Add(this.ManageBooks);
            this.MainPanel.Controls.Add(this.ManageStudents);
            this.MainPanel.Location = new System.Drawing.Point(238, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(496, 446);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // AddAdmin
            // 
            this.AddAdmin.Location = new System.Drawing.Point(137, 258);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(224, 31);
            this.AddAdmin.TabIndex = 5;
            this.AddAdmin.Text = "Add Admin";
            this.AddAdmin.UseVisualStyleBackColor = true;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
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
            // ManageAuthors
            // 
            this.ManageAuthors.Location = new System.Drawing.Point(137, 221);
            this.ManageAuthors.Name = "ManageAuthors";
            this.ManageAuthors.Size = new System.Drawing.Size(224, 31);
            this.ManageAuthors.TabIndex = 3;
            this.ManageAuthors.Text = "Manage Authors";
            this.ManageAuthors.UseVisualStyleBackColor = true;
            this.ManageAuthors.Click += new System.EventHandler(this.ManageAuthors_Click);
            // 
            // ManageBooks
            // 
            this.ManageBooks.Location = new System.Drawing.Point(137, 184);
            this.ManageBooks.Name = "ManageBooks";
            this.ManageBooks.Size = new System.Drawing.Size(224, 31);
            this.ManageBooks.TabIndex = 2;
            this.ManageBooks.Text = "Manage Books";
            this.ManageBooks.UseVisualStyleBackColor = true;
            this.ManageBooks.Click += new System.EventHandler(this.ManageBooks_Click);
            // 
            // ManageStudents
            // 
            this.ManageStudents.Location = new System.Drawing.Point(137, 148);
            this.ManageStudents.Name = "ManageStudents";
            this.ManageStudents.Size = new System.Drawing.Size(224, 31);
            this.ManageStudents.TabIndex = 1;
            this.ManageStudents.Text = "Manage Students";
            this.ManageStudents.UseVisualStyleBackColor = true;
            this.ManageStudents.Click += new System.EventHandler(this.ManageStudents_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.UserID);
            this.UserPanel.Controls.Add(this.ID);
            this.UserPanel.Controls.Add(this.Username);
            this.UserPanel.Controls.Add(this.ProfileIcon);
            this.UserPanel.Location = new System.Drawing.Point(30, 24);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(174, 446);
            this.UserPanel.TabIndex = 2;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserPanel_Paint);
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
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.UserPanel);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.Text = "Admin";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AddAdmin;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button ManageAuthors;
        private System.Windows.Forms.Button ManageBooks;
        private System.Windows.Forms.Button ManageStudents;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox ProfileIcon;

    }
}