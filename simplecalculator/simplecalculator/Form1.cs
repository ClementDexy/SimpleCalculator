using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(textBox1.Text);
            Double num2 = Convert.ToDouble(textBox2.Text);
            Double result = num1 + num2;
            textBox3.Text = (result).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(textBox1.Text);
            Double num2 = Convert.ToDouble(textBox2.Text);
            Double result = num1 - num2;
            textBox3.Text = (result).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(textBox1.Text);
            Double num2 = Convert.ToDouble(textBox2.Text);
            Double result = num1 * num2;
            textBox3.Text = (result).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Double num1 = Convert.ToDouble(textBox1.Text);
            Double num2 = Convert.ToDouble(textBox2.Text);
            Double result = num1 / num2;
            textBox3.Text = (result).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            treeView1.SelectedNode = null;
            treeView1.TabStop = false;
            treeView1.TabIndex = 2;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (treeView1.SelectedNode == treeView1.Nodes[2])
            {
                treeView1.Focus();
                groupBox2.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

       
    }
}
