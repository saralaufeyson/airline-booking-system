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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source =LAZY-SHIKA03\\SQLEXPRESS;Initial Catalog = airline; Integrated Security = True ";
            SqlConnection conn = new SqlConnection(connString);
            string username = textBox1.Text;
            string password = textBox2.Text;
            conn.Open();
            using (SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE [Username] = @UserName AND [Password] = @Password", conn))
            {
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("you are logged in..navigating to all fights");
                        viewf v = new viewf();
                        v.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("incorrect credntials. try again");
                    }
                }
            }
        }
    }
}
