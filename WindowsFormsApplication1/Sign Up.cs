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
    public partial class Sign_Up : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NF0CFJ8\\SQLEXPRESS;Initial Catalog=mylib;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlCommand comm2 = new SqlCommand();
        Form1 form1 = new Form1();
        public Sign_Up(Form1 prevForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            comm.Connection = con;
            comm2.Connection = con;
            label2.Hide();
            form1 = prevForm;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DoB_Click(object sender, EventArgs e)
        {

        }
        private bool isbigger(int num,string month,int numday, int day)//day,month are student day,month
        {
            int intMonth = 0;
            switch(month)
            {
                case "January":
                    intMonth = 1;
                    break;
                case "February":
                    intMonth = 2;
                    break;
                case "March":
                    intMonth = 3;
                    break;
                case "April":
                    intMonth = 4;
                    break;
                case "May":
                    intMonth = 5;
                    break;
                case "June":
                    intMonth = 6;
                    break;
                case "July":
                    intMonth = 7;
                    break;
                case "August":
                    intMonth = 8;
                    break;
                case "September":
                    intMonth = 9;
                    break;
                case "October":
                    intMonth = 10;
                    break;
                case "November":
                    intMonth = 11;
                    break;
                case "December":
                    intMonth = 12;
                    break;
            }
            if (intMonth == num)
            {
                if (numday <= day)
                    return true;
                else
                    return false;
            }
            else if (intMonth > num)
                return true;
            else
                return false;

        }

        private int calculateAge(string s)
        {
            DateTime currentDate = DateTime.Now;
            int currentBirthYear = ((s[s.Length - 4] - '0') * 1000) + ((s[s.Length - 3] - '0') * 100) + ((s[s.Length - 2] - '0') * 10) + (s[s.Length - 1] - '0');
            int currentAge = currentDate.Year - currentBirthYear;
            bool flag = false;
            string tempDay = "";
            string tempMonth = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == ',')
                {
                    if (!flag)
                        flag = true;
                    else if (flag)
                        break;
              
                }
                if (flag && s[i] >= '0' && s[i] <= '9')
                    tempDay += s[i];
                else if (flag && s[i] != ' ')
                    tempMonth += s[i];
            }
            currentAge += (isbigger(currentDate.Month, tempMonth, currentDate.Day, Int32.Parse(tempDay))) ? 0 : -1;
            if (currentAge < 0)
                currentAge = 0;
            return currentAge;
        }
        private int convertLevel(string s)
        {
            switch(s)
            {
                case "One":
                    return 1;
                case "Two":
                    return 2;
                case "Three":
                    return 3;
                case "Four":
                    return 4;
                case "Five":
                    return 5;
            }
            return 0;
        }
        private string calculateDate(string s)
        {
            string temp = "";
            string day = "", Month="", Year="";
            bool flag = false;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    if (!flag)
                        flag = true;
                    else
                    {
                        if (Month.Length == 0)
                            Month = temp;
                        else if (day.Length == 0)
                            day = temp;
                        //Console.WriteLine(temp);
                        temp = "";
                    }
                }
                else if (s[i] != ' ' && flag)
                    temp += s[i];
                else if (flag)
                {
                    if (Month.Length == 0 && temp.Length != 0)
                        Month = temp;
                    else if (day.Length == 0 && temp.Length != 0)
                        day = temp;
                    temp = "";
                }
            }
            Year = temp;
            //Console.WriteLine(Year + " " + Month + " " + day);

            switch(Month)
            {
                case "January":
                    return day + "-JAN-" + Year;
                case "February":
                    return day + "-FEB-" + Year;
                case "March":
                    return day + "-MAR-" + Year;
                case "April":
                    return day + "-APR-" + Year;
                case "May":
                    return day + "-MAY-" + Year;
                case "June":
                    return day + "-JUN-" + Year;
                case "July":
                    return day + "-JUL-" + Year;
                case "August":
                    return day + "-AUG-" + Year;
                case "September":
                    return day + "-SEP-" + Year;
                case "October":
                    return day + "-OCT-" + Year;
                case "November":
                    return day + "-NOV-" + Year;
                case "December":
                    return day + "-DEC-" + Year;
            }

            return "";
        }
        private bool isValidStudentID(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!(s[i] >= '0' && s[i] <= '9'))
                    return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = First_NameTextbox.Text;
            string LastName = Last_NameTextbox.Text;
            string UsernameText = UsernameTextbox.Text;
            string Password = Passwordtextbox.Text;
            string re_Password = PasswordTextbox2.Text;
            string Email = EmailTextbox.Text;
            string StudentID = IDTextbox.Text;
            string Level = LevelComboBox.Text;
            string DateofBirth = DoBTimePicker.Text;

            //Console.WriteLine(DateofBirth);

            con.Open();

            if (FirstName.Length == 0)
            {
                label2.Text = "First Name field cannot be empty!";
                label2.Show();
            }
            else if (LastName.Length == 0)
            {
                label2.Text = "Last Name field cannot be empty!";
                label2.Show();
            }
            else if (UsernameText.Length == 0)
            {
                label2.Text = "Username field cannot be empty!";
                label2.Show();
            }
            else if (Password.Length == 0)
            {
                label2.Text = "Password field cannot be empty!";
                label2.Show();
            }
            else if (re_Password.Length == 0)
            {
                label2.Text = "Please re-enter your password!";
                label2.Show();
            }
            else if (Email.Length == 0)
            {
                label2.Text = "Email field cannot be empty!";
                label2.Show();
            }
            else if (StudentID.Length == 0)
            {
                label2.Text = "Student ID field cannot be empty!";
                label2.Show();
            }
            else if (Level.Length == 0)
            {
                label2.Text = "Level field cannot be empty!";
                label2.Show();
            }
            else if (DateofBirth.Length == 0)
            {
                label2.Text = "Date of Birth field cannot be empty!";
                label2.Show();
            }
            else
            {

                comm.CommandText = "select * from ACCOUNT where USERNAME = '" + UsernameText + "'";

                if (comm.ExecuteScalar() != null)
                {
                    label2.Text = "Username already exists!";
                    label2.Show();
                }
                else if (Password != re_Password)
                {
                    label2.Text = "Passwords don't match!";
                    label2.Show();
                }
                else if (Level != "One" && Level != "Two" && Level != "Three" && Level != "Four" && Level !=  "Five")
                {
                    label2.Text = "Invalid Level Input!";
                    label2.Show();
                }
                else if(!isValidStudentID(StudentID))
                {
                    label2.Text = "Invalid Student ID!";
                    label2.Show();
                }
                else
                {
                    comm.CommandText = "select * from ACCOUNT where STUDENT_ID = " + Int32.Parse(StudentID);
                    if (comm.ExecuteScalar() != null)
                    {
                        label2.Text = "Student ID already exists!";
                        label2.Show();
                    }
                    else
                    {
                        comm2.CommandText = "Select MAX(ACCOUNT.USER_ID) from ACCOUNT";
                        comm.CommandText = "insert into STUDENT values (" + Int32.Parse(StudentID) + ", NULL , " +"'" + FirstName + "' , '" + LastName + "' , " +calculateAge(DateofBirth) + ",'" + calculateDate(DateofBirth) + "'," + convertLevel(Level) + ")";
                        comm.ExecuteNonQuery();
                        //Console.WriteLine(comm.CommandText);
                        object num = comm2.ExecuteScalar();
                        int temp = Int32.Parse(num.ToString());
                        temp++;
                        comm.CommandText = "insert into ACCOUNT values (" + temp + ",NULL," + Int32.Parse(StudentID) + ",'" + UsernameText + "','" + Password + "','" + Email + "')";
                        comm.ExecuteNonQuery();
                        //Console.WriteLine(comm.CommandText);
                        Hide();
                        form1.Show();
                        MessageBox.Show("Registration Successful!");
                    }
                }

            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            //UsernameTextbox.got
        }

        private void IDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoBTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void First_Name_Click(object sender, EventArgs e)
        {

        }
        private void Level_Click(object sender, EventArgs e)
        {

        }
        private void DoB_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Sign_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }
    }
}
