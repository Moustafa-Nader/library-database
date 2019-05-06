namespace WindowsFormsApplication1
{
    partial class Manage_Authors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Authors));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UML = new System.Windows.Forms.Label();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.ListofAuthors = new System.Windows.Forms.Button();
            this.DeleteAuthor = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.UML);
            this.MainPanel.Controls.Add(this.AddAuthor);
            this.MainPanel.Controls.Add(this.ListofAuthors);
            this.MainPanel.Controls.Add(this.DeleteAuthor);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(220, 15);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(323, 464);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // UML
            // 
            this.UML.AutoSize = true;
            this.UML.BackColor = System.Drawing.Color.Transparent;
            this.UML.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UML.Location = new System.Drawing.Point(81, 52);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(156, 69);
            this.UML.TabIndex = 9;
            this.UML.Text = "ULM";
            this.UML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddAuthor
            // 
            this.AddAuthor.ForeColor = System.Drawing.Color.Black;
            this.AddAuthor.Location = new System.Drawing.Point(44, 194);
            this.AddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(234, 35);
            this.AddAuthor.TabIndex = 8;
            this.AddAuthor.Text = "Add Author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // ListofAuthors
            // 
            this.ListofAuthors.ForeColor = System.Drawing.Color.Black;
            this.ListofAuthors.Location = new System.Drawing.Point(44, 152);
            this.ListofAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListofAuthors.Name = "ListofAuthors";
            this.ListofAuthors.Size = new System.Drawing.Size(234, 35);
            this.ListofAuthors.TabIndex = 6;
            this.ListofAuthors.Text = "Show List";
            this.ListofAuthors.UseVisualStyleBackColor = true;
            this.ListofAuthors.Click += new System.EventHandler(this.ListofAuthors_Click);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.ForeColor = System.Drawing.Color.Black;
            this.DeleteAuthor.Location = new System.Drawing.Point(44, 235);
            this.DeleteAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(234, 32);
            this.DeleteAuthor.TabIndex = 5;
            this.DeleteAuthor.Text = "Delete Author";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Back.Location = new System.Drawing.Point(11, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(58, 20);
            this.Back.TabIndex = 19;
            this.Back.Text = "< Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Manage_Authors
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
            this.Name = "Manage_Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Authors";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_Authors_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Authors_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button ListofAuthors;
        private System.Windows.Forms.Button DeleteAuthor;
        private System.Windows.Forms.Label Back;
    }
}