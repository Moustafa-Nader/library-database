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
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HTO4DVSU\\SQLEXPRESS;Initial Catalog=ULM;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);

            //command.CommandType = CommandType.Text;
            command.CommandText = "insert into ADMIN values(" + AdminID_TextBox.Text + "," + UserID_TextBox.Text + ",'" + FirstName_TextBox.Text + "','" + LastName_TextBox.Text + "')";
            command.ExecuteNonQuery();
            command.CommandText = "select * from ADMIN";
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            data_adapter.Fill(data_table);
            DataGridView.DataSource = data_table;
            connection.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                FormState.PreviousPage.Show();
                this.Hide();
                FormState.PreviousPage = this;
            }
        }
    }
}
