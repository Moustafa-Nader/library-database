using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class BrowseBook : Form
    {
        public BrowseBook()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void BrowseBook_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string str = "";
           // string isbnstr = ISBN.Text;
            if (ISBN.Text != "") str = "where BOOK.ISBN like '%" + ISBN.Text + "%'";

            if (BOOKNAME.Text != "" && str=="") str = "where BOOK.BOOKNAME like '%" + BOOKNAME.Text + "%'";
            else if (BOOKNAME.Text != "" && str != "") str += " and BOOK.BOOKNAME like '%" + BOOKNAME.Text + "%'";

            if (PUBLICATIONDATE.Text != "" && str == "") str = "where BOOK.PUBLICATIONDATE like '%" + PUBLICATIONDATE.Text + "%'";
            else if (PUBLICATIONDATE.Text != "" && str != "") str += " and BOOK.PUBLICATIONDATE like '%" + PUBLICATIONDATE.Text + "%'";


            if (AUTHORNAME.Text != "" && str == "") str = "where AUTHORS.AUTHORFIRSTNAME like '%" + AUTHORNAME.Text + "%'";
            else if (AUTHORNAME.Text != "" && str != "") str += " and AUTHORS.AUTHORFIRSTNAME like '%" + AUTHORNAME.Text + "%'";

            
            if (CATEGORYNAME.Text != "" && str == "") str = "where CATEGORY.CATEGORYNAME like '%" + CATEGORYNAME.Text + "%'";
            else if (CATEGORYNAME.Text != "" && str != "") str += " and CATEGORY.CATEGORYNAME like '%" + CATEGORYNAME.Text + "%'";

            string queu = "SELECT BOOK.ISBN,BOOK.BOOKNAME AS BookName,BOOK.PUBLICATIONDATE AS PublicationDate,AUTHORS.AUTHORFIRSTNAME as Author,  CATEGORY.CATEGORYNAME As Category FROM BOOK JOIN BOOKCATEGORIES ON BOOK.ISBN = BOOKCATEGORIES.ISBN JOIN CATEGORY ON BOOKCATEGORIES.CATEGORY_ID = CATEGORY.CATEGORY_ID JOIN AUTHORS ON BOOK.AUTHOR_ID = AUTHORS.AUTHOR_ID ";
            string qu = "select * from BOOK";
			SqlConnection myconnection = new SqlConnection(connectionstring.myconnectionstring);
			SqlCommand mycommand = new SqlCommand(queu+str,myconnection);
            myconnection.Open();
            SqlDataAdapter myadapter = new SqlDataAdapter(mycommand);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            dataGridView1.DataSource = mytable;
            myconnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BrowseBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
