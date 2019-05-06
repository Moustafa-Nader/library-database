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
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);

            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connection;
            connection.Open();


            sqlcommand.CommandText = "select * from STUDENT";
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            DataGridView.DataSource = mytable;
            for (int i = 0; i < DataGridView.ColumnCount; i++)
                DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
            connection.Close();
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
            SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable TempTable = new DataTable();
            connection.Open();
            command.CommandText = "select count(*) from STUDENT where STUDENT_ID='" + ID_textBox.Text + "'";
            command.ExecuteNonQuery();
            adapter.Fill(TempTable);
            if (TempTable.Rows[0][0].ToString() == "0")
            {
                label3.Text = "This ID doesn't exist.";
                label3.Show();
                connection.Close();

            }
            else {

                command.CommandText = " delete from librarycard where librarycard.student_ID='" + ID_textBox.Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = " delete from rents where rents.student_ID='" + ID_textBox.Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = " delete from account where account.student_ID='" + ID_textBox.Text + "' ";
                command.ExecuteNonQuery();

                command.CommandText = " delete from student where student.student_ID='" + ID_textBox.Text + "' ";
                command.ExecuteNonQuery();



                for (int i = 0; i < DataGridView.ColumnCount; i++)
                    DataGridView.Columns[i].Width = (DataGridView.Width / DataGridView.ColumnCount) - 1;
                command.CommandText = "select * from student";
                SqlDataAdapter myadapter = new SqlDataAdapter(command);
                DataTable mytable = new DataTable();
                myadapter.Fill(mytable);
                DataGridView.DataSource = mytable;
                connection.Close();
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
