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

            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connection;
            connection.Open();


            sqlcommand.CommandText = "select * from BOOK";
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            DataGridView.DataSource = mytable;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable TempTable = new DataTable();
            connection.Open();
            command.CommandText = "select count(*) from BOOK where ISBN='" + ISBNTextBox.Text + "'";
            command.ExecuteNonQuery();
            adapter.Fill(TempTable);
            if (TempTable.Rows[0][0].ToString() == "0")
            {
                Error.Text = "This ISBN doesn't exist.";
                Error.Show();
                connection.Close();

            }
            else
            {
                command.CommandText = " delete from RENTS where RENTS.ISBN='" + ISBNTextBox.Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = " delete from BOOKCATEGORIES where BOOKCATEGORIES.ISBN='" + ISBNTextBox.Text + "'";
                command.ExecuteNonQuery();

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
            

        }

        private void Delete_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
