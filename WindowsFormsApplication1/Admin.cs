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
    public partial class Admin : Form
    {
        static Form SignIn = Application.OpenForms["Form1"];
        public string AdminSignInID = ((Form1)SignIn).AdminSignInID;
        SqlConnection connection = new SqlConnection(connectionstring.myconnectionstring);
        SqlCommand comm = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            FormState.AdminForm = this;
            UserID.Text = AdminSignInID;

                comm.Connection = connection;
                connection.Open();

                comm.CommandText = "Select Username " +
                                   "From ACCOUNT inner Join ADMIN " +
                                   "on ACCOUNT.ADMIN_ID = ADMIN.ADMIN_ID " +
                                   "where ACCOUNT.ADMIN_ID = " + this.AdminSignInID;
                object temp = comm.ExecuteScalar();
                Username.Text = temp.ToString();
                connection.Close();


        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            UserPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void ManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks b1 = new ManageBooks();
            b1.Show();
            this.Hide();
        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {
           Manage_Students s1 = new Manage_Students();
            s1.Show();
            this.Hide();
        }

        private void ManageAuthors_Click(object sender, EventArgs e)
        {
            Manage_Authors a1 = new Manage_Authors();
            a1.Show();
            this.Hide();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            Add_Admin a1 = new Add_Admin();
            a1.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form SignIn = Application.OpenForms["Form1"];
            // string SignInID = ((Form1)SignIn).SignInID;
            
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.mainform.ShowAndEmpty();
            this.Hide();
        }
    }
}
