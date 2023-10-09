using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_App_TEST_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorProvider1.SetError(textBox1, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(richTextBox1.Text.Trim())))
            {
                errorProvider1.SetError(richTextBox1, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(richTextBox2.Text.Trim())))
            {
                errorProvider1.SetError(richTextBox2, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox2.Text.Trim())))
            {
                errorProvider1.SetError(textBox2, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(richTextBox3.Text.Trim())))
            {
                errorProvider1.SetError(richTextBox3, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(richTextBox4.Text.Trim())))
            {
                errorProvider1.SetError(richTextBox4, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox3.Text.Trim())))
            {
                errorProvider1.SetError(textBox3, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox4.Text.Trim())))
            {
                errorProvider1.SetError(textBox4, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox5.Text.Trim())))
            {
                errorProvider1.SetError(textBox5, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox6.Text.Trim())))
            {
                errorProvider1.SetError(textBox6, "Required field");
                return;
            }
            else if ((string.IsNullOrEmpty(textBox7.Text.Trim())))
            {
                errorProvider1.SetError(textBox7, "Required field");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
                errorProvider1.SetError(richTextBox1, string.Empty);
                errorProvider1.SetError(richTextBox2, string.Empty);
                errorProvider1.SetError(textBox2, string.Empty);
                errorProvider1.SetError(richTextBox3, string.Empty);
                errorProvider1.SetError(richTextBox4, string.Empty);
                errorProvider1.SetError(textBox3, string.Empty);
                errorProvider1.SetError(textBox4, string.Empty);
                errorProvider1.SetError(textBox5, string.Empty);
                errorProvider1.SetError(textBox6, string.Empty);
                errorProvider1.SetError(textBox7, string.Empty);
            }

            Form2 f2 = new Form2();
            f2.Show();

        }

         public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }     
    }
}
