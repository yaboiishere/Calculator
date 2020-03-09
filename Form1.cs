using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                label2.Text = (a + b).ToString();
                label4.Text = "";
            }
            catch (FormatException){
                label4.Text = "Моля попълни полетата";
            }
        }

        private void button2_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                label2.Text = (a - b).ToString();
                label4.Text = "";
            }
            catch (FormatException){
                label4.Text = "Моля попълни полетата";
            }
        }

        private void button3_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                label2.Text = (a * b).ToString();
                label4.Text = "";
            }
            catch (FormatException){
                label4.Text = "Моля попълни полетата";
            }
        }

        private void button4_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                label2.Text = (a / b).ToString();
                label4.Text = "";
            }
            catch (FormatException){
                label4.Text = "Моля попълни полетата";
            }
        }
    }
}
