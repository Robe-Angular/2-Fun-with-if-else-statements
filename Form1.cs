using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Fun_with_if_else_statements
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if(label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("The box is not checked");
            }

            String result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();

            int x = 0;
            while(x < 4)
            {
                result = result + e1.hello() + "\n";
                e1.count = e1.count + 1;
                if(x == 4)
                {
                    e2.count = e2.count + 1;
                }
                if(x < 4)
                {
                    e2.count = e2.count + e1.count;
                }
                x = x + 1;
            }
            MessageBox.Show(result + "Count: " + e2.count);
        }
        public class Echo
        {
            public int count = 0;

            public string hello()
            {
                return "hello...";
            }
        }
    }
}
