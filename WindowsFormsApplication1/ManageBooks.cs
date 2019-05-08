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
    public partial class ManageBooks : Form
    {
        public ManageBooks()
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

        private void AddBook_Click(object sender, EventArgs e)
        {
            Add_Book book = new Add_Book();
            book.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void ListofBooks_Click(object sender, EventArgs e)
        {
            Show_List list = new Show_List();
            list.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            Update_Book book = new Update_Book();
            book.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            Delete_Book book = new Delete_Book();
            book.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        

        private void ManageBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormState.AdminForm.Show();
            this.Hide();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            BookReport f = new BookReport();
            f.Show();
            Hide();
            FormState.PreviousPage = this;
        }
    }
}
