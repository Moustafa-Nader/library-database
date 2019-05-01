using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand comm;

        string Username;
        string Password;
        string SignInID;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            con = new SqlConnection("Data Source=LAPTOP-1IE4L68L\\SQLEXPRESS;Initial Catalog=ULM;Integrated Security=True");
            comm = new SqlCommand();
            comm.Connection = con;
            label5.Hide();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Student stu;
            

            Username = textBox1.Text;
            Password = textBox2.Text;

            Console.WriteLine(Username + " " + Password);

            con.Open();

            comm.CommandText = "select * from ACCOUNT where USERNAME = '" + Username + "'";

            Console.WriteLine(comm.CommandText);
            if(comm.ExecuteScalar() == null)
            {
                label5.Text = "Username doesn't exist!";
                label5.Show();
            }
            else
            {
                comm.CommandText = "select * from ACCOUNT where USERNAME = '" + Username + "' and PASSWORD = '" + Password + "'";
                if(comm.ExecuteScalar() == null)
                {
                    label5.Text = "Incorrect Password!";
                    label5.Show();
                }
                else
                {
                    MessageBox.Show("Logic Successful!");
                    comm.CommandText = "select USER_ID from ACCOUNT where USERNAME = '" + Username + "'";
                    object temp = comm.ExecuteScalar();
                    SignInID = temp.ToString();
                    stu = new Student();
                    stu.Show();
                }
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up new_account = new Sign_Up(this);
            new_account.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
