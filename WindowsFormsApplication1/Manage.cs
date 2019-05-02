using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managestud
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShowList sl = new ShowList();
            sl.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser();
            du.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UpdateUser uu = new UpdateUser();
            uu.Show();
        }
    }
}
