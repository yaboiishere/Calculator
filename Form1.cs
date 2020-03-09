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
                double a = double.Parse(textBox1.Text); //Превръща стойността на textBox1 в double и го запазва в а
                double b = double.Parse(textBox2.Text);//Превръща стойността на textBox12 в double и го запазва в b.
                label2.Text = (a + b).ToString();//Събира a с b, превръща сумата в низ и записва стойността в label2
                label4.Text = "";//Изчиства стойността в label4. Налага се ако вече е натиснат бутон без попълнени данни
            }
            catch (FormatException){//Хваща грешката и изпълнява кода в блока
                label4.Text = "Моля попълни полетата!"; //Изписва грешката в label4
            }
        }

        private void button2_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);//Превръща стойността на textBox1 в double и го запазва в а
                double b = double.Parse(textBox2.Text);//Превръща стойността на textBox12 в double и го запазва в b
                label2.Text = (a - b).ToString();//Изважда b от a , превръща разликата в низ и записва стойността в label2
                label4.Text = "";//Изчиства стойността в label4. Налага се ако вече е натиснат бутон без попълнени данни
            }
            catch (FormatException){//Хваща грешката и изпълнява кода в блока
                label4.Text = "Моля попълни полетата";//Изписва грешката в label4
            }
        }

        private void button3_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);//Превръща стойността на textBox1 в double и го запазва в а
                double b = double.Parse(textBox2.Text);//Превръща стойността на textBox12 в double и го запазва в b
                label2.Text = (a * b).ToString();//Умножава a по b, превръща произведението в низ и записва стойността в label2
                label4.Text = "";//Изчиства стойността в label4. Налага се ако вече е натиснат бутон без попълнени данни
            }
            catch (FormatException){//Хваща грешката и изпълнява кода в блока
                label4.Text = "Моля попълни полетата";//Изписва грешката в label4
            }
        }

        private void button4_Click(object sender, EventArgs e){
            try{
                double a = double.Parse(textBox1.Text);//Превръща стойността на textBox1 в double и го запазва в а
                double b = double.Parse(textBox2.Text);//Превръща стойността на textBox12 в double и го запазва в b
                label2.Text = (a / b).ToString();//Дели a на b, превръща частното в низ и записва стойността в label2
                //Деленето работи, защото числата не са целочислен тип, а реален
                label4.Text = "";//Изчиства стойността в label4. Налага се ако вече е натиснат бутон без попълнени данни
            }
            catch (FormatException){//Хваща грешката и изпълнява кода в блока
                label4.Text = "Моля попълни полетата";//Изписва грешката в label4
            }
        }
    }
}
