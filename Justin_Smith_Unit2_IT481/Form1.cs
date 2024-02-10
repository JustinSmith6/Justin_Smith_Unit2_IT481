using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Justin_Smith_Unit2_IT481
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data source = (local)\SQLEXPRESS01; Initial Catalog=Northwind; Integrated Security=True;");
            connection.Open();
            ConnectionBox.Text = "Retrieving records...";
            command.Connection = connection;
            command.CommandText = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            ConnectionBox.Text = "Connection Successfull";
            connection.Close();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            ConnectionBox.Text = "Starting Up...";
            try
            {
                SqlConnection connection = new SqlConnection(@"Data source = (local)\SQLEXPRESS01; Initial Catalog=Northwind; Integrated Security=True;");
                connection.Open();
                ConnectionBox.Text = "Connection Successful";
                connection.Close();
            }catch (Exception ex)
            {
                ConnectionBox.Text = "Error, " + ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RecordCount_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data source = (local)\SQLEXPRESS01; Initial Catalog=Northwind; Integrated Security=True;");
            connection.Open();
            ConnectionBox.Text = "Counting Records...";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            ConnectionBox.Text = "Number of Records: " + count;
            connection.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
