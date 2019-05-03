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
    public partial class RentedBooks : Form
    {
        public RentedBooks()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 100);
            string Query = "select BOOKNAME as [Book Name],AUTHORFIRSTNAME as Author,PUBLISHER as Publisher " +
                           "from RENTS, BOOK, STUDENT, AUTHORS " +
                           "where RENTS.ISBN = BOOK.ISBN and " +
                           "STUDENT.STUDENT_ID = RENTS.STUDENT_ID and " +
                           "BOOK.AUTHOR_ID = AUTHORS.AUTHOR_ID " +
                           "and STUDENT.STUDENT_ID = " + FormState.mainform.SignInID;
			SqlConnection con = new SqlConnection(connectionstring.myconnectionstring);
			SqlCommand comm = new SqlCommand(Query, con);  //need to rename the Query Column Headings.....
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = (dataGridView1.Width / dataGridView1.ColumnCount);  // Dividing the Width of the DataGrid on the number of Columns Produced

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
    }
}
