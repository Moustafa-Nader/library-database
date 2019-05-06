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
    public partial class Add_Admin : Form
    {
        public Add_Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);

            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connection;
            connection.Open();

            
            sqlcommand.CommandText = "select * from ADMIN";
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            DataGridView.DataSource = mytable;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            SqlCommand command2 = new SqlCommand("", connection);
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            DataTable mytable = new DataTable();
            DataTable TempTable = new DataTable();
            command.CommandText = "select count(*) from ADMIN where ADMIN_ID='" + AdminID_TextBox.Text + "' ";
            command.ExecuteNonQuery();
            myadapter.Fill(TempTable);

            if (TempTable.Rows[0][0].ToString() == "1")
            {
                Error.Text = "Admin ID already exists.";
                Error.Show();
                connection.Close();
            }
            else {
                //command.CommandType = CommandType.Text;
                command.CommandText = "insert into ADMIN values(" + AdminID_TextBox.Text + ",'" + FirstName_TextBox.Text + "','" + LastName_TextBox.Text + "')";
                command.ExecuteNonQuery();

                command2.CommandText = "Select MAX(ACCOUNT.USER_ID) from ACCOUNT";
                object num = command2.ExecuteScalar();
                int ID = Int32.Parse(num.ToString());
                ID++;

                command.CommandText = " insert into  ACCOUNT  values (  '" + ID + "', '" + AdminID_TextBox.Text + "', NULL, '" + Username_TextBox.Text + "','" + PasswordtextBox.Text + "','" + EmailtextBox.Text + "')";
                command.ExecuteNonQuery();

                command.CommandText = "select * from ADMIN";
                DataTable data_table = new DataTable();
                SqlDataAdapter data_adapter = new SqlDataAdapter(command);
                data_adapter.Fill(data_table);
                DataGridView.DataSource = data_table;
            }
            connection.Close();
        }
       
       
                
            
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

      
        private void Add_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Add_Admin_FormClosing(object sender, FormClosingEventArgs e)
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
