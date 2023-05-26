using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc
{
    public partial class viewf : Form
    {
        public viewf()
        {
            InitializeComponent();
        }

        private void viewf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet1.viewf' table. You can move, or remove it, as needed.
            this.viewfTableAdapter.Fill(this.airlineDataSet1.viewf);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login l=new login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookt bb=new bookt();
            bb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelt t=new cancelt();
            t.Show();
            this.Hide();
        }
    }
}
