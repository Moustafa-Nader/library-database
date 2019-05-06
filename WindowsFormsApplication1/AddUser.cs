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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-HTO4DVSU\\SQLEXPRESS;Initial Catalog=ULM;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
            sqlcommand.CommandText = "select * from STUDENT";
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            sqlconnection.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uLMDataSet.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.uLMDataSet.STUDENT);

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
            string FirstName = Fname_textBox.Text;
            string LastName = Lname_textBox.Text;
            string UsernameText = Username_textBox.Text;
            string Password = Password_textBox.Text;
            string Email = Email_textBox.Text;
            string StudentID = StudentID_textBox.Text;
            string Level = Level_textBox.Text;

            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-HTO4DVSU\\SQLEXPRESS;Initial Catalog=ULM;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlcommand2.Connection = sqlconnection;
            SqlDataAdapter myadapter = new SqlDataAdapter(sqlcommand);
            DataTable mytable = new DataTable();
            //DataTable Temp1Table = new DataTable();
            //DataTable TempTable = new DataTable();

            sqlconnection.Open();
            if (FirstName.Length == 0)
            {
                Error.Text = "First Name field cannot be empty!";
                Error.Show();
            }
            else if (LastName.Length == 0)
            {
                Error.Text = "Last Name field cannot be empty!";
                Error.Show();
            }
            else if (UsernameText.Length == 0)
            {
                label2.Text = "Username field cannot be empty!";
                label2.Show();
            }
            else if (Password.Length == 0)
            {
                Error.Text = "Password field cannot be empty!";
                Error.Show();
            }
            else if (Email.Length == 0)
            {
                Error.Text = "Email field cannot be empty!";
                Error.Show();
            }
            else if (StudentID.Length == 0)
            {
                Error.Text = "Student ID field cannot be empty!";
                Error.Show();
            }
            else if (Level.Length == 0)
            {
                Error.Text = "Level field cannot be empty!";
                Error.Show();
            }
            else {
                sqlcommand.CommandText = "select * from ACCOUNT where STUDENT_ID = " + Int32.Parse(StudentID);
                if (sqlcommand.ExecuteScalar() != null)
                {
                    Error.Text = "Student ID already exists!";
                    Error.Show();
                }
                else
                {
                    sqlcommand.CommandText = " insert into  student values (   '" + StudentID_textBox.Text + "','" + Fname_textBox.Text + "','" + Lname_textBox.Text + "','" + Age_textBox.Text + "','" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year + "' , '" + Level_textBox.Text + "' )";
                    sqlcommand.ExecuteNonQuery();

                    sqlcommand2.CommandText = "Select MAX(ACCOUNT.USER_ID) from ACCOUNT";
                    object num = sqlcommand2.ExecuteScalar();
                    int temp = Int32.Parse(num.ToString());
                    temp++;
                    DateTime currentDate = DateTime.Now;
                    int currYear = currentDate.Year + 1;
                    sqlcommand.CommandText = "insert into ACCOUNT values (" + temp + ",NULL," + Int32.Parse(StudentID) + ",'" + UsernameText + "','" + Password + "','" + Email + "')";
                    sqlcommand.ExecuteNonQuery();
                    sqlcommand.CommandText = "set dateformat dmy \n insert into LIBRARYCARD values (" + Int32.Parse(StudentID) + ",CAST('" + currentDate.Day + "/" + currentDate.Month + "/" + currYear + " " + currentDate.Hour + ":" + currentDate.Minute + ":" + currentDate.Second + "' AS DATETIME))";


                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
                    sqlcommand.CommandText = "select * from student";
                    myadapter.Fill(mytable);
                    dataGridView1.DataSource = mytable;
                    sqlconnection.Close();


                }
            }
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

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
