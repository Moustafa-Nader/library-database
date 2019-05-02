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
            this.button2 = new System.Windows.Forms.Button();
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
            this.MainPanel.Location = new System.Drawing.Point(196, 12);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(287, 371);
            this.MainPanel.TabIndex = 5;
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
            // AddAuthor
            // 
            this.AddAuthor.ForeColor = System.Drawing.Color.Black;
            this.AddAuthor.Location = new System.Drawing.Point(39, 155);
            this.AddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(208, 28);
            this.AddAuthor.TabIndex = 8;
            this.AddAuthor.Text = "Add Author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // ListofAuthors
            // 
            this.ListofAuthors.ForeColor = System.Drawing.Color.Black;
            this.ListofAuthors.Location = new System.Drawing.Point(39, 122);
            this.ListofAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListofAuthors.Name = "ListofAuthors";
            this.ListofAuthors.Size = new System.Drawing.Size(208, 28);
            this.ListofAuthors.TabIndex = 6;
            this.ListofAuthors.Text = "Show List";
            this.ListofAuthors.UseVisualStyleBackColor = true;
            this.ListofAuthors.Click += new System.EventHandler(this.ListofAuthors_Click);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.ForeColor = System.Drawing.Color.Black;
            this.DeleteAuthor.Location = new System.Drawing.Point(39, 188);
            this.DeleteAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(208, 26);
            this.DeleteAuthor.TabIndex = 5;
            this.DeleteAuthor.Text = "Delete Author";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Manage_Authors
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
            this.Name = "Manage_Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Authors";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button ListofAuthors;
        private System.Windows.Forms.Button DeleteAuthor;
        private System.Windows.Forms.Button button2;
    }
}