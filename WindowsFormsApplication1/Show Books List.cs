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
    public partial class Show_List : Form
    {
        public Show_List()
        {
            InitializeComponent();
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HTO4DVSU\\SQLEXPRESS;Initial Catalog=ULM;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from BOOK";
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            data_adapter.Fill(data_table);
            DataGridView.DataSource = data_table;
            connection.Close();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }
    }
}
