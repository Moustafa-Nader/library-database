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

namespace Managestud
{
    public partial class ShowList : Form
    {
        public ShowList()
        {
            InitializeComponent();
        }

        private void ShowList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uLMDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.uLMDataSet.ACCOUNT);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
         
            sqlconnection.Open();

            sqlcommand.CommandText = "select * from account";
            sqlcommand.ExecuteNonQuery();
          for (int i = 0; i < dataGridView1.ColumnCount; i++)
              dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            sqlconnection.Close();
        }

        
    }
}
