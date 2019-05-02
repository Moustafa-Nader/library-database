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
    public partial class Update_Book : Form
    {
        int cell;
        public Update_Book()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cell = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["ISBN"].FormattedValue.ToString());
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            //if(DataGridView.SelectedCells[0].Value is int)
            //cell = Convert.ToInt32(DataGridView.SelectedCells[0].Value.ToString());
            //MessageBox.Show("cell " + cell);
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from BOOK where ISBN =" + cell + "";
            command.ExecuteNonQuery();
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            data_adapter.Fill(data_table);
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            foreach (DataRow data_row in data_table.Rows)
            {
                ISBNTextBox.Text = data_row["ISBN"].ToString();
                IDTextBox.Text = data_row["AUTHOR_ID"].ToString();
                NameTextBox.Text = data_row["BOOKNAME"].ToString();
                PublisherTextBox.Text = data_row["PUBLISHER"].ToString();
                DateTimePicker.Value = Convert.ToDateTime(data_row["PUBLICATIONDATE"].ToString());
            }
            connection.Close();
        }

        private void UpdateBookButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update BOOK set AUTHOR_ID="+IDTextBox.Text+",BOOKNAME='"+NameTextBox.Text+"',PUBLISHER='"+PublisherTextBox.Text+"',PUBLICATIONDATE="+ DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Year+" Where ISBN="+cell+"";
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from BOOK";
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            data_adapter.Fill(data_table);
            DataGridView.DataSource = data_table;
            connection.Close();
        }

        private void Update_Book_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            
        }

        private void Update_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
