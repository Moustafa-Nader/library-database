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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AdminID_TextBox = new System.Windows.Forms.TextBox();
            this.ADMIN_ID = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.AuthorUserID = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Controls.Add(this.AdminID_TextBox);
            this.MainPanel.Controls.Add(this.ADMIN_ID);
            this.MainPanel.Controls.Add(this.LastName_TextBox);
            this.MainPanel.Controls.Add(this.FirstName_TextBox);
            this.MainPanel.Controls.Add(this.UserID_TextBox);
            this.MainPanel.Controls.Add(this.AddBookButton);
            this.MainPanel.Controls.Add(this.LastName);
            this.MainPanel.Controls.Add(this.FirstName);
            this.MainPanel.Controls.Add(this.AuthorUserID);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(741, 470);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Location = new System.Drawing.Point(30, 223);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(671, 210);
            this.DataGridView.TabIndex = 21;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AdminID_TextBox
            // 
            this.AdminID_TextBox.Location = new System.Drawing.Point(294, 27);
            this.AdminID_TextBox.Name = "AdminID_TextBox";
            this.AdminID_TextBox.Size = new System.Drawing.Size(274, 26);
            this.AdminID_TextBox.TabIndex = 20;
            // 
            // ADMIN_ID
            // 
            this.ADMIN_ID.AutoSize = true;
            this.ADMIN_ID.BackColor = System.Drawing.Color.Transparent;
            this.ADMIN_ID.Location = new System.Drawing.Point(145, 27);
            this.ADMIN_ID.Name = "ADMIN_ID";
            this.ADMIN_ID.Size = new System.Drawing.Size(75, 20);
            this.ADMIN_ID.TabIndex = 19;
            this.ADMIN_ID.Text = "Admin ID";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(294, 135);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(274, 26);
            this.LastName_TextBox.TabIndex = 17;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(294, 98);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(274, 26);
            this.FirstName_TextBox.TabIndex = 16;
            // 
            // UserID_TextBox
            // 
            this.UserID_TextBox.Location = new System.Drawing.Point(294, 62);
            this.UserID_TextBox.Name = "UserID_TextBox";
            this.UserID_TextBox.Size = new System.Drawing.Size(274, 26);
            this.UserID_TextBox.TabIndex = 15;
            // 
            // AddBookButton
            // 
            this.AddBookButton.ForeColor = System.Drawing.Color.Black;
            this.AddBookButton.Location = new System.Drawing.Point(446, 175);
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
            this.LastName.Location = new System.Drawing.Point(145, 135);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 12;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Location = new System.Drawing.Point(145, 98);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(86, 20);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "First Name";
            // 
            // AuthorUserID
            // 
            this.AuthorUserID.AutoSize = true;
            this.AuthorUserID.BackColor = System.Drawing.Color.Transparent;
            this.AuthorUserID.Location = new System.Drawing.Point(145, 62);
            this.AuthorUserID.Name = "AuthorUserID";
            this.AuthorUserID.Size = new System.Drawing.Size(64, 20);
            this.AuthorUserID.TabIndex = 10;
            this.AuthorUserID.Text = "User ID";
            // 
            // Add_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "Add_Admin";
            this.Text = "Add_Admin";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox AdminID_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label AuthorUserID;
        private System.Windows.Forms.Label ADMIN_ID;
    }
}