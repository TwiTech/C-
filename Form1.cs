using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "test";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // read the fist number 
            int num1 = Convert.ToInt32(textBox1.Text);
            
            //read the second number 

            int num2 = Convert.ToInt32(textBox2.Text);
            // read the third num
            int num3 = num1 + num2;

            //display result in the textbox
            textBox3.Text = num3.ToString();
        }
    }
}
