using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace abc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet.viewf' table. You can move, or remove it, as needed.
            this.viewfTableAdapter.Fill(this.airlineDataSet.viewf);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("connected");
                login l= new login();
                l.Show();
                this.Hide();


            }
            catch (Exception ex) { MessageBox.Show("error"); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("connected");
                login l = new login();
                l.Show();
                this.Hide();


            }
            catch (Exception ex) { MessageBox.Show("error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("connected");
                login l = new login();
                l.Show();
                this.Hide();


            }
            catch (Exception ex) { MessageBox.Show("error"); }
        }
    }
}
