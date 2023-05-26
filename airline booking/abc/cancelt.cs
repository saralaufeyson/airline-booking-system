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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace abc
{
    public partial class cancelt : Form
    {
        public cancelt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure you want to cancel the tickets?");
            string passengername = textBox1.Text;
            string source = comboBox1.Text;
            string destination = comboBox2.Text;
            
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            using (SqlCommand command = new SqlCommand("DELETE FROM passenger WHERE passengername=@passengername AND source=@source AND destination=@destination;", conn))
            {
                command.Parameters.AddWithValue("@passengername",passengername );
                command.Parameters.AddWithValue("@source", source);
                command.Parameters.AddWithValue("@destination", destination);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) { MessageBox.Show("ticket cancelled successfully"); }
                else { MessageBox.Show("name not found"); }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewf v1 = new viewf();
            v1.Show();
            this.Close();
        }
    }
}
