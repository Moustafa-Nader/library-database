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
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Add_Book book = new Add_Book();
            book.Show();
        }

        private void ListofBooks_Click(object sender, EventArgs e)
        {
            Show_List list = new Show_List();
            list.Show();
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            Update_Book book = new Update_Book();
            book.Show();
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            Delete_Book book = new Delete_Book();
            book.Show();
        }
    }
}
