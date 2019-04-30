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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
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
            if (!string.IsNullOrWhiteSpace(AgeTextBox.Text))
                UserAge.Text = AgeTextBox.Text;
            if (!string.IsNullOrWhiteSpace(DoBTextBox.Text))
                UserDoB.Text = DoBTextBox.Text;
            if (!string.IsNullOrWhiteSpace(LevelTextBox.Text))
                UserLevel.Text = LevelTextBox.Text;

            EditButton.Visible = true;
            UserAge.Visible = true;
            UserDoB.Visible = true;
            UserLevel.Visible = true;

            UpdateButton.Visible = false;
            AgeTextBox.Visible = false;
            LevelTextBox.Visible = false;
            DoBTextBox.Visible = false;
        }

        //Edit Button
        private void button6_Click(object sender, EventArgs e)
        {
            EditButton.Visible = false;
            UserAge.Visible = false;
            UserDoB.Visible = false;
            UserLevel.Visible = false;

            UpdateButton.Visible = true;
            AgeTextBox.Visible = true;
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

        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowListOfBooks mylist = new ShowListOfBooks();
            mylist.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
