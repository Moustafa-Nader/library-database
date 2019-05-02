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
    public partial class UpdateUser : Form
    {
        int cell;
        public UpdateUser()

        {
            
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'uLMDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.uLMDataSet.STUDENT);

        }

        

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;

            sqlconnection.Open();

            sqlcommand.CommandText = "select * from student";
            sqlcommand.ExecuteNonQuery();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            sqlconnection.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cell = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["user_id"].FormattedValue.ToString());
                // TRY TO FIND A WAY TO SELECT A CELL WITHOUT BREAKING
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");
                connection.Open();
                
                //MessageBox.Show("cell " + cell);
                SqlCommand command = new SqlCommand("", connection);
                command.CommandText = "select * from student where user_id=" + cell + "";
                command.ExecuteNonQuery();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            DataTable data_table = new DataTable();
                SqlDataAdapter data_adapter = new SqlDataAdapter(command);
                data_adapter.Fill(data_table);
               
                foreach (DataRow data_row in data_table.Rows)
                {
                    textBox2.Text = data_row["user_id"].ToString();
                    textBox1.Text = data_row["student_id"].ToString();
                    textBox3.Text = data_row["studentfirstname"].ToString();
                    textBox5.Text = data_row["studentlastname"].ToString();
                    textBox7.Text = data_row["age"].ToString();
                    textBox6.Text = data_row["year"].ToString();
                    
                    dateTimePicker1.Value = Convert.ToDateTime(data_row["dateofbirth"].ToString());
                }
                connection.Close();
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;

            sqlconnection.Open();

            sqlcommand.CommandText = "update student set student_id=" + textBox1.Text + ",studentfirstname='" + textBox3.Text + "',studentlastname='" + textBox5.Text + "',age='" + textBox7.Text + "',year='" + textBox6.Text + "',dateofbirth=" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year + " Where user_id=" + cell + "";
            sqlcommand.ExecuteNonQuery();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            sqlconnection.Close();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
