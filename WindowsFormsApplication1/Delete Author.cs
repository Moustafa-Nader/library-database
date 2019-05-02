using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Delete_Author : Form
    {
        public Delete_Author()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();

            command.CommandText = " delete from AUTHORS where AUTHORS.AUTHOR_ID='" + AuthorID_TextBox.Text + "'";
            command.ExecuteNonQuery();
            command.CommandText = "select * from AUTHORS";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);

        }

        private void Delete_Author_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void Delete_Author_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
