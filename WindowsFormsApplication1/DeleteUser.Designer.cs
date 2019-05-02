namespace Managestud
{
    partial class DeleteUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTFIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uLMDataSet = new Managestud.ULMDataSet();
            this.sTUDENTTableAdapter = new Managestud.ULMDataSetTableAdapters.STUDENTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uLMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(46, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 381);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.sTUDENTFIRSTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTLASTNAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.dATEOFBIRTHDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // sTUDENTFIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTFIRSTNAME";
            this.sTUDENTFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTFIRSTNAME";
            this.sTUDENTFIRSTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTFIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTLASTNAME";
            this.sTUDENTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTLASTNAME";
            this.sTUDENTLASTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTLASTNAMEDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            // 
            // dATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.dATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.Name = "dATEOFBIRTHDataGridViewTextBoxColumn";
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.uLMDataSet;
            // 
            // uLMDataSet
            // 
            this.uLMDataSet.DataSetName = "ULMDataSet";
            this.uLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteUser";
            this.Text = "Delete user";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uLMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ULMDataSet uLMDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private ULMDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTFIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
    }
}