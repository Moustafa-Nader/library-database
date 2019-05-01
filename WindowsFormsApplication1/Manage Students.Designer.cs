namespace WindowsFormsApplication1
{
    partial class Manage_Students
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
            this.UML = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.UpdateUserDetails = new System.Windows.Forms.Button();
            this.ListofBooks = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.UML);
            this.MainPanel.Controls.Add(this.AddUser);
            this.MainPanel.Controls.Add(this.UpdateUserDetails);
            this.MainPanel.Controls.Add(this.ListofBooks);
            this.MainPanel.Controls.Add(this.DeleteUser);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(221, 15);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(323, 464);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // UML
            // 
            this.UML.AutoSize = true;
            this.UML.BackColor = System.Drawing.Color.Transparent;
            this.UML.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UML.Location = new System.Drawing.Point(81, 53);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(156, 69);
            this.UML.TabIndex = 9;
            this.UML.Text = "ULM";
            this.UML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddUser
            // 
            this.AddUser.ForeColor = System.Drawing.Color.Black;
            this.AddUser.Location = new System.Drawing.Point(44, 194);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(234, 35);
            this.AddUser.TabIndex = 8;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // UpdateUserDetails
            // 
            this.UpdateUserDetails.ForeColor = System.Drawing.Color.Black;
            this.UpdateUserDetails.Location = new System.Drawing.Point(44, 273);
            this.UpdateUserDetails.Name = "UpdateUserDetails";
            this.UpdateUserDetails.Size = new System.Drawing.Size(234, 35);
            this.UpdateUserDetails.TabIndex = 7;
            this.UpdateUserDetails.Text = "Update User Details";
            this.UpdateUserDetails.UseVisualStyleBackColor = true;
            // 
            // ListofBooks
            // 
            this.ListofBooks.ForeColor = System.Drawing.Color.Black;
            this.ListofBooks.Location = new System.Drawing.Point(44, 153);
            this.ListofBooks.Name = "ListofBooks";
            this.ListofBooks.Size = new System.Drawing.Size(234, 35);
            this.ListofBooks.TabIndex = 6;
            this.ListofBooks.Text = "Show List";
            this.ListofBooks.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.ForeColor = System.Drawing.Color.Black;
            this.DeleteUser.Location = new System.Drawing.Point(44, 235);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(234, 32);
            this.DeleteUser.TabIndex = 5;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // Manage_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "Manage_Students";
            this.Text = "Manage_Students";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button UpdateUserDetails;
        private System.Windows.Forms.Button ListofBooks;
        private System.Windows.Forms.Button DeleteUser;
    }
}