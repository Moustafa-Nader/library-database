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

    public partial class Student : Form
    {
        
		SqlConnection con = new SqlConnection(connectionstring.myconnectionstring);
		SqlCommand comm = new SqlCommand();
        static Form SignIn = Application.OpenForms["Form1"];
        public string SignInID = ((Form1)SignIn).SignInID;
        public Student()
        {
            InitializeComponent();
            comm.Connection = con;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);


            con.Open();
            
            //Setting the Username...
            comm.CommandText = "Select Username " +
                               "From ACCOUNT inner Join STUDENT " +
                               "on ACCOUNT.STUDENT_ID = STUDENT.STUDENT_ID " +
                               "where ACCOUNT.STUDENT_ID = " + this.SignInID;
            object temp = comm.ExecuteScalar();
            Username.Text = temp.ToString();


            //Setting User Level
            comm.CommandText = "Select YEAR " +
                               "From ACCOUNT inner Join STUDENT " +
                               "on ACCOUNT.STUDENT_ID = STUDENT.STUDENT_ID " +
                               "where ACCOUNT.STUDENT_ID = " + this.SignInID;
            temp = comm.ExecuteScalar();
            UserLevel.Text = temp.ToString();

            //Setting User Date of Birth
            comm.CommandText = "Select DATEOFBIRTH " +
                               "From ACCOUNT inner Join STUDENT " +
                               "on ACCOUNT.STUDENT_ID = STUDENT.STUDENT_ID " +
                               "where ACCOUNT.STUDENT_ID = " + this.SignInID;
            DateTime d = (DateTime)comm.ExecuteScalar();     //catching Date in DateTime Object then changed into string...
            UserDoB.Text = d.ToShortDateString();

            //Setting User Age
            comm.CommandText = "Select Age " +
                               "From ACCOUNT inner Join STUDENT " +
                               "on ACCOUNT.STUDENT_ID = STUDENT.STUDENT_ID " +
                               "where ACCOUNT.STUDENT_ID = " + this.SignInID;
            temp = comm.ExecuteScalar();
            UserAge.Text = temp.ToString();
            //Setting User Expiry Date
            comm.CommandText = "Select EXPIRATIONDATE " +
                               "from Student,librarycard,account " +
                               "where student.student_id = librarycard.student_id " +
                               "and student.student_id = account.student_id " +
                               "and ACCOUNT.STUDENT_ID = " + SignInID;
            temp = comm.ExecuteScalar();
            UserCardExpiryDate.Text = temp.ToString();

            //Settng User ID
            UserID.Text = this.SignInID;

            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Update Button
        private void button1_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(AgeTextBox.Text))
             //   UserAge.Text = AgeTextBox.Text;
            if (!string.IsNullOrWhiteSpace(DoBTextBox.Text))
                UserDoB.Text = DoBTextBox.Text;
            if (!string.IsNullOrWhiteSpace(LevelTextBox.Text))
                UserLevel.Text = LevelTextBox.Text;

            EditButton.Visible = true;
            UserAge.Visible = true;
            UserDoB.Visible = true;
            UserLevel.Visible = true;

            UpdateButton.Visible = false;
           // AgeTextBox.Visible = false;
            LevelTextBox.Visible = false;
            DoBTextBox.Visible = false;

            

            con.Open();
            comm.CommandText = "update STUDENT set DATEOFBIRTH = " + UserDoB.Text + " , YEAR = " + UserLevel.Text + " where STUDENT.STUDNET_ID = " + SignIn;
            con.Close();
        }

        //Edit Button
        private void button6_Click(object sender, EventArgs e)
        {
            EditButton.Visible = false;
            UserAge.Visible = false;
            UserDoB.Visible = false;
            UserLevel.Visible = false;

            UpdateButton.Visible = true;
           // AgeTextBox.Visible = true;
            LevelTextBox.Visible = true;
            DoBTextBox.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BrowseBooksButton_Click(object sender, EventArgs e)
        {
            BrowseBook mybook = new BrowseBook();
            mybook.Show();
            this.Hide();
            FormState.PreviousPage = this;

        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowListOfBooks mylist = new ShowListOfBooks();
            mylist.Show();
            FormState.PreviousPage = this;
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void RentedBooksButton_Click(object sender, EventArgs e)
        {
           
            RentedBooks f = new RentedBooks();
            f.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form tempForm = Application.OpenForms["Form1"];
            
            FormState.mainform.ShowAndEmpty();
            this.Hide();
        
        }

        private void RentBookButton_Click(object sender, EventArgs e)
        {
            StudentRentBooks myrents = new StudentRentBooks();
            myrents.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
