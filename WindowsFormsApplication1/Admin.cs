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
        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {
            Manage_Students s1 = new Manage_Students();
            s1.Show();
        }

        private void ManageAuthors_Click(object sender, EventArgs e)
        {
            Manage_Authors a1 = new Manage_Authors();
            a1.Show();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            Add_Admin a1 = new Add_Admin();
            a1.Show();
        }
    }
}
