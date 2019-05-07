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
    public partial class Add_Book : Form
    {
        public Add_Book()
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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            DataTable mytable = new DataTable();
            DataTable TempTable = new DataTable();
            command.CommandText = "select count(*) from BOOK where ISBN='" + ISBNTextBox.Text + "' ";
            command.ExecuteNonQuery();
            myadapter.Fill(TempTable);

            if (TempTable.Rows[0][0].ToString() == "1")
            {
                Error.Text = "ISBN already exists.";
                Error.Show();
                connection.Close();
            }
            else
            {

                //command.CommandType = CommandType.Text;
                command.CommandText = "insert into BOOK values(" + ISBNTextBox.Text + "," + IDTextBox.Text + ",'" + NameTextBox.Text + "','" + PublisherTextBox.Text + "','" + DateTimePicker.Value.Year + "/" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "')";
                command.ExecuteNonQuery();
                command.CommandText = "select * from BOOK";
                DataTable data_table = new DataTable();
                SqlDataAdapter data_adapter = new SqlDataAdapter(command);
                data_adapter.Fill(data_table);
                DataGridView.DataSource = data_table;
                connection.Close();
            }
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Book_FormClosing(object sender, FormClosingEventArgs e)
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
