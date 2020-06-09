using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massiv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // переход на главную форму
        {
            Form2.ActiveForm.Hide();

            Form1 frm1 = new Form1();

            frm1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)// справка и примечание разработчика
        {

        }

        private void канепрголToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
