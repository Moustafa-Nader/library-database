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
    public partial class BookReport : Form
    {
        SqlConnection con = new SqlConnection(connectionstring.myconnectionstring);
        SqlCommand comm = new SqlCommand();

        public BookReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            object temp = null;
            comm.Connection = con;
            con.Open();
            // Setting Horror Details
            comm.CommandText = "Select COUNT(d.category_id) as Num " +
                               "from BOOK, BOOKCATEGORIES, CATEGORY d " +
                               "where BOOK.ISBN = BOOKCATEGORIES.ISBN and BOOKCATEGORIES.CATEGORY_ID = d.CATEGORY_ID " + 
                               "group by CATEGORYNAME "+
                               "having CATEGORYNAME = 'Horror'";
            temp = comm.ExecuteScalar();
            label11.Text = temp.ToString();

            comm.CommandText = "Select COUNT(o.CISBN) " +
                               "from( " +
                               "Select distinct  b.ISBN as CISBN, CATEGORYNAME " +
                               "from BOOK b, RENTS r, STUDENT s, CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID) o " +
                               "group by o.CATEGORYNAME " +
                               "having o.CATEGORYNAME = 'Horror'";
            temp = comm.ExecuteScalar();
            label12.Text = temp.ToString();

            comm.CommandText = "Select COUNT(b.ISBN) " +
                               "from BOOK b,RENTS r, STUDENT s , CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID " +
                               "group by CATEGORYNAME " +
                               "having CATEGORYNAME = 'Horror'";
            temp = comm.ExecuteScalar();
            label13.Text = temp.ToString();


            //Setting Fiction Details
            comm.CommandText = "Select COUNT(d.category_id) as Num " +
                               "from BOOK, BOOKCATEGORIES, CATEGORY d " +
                               "where BOOK.ISBN = BOOKCATEGORIES.ISBN and BOOKCATEGORIES.CATEGORY_ID = d.CATEGORY_ID " +
                               "group by CATEGORYNAME " +
                               "having CATEGORYNAME = 'Ficition'";
            temp = comm.ExecuteScalar();
            label21.Text = temp.ToString();

            comm.CommandText = "Select COUNT(o.CISBN) " +
                               "from( " +
                               "Select distinct  b.ISBN as CISBN, CATEGORYNAME " +
                               "from BOOK b, RENTS r, STUDENT s, CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID) o " +
                               "group by o.CATEGORYNAME " +
                               "having o.CATEGORYNAME = 'Ficition'";
            temp = comm.ExecuteScalar();
            label22.Text = temp.ToString();

            comm.CommandText = "Select COUNT(b.ISBN) " +
                               "from BOOK b,RENTS r, STUDENT s , CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID " +
                               "group by CATEGORYNAME " +
                               "having CATEGORYNAME = 'Ficition'";
            temp = comm.ExecuteScalar();
            label23.Text = temp.ToString();

            //Setting Philosophy Details 
            comm.CommandText = "Select COUNT(d.category_id) as Num " +
                               "from BOOK, BOOKCATEGORIES, CATEGORY d " +
                               "where BOOK.ISBN = BOOKCATEGORIES.ISBN and BOOKCATEGORIES.CATEGORY_ID = d.CATEGORY_ID " +
                               "group by CATEGORYNAME " +
                               "having CATEGORYNAME = 'Philosophy'";
            temp = comm.ExecuteScalar();
            label31.Text = temp.ToString();

            comm.CommandText = "Select COUNT(o.CISBN) " +
                               "from( " +
                               "Select distinct  b.ISBN as CISBN, CATEGORYNAME " +
                               "from BOOK b, RENTS r, STUDENT s, CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID) o " +
                               "group by o.CATEGORYNAME " +
                               "having o.CATEGORYNAME = 'Philosophy'";
            temp = comm.ExecuteScalar();
            label32.Text = temp.ToString();

            comm.CommandText = "Select COUNT(b.ISBN) " +
                               "from BOOK b,RENTS r, STUDENT s , CATEGORY c, BOOKCATEGORIES bc " +
                               "where b.ISBN = r.ISBN and s.STUDENT_ID = r.STUDENT_ID and b.ISBN = bc.ISBN and bc.CATEGORY_ID = c.CATEGORY_ID " +
                               "group by CATEGORYNAME " +
                               "having CATEGORYNAME = 'Philosophy'";
            temp = comm.ExecuteScalar();
            label33.Text = temp.ToString();

            // Setting Totals
            comm.CommandText = "select count(ISBN) from Book";
            temp = comm.ExecuteScalar();
            Totals1.Text = temp.ToString();

            comm.CommandText = "Select count(distinct isbn) from RENTS";
            temp = comm.ExecuteScalar();
            Total2.Text = temp.ToString();

            comm.CommandText = "select count(ISBN) from rents";
            temp = comm.ExecuteScalar();
            Totals3.Text = temp.ToString();

            con.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Totals2.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            
        }

        private void RentedBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UML_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RowTitle1_Click(object sender, EventArgs e)
        {

        }

        private void RowTitle2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
