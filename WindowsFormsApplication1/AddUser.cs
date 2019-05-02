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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uLMDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.uLMDataSet.STUDENT);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();

            sqlcommand.CommandText = " insert into  student values (  '" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year + "' , '" + textBox6.Text + "' )";
            sqlcommand.ExecuteNonQuery();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            sqlcommand.CommandText = "select * from student";
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            sqlconnection.Close();
           

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
