using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            FormState.AdminForm = this;
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
            FormState.mainform.ShowAndEmpty();
           
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
