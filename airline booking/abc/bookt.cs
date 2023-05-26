using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace abc
{
    public partial class bookt : Form
    {
        public bookt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            viewf vv= new viewf();
            vv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tot=Convert.ToInt32(numericUpDown1.Value)*5000;
            textBox2.Text = tot.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passengername=textBox1.Text;
            string source=comboBox1.Text;
            string destination=comboBox2.Text;
            int n=Convert.ToInt32(numericUpDown1.Value);
            int price = 5000 * n;
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);
           
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO [passenger] ([passengername], [source],[destination],[n],[price]) VALUES (@passengername, @source, @destination,@n,@price)", conn))
                {
                    command.Parameters.AddWithValue("@passengername", passengername);
                    command.Parameters.AddWithValue("@source", source);
                command.Parameters.AddWithValue("@destination", destination);
                command.Parameters.AddWithValue("@n", n);
                command.Parameters.AddWithValue("@price", price);

               // command.ExecuteNonQuery();
                int rowsAffected = command.ExecuteNonQuery();
                if( rowsAffected > 0) { MessageBox.Show("ticket booked successfully"); }
                else { MessageBox.Show("try again"); }

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
