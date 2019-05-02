using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uLMDataSet.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.uLMDataSet.STUDENT);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-SQ0RA99\\SQL;Initial Catalog=ULM;Integrated Security=True");

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = " delete from librarycard where librarycard.student_ID='" + textBox1.Text + "'";
            sqlcommand.ExecuteNonQuery();

            sqlcommand.CommandText = " delete from rents where rents.student_ID='" + textBox1.Text + "'";
            sqlcommand.ExecuteNonQuery();
            sqlcommand.CommandText = " delete from account where account.student_ID='" + textBox1.Text + "' ";
            sqlcommand.ExecuteNonQuery();
           
            sqlcommand.CommandText = " delete from student where student.student_ID='" + textBox1.Text + "' ";
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
