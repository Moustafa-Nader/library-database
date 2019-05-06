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
        SqlConnection myconnection;
        SqlCommand comm;
        string Username;
        string Password;
        public string SignInID;
        public string AdminSignInID;
        string serverName = "LAPTOP-HTO4DVSU\\SQLEXPRESS";
        string Database = "ULM";
        
       
           
        public Form1()
        { 
            InitializeComponent();
            connectionstring.myconnectionstring = "Data Source=" + serverName + ";Initial Catalog=" + Database + ";Integrated Security=True";
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
			myconnection  = new SqlConnection(connectionstring.myconnectionstring);
			comm = new SqlCommand();
            comm.Connection = myconnection;
            label5.Hide();
            FormState.mainform = this;
            
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
            Admin adm;

            Username = textBox1.Text;
            Password = textBox2.Text;

            Console.WriteLine(Username + " " + Password);

            myconnection.Open();

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
                    comm.CommandText = "select ADMIN_ID from ACCOUNT where USERNAME = '" + Username + "'";
                    object temp = comm.ExecuteScalar();
                    if(temp.ToString() != "")
                    {
                        Hide();
                        AdminSignInID = temp.ToString();
                        adm = new Admin();
                        adm.Show();
                    }
                    else
                    {
                        comm.CommandText = "select STUDENT_ID from ACCOUNT where USERNAME = '" + Username + "'";
                        temp = comm.ExecuteScalar();
                        SignInID = temp.ToString();
                        stu = new Student();
                        stu.Show();
                        this.Hide();
                        FormState.PreviousPage = this;
                    }
                    
                    
                }
            }
            myconnection.Close();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin myadmin = new Admin();
            myadmin.Show();
            this.Hide();
        }

        public void ShowAndEmpty()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Show();
        }

    }
    public static class FormState
    {
        public static Form PreviousPage;
        public static Form AdminForm;
        public static Form1 mainform;
    }
    public static class connectionstring
    {
        public static string myconnectionstring;
    }
}
