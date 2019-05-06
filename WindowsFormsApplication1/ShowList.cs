using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ShowList : Form
    {
        public ShowList()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = "select * from account";
            command.ExecuteNonQuery();
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            DataGridView.DataSource = mytable;
            connection.Close();
        }

        private void ShowList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uLMDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            //this.aCCOUNTTableAdapter.Fill(this.uLMDataSet.ACCOUNT);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }
    }
}
