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
    public partial class Delete_Book : Form
    {
        public Delete_Book()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();

            command.CommandText = " delete from BOOK where BOOK.ISBN='" + ISBNTextBox.Text + "'";
            command.ExecuteNonQuery();
            command.CommandText = "select * from BOOK";
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            DataGridView.DataSource = mytable;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);

        }

        private void Delete_Book_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();

        }

        private void Delete_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
