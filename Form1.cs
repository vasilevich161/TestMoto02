using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMoto02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Control control = button1.Parent;
            //присваиваем свои значения
            String Wat =  textBox1.Text;
            String Volt = textBox2.Text;
            String Cosn = textBox3.Text;
            String Kpd =  textBox4.Text;
            CalculiatorTOKA calculiator1 = new CalculiatorTOKA();
            {
               label4.Text = calculiator1.CalculiatorT(Wat, Volt, Cosn, Kpd) + "  A";

            }
        }

         private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "380";
            textBox3.Text = "0,8";
            textBox4.Text = "75";
            label4.Text = "";
        }
    }
}
