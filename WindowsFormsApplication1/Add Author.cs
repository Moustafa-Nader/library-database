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
    public partial class Add_Author : Form
    {
        public Add_Author()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);

            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connection;
            connection.Open();


            sqlcommand.CommandText = "select * from AUTHORS";
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

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            DataTable mytable = new DataTable();
            DataTable TempTable = new DataTable();
            command.CommandText = "select count(*) from AUTHORS where AUTHOR_ID='" + IDTextBox.Text + "' ";
            command.ExecuteNonQuery();
            myadapter.Fill(TempTable);

            if (TempTable.Rows[0][0].ToString() == "1")
            {
                Error.Text = "Author ID already exists.";
                Error.Show();
                connection.Close();
            }
            else
            {

                command.CommandText = "insert into AUTHORS values(" + IDTextBox.Text + ",'" + FirstName_TextBox.Text + "','" + LastName_TextBox.Text + "')";
                command.ExecuteNonQuery();
                command.CommandText = "select * from AUTHORS";
                DataTable data_table = new DataTable();
                SqlDataAdapter data_adapter = new SqlDataAdapter(command);
                data_adapter.Fill(data_table);
                DataGridView.DataSource = data_table;
                for (int i = 0; i < DataGridView.ColumnCount; i++)
                    DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
                connection.Close();
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void Add_Author_Load(object sender, EventArgs e)
        {

        }

        private void Add_Author_FormClosing(object sender, FormClosingEventArgs e)
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
