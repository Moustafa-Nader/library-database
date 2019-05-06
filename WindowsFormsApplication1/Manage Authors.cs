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
    public partial class Manage_Authors : Form
    {
        public Manage_Authors()
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

        private void ListofAuthors_Click(object sender, EventArgs e)
        {
            Show_Authors_List list = new Show_Authors_List();
            list.Show();
            this.Hide();
            FormState.PreviousPage = this;

        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            Add_Author a1 = new Add_Author();
            a1.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            Delete_Author a1 = new Delete_Author();
            a1.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void Manage_Authors_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Manage_Authors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.AdminForm.Show();
            this.Hide();

        }
    }
}
