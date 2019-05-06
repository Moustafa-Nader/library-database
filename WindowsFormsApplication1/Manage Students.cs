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
    public partial class Manage_Students : Form
    {
        public Manage_Students()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Manage_Students_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Manage_Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.AdminForm.Show();
            this.Hide();
        }

        private void ListofBooks_Click(object sender, EventArgs e)
        {
            ShowList list = new ShowList();
            list.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser user = new DeleteUser();
            user.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void UpdateUserDetails_Click(object sender, EventArgs e)
        {
            UpdateUser user = new UpdateUser();
            user.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }
    }
}
