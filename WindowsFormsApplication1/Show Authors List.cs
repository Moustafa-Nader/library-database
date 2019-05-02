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
    public partial class Show_Authors_List : Form
    {
        public Show_Authors_List()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from AUTHORS";
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            data_adapter.Fill(data_table);
            DataGridView.DataSource = data_table;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Authors_List_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void Show_Authors_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
