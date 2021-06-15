using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you have given input in "+cmb1.SelectedItem.ToString());

        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Result will be in "+cmb2.SelectedItem.ToString());

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
            double final;

            if ((cmb1.SelectedItem.ToString() == "KB") && (cmb2.SelectedItem.ToString() == "MB"))
            {
                final = val / 1024;
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "KB") && (cmb2.SelectedItem.ToString() == "GB"))
            {
                final = val / (1024 * 1024);//e=2.712828
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "KB") && (cmb2.SelectedItem.ToString() == "TB"))
            {
                final = val / (1024 * 1024 * 1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "MB") && (cmb2.SelectedItem.ToString() == "KB"))
            {
                final = val * (1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "MB") && (cmb2.SelectedItem.ToString() == "GB"))
            {
                final = val / (1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "MB") && (cmb2.SelectedItem.ToString() == "TB"))
            {
                final = val / (1024 * 1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "GB") && (cmb2.SelectedItem.ToString() == "KB"))
            {
                final = val * (1024 * 1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "GB") && (cmb2.SelectedItem.ToString() == "MB"))
            {
                final = val * (1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "GB") && (cmb2.SelectedItem.ToString() == "TB"))
            {
                final = val / (1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "TB") && (cmb2.SelectedItem.ToString() == "KB"))
            {
                final = val * (1024 * 1024 * 1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "TB") && (cmb2.SelectedItem.ToString() == "MB"))
            {
                final = val * (1024 * 1024);
                textBox2.Text = final.ToString();

            }
            else if ((cmb1.SelectedItem.ToString() == "TB") && (cmb2.SelectedItem.ToString() == "GB"))
            {
                final = val * (1024);
                textBox2.Text = final.ToString();

            }
            else
                MessageBox.Show("select byte format");
            
        }
    }
}
