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
    public partial class StudentRentBooks : Form
    {
        int index = 0;
        SqlConnection con = new SqlConnection(connectionstring.myconnectionstring);
        SqlCommand comm = new SqlCommand();
        object temp;

        public StudentRentBooks()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            List<string> ComboList = new List<string>() { "ISBN", "Book Name" , "Publisher" };
            SearchOptionList.DataSource = ComboList;
            comm.Connection = con;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cell = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ISBN"].FormattedValue.ToString());
            //getting the value of book ISBN.
            con.Open();

            comm.CommandText = "select BOOKNAME from BOOK where ISBN = " + cell;
            temp = comm.ExecuteScalar();
            string Message = "Do you want to rent " + temp.ToString() + "?";
            DialogResult T = MessageBox.Show(Message, "Confirm", MessageBoxButtons.YesNo);
            if(T == DialogResult.Yes)
            {
                comm.CommandText = "Select Student.Student_ID from Student,rents " +
                    "where STUDENT.STUDENT_ID = RENTS.STUDENT_ID " +
                    "and STUDENT.STUDENT_ID = " + FormState.mainform.SignInID + "and ISBN = " + cell;
                temp = comm.ExecuteScalar();
                //Console.WriteLine(temp.ToString());
                if (temp != null)
                    MessageBox.Show("You Already Rented this Book","Already Exists");
                else
                {
                    comm.CommandText = "Insert into Rents values ( " + cell + " , " + FormState.mainform.SignInID + " )";
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Please receive your book");
                }
            }

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void RentedBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = SearchOptionList.SelectedIndex;
            Console.WriteLine(index);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                MessageBox.Show("Please enter value.");
            else if(index == 0)
            {
                comm.CommandText = "SELECT BOOK.ISBN,BOOK.BOOKNAME AS BookName,BOOK.PUBLICATIONDATE AS PublicationDate,AUTHORS.AUTHORFIRSTNAME as Author,  CATEGORY.CATEGORYNAME As Category , PUBLISHER as Publisher  " +
                    "FROM BOOK JOIN BOOKCATEGORIES ON BOOK.ISBN = BOOKCATEGORIES.ISBN JOIN CATEGORY ON BOOKCATEGORIES.CATEGORY_ID = CATEGORY.CATEGORY_ID JOIN AUTHORS ON BOOK.AUTHOR_ID = AUTHORS.AUTHOR_ID " +
                    "where BOOK.ISBN = " + SearchTextBox.Text;

                con.Open();
                SqlDataAdapter myadapter = new SqlDataAdapter(comm);
                DataTable mytable = new DataTable();
                myadapter.Fill(mytable);
                dataGridView1.DataSource = mytable;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
                con.Close();
            }
            else if(index == 1)
            {
                comm.CommandText = "SELECT BOOK.ISBN,BOOK.BOOKNAME AS BookName,BOOK.PUBLICATIONDATE AS PublicationDate,AUTHORS.AUTHORFIRSTNAME as Author,  CATEGORY.CATEGORYNAME As Category , PUBLISHER as Publisher  " +
                    "FROM BOOK JOIN BOOKCATEGORIES ON BOOK.ISBN = BOOKCATEGORIES.ISBN JOIN CATEGORY ON BOOKCATEGORIES.CATEGORY_ID = CATEGORY.CATEGORY_ID JOIN AUTHORS ON BOOK.AUTHOR_ID = AUTHORS.AUTHOR_ID " +
                    "where BOOK.BOOKNAME like '%" + SearchTextBox.Text + "%'";

                con.Open();
                SqlDataAdapter myadapter = new SqlDataAdapter(comm);
                DataTable mytable = new DataTable();
                myadapter.Fill(mytable);
                dataGridView1.DataSource = mytable;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
                con.Close();
            }
            else if(index == 2)
            {
                comm.CommandText = "SELECT BOOK.ISBN,BOOK.BOOKNAME AS BookName,BOOK.PUBLICATIONDATE AS PublicationDate,AUTHORS.AUTHORFIRSTNAME as Author,  CATEGORY.CATEGORYNAME As Category, PUBLISHER as Publisher " +
                                    "FROM BOOK JOIN BOOKCATEGORIES ON BOOK.ISBN = BOOKCATEGORIES.ISBN JOIN CATEGORY ON BOOKCATEGORIES.CATEGORY_ID = CATEGORY.CATEGORY_ID JOIN AUTHORS ON BOOK.AUTHOR_ID = AUTHORS.AUTHOR_ID " +
                                    "where BOOK.Publisher like '%" + SearchTextBox.Text + "%'";

                con.Open();
                SqlDataAdapter myadapter = new SqlDataAdapter(comm);
                DataTable mytable = new DataTable();
                myadapter.Fill(mytable);
                dataGridView1.DataSource = mytable;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount) - 1;
                con.Close();
            }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            
        }
    }

}
