using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool sequence = true;
        bool dot1 = true;
        string operation, erased, point1; //erased - stocheaza valorile inserate la ecran
        double number1, number2, result, invsign;

        private void num1_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "1";//afisarea valorii 1 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "1";//afisarea la ecran a mai multor valori de 1
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "2";//afisarea valorii 2 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "2";//afisarea la ecran a mai multor valori de 2
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "3";//afisarea valorii 31 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "3";//afisarea la ecran a mai multor valori de 3
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "4";//afisarea valorii 4 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "4";//afisarea la ecran a mai multor valori de 4
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "5";//afisarea valorii 5 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "5";//afisarea la ecran a mai multor valori de 5
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "6";//afisarea valorii 6 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "6";//afisarea la ecran a mai multor valori de 6
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "7";//afisarea valorii 7 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "7";//afisarea la ecran a mai multor valori de 7
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "8";//afisarea valorii 8 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "8";//afisarea la ecran a mai multor valori de 8
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (sequence == true)
            {
                screen.Text = "";//initial - stergerea ecranului 
                screen.Text = "9";//afisarea valorii 9 la ecran
                sequence = false;
                dot1 = true;
            }
            else
            {
                screen.Text = screen.Text + "9";//afisarea la ecran a mai multor valori de 9
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0")
            {
                return;//returnarea la ecran a valorii 0
            }
            else
            {
                if (sequence == true)
                {
                    screen.Text = "0";
                    dot1 = true;
                }
                else
                {
                    screen.Text = screen.Text + "0";
                }
            }
        }

        //Sfarsitul numerelor calculatorului
        //Inceputul butoanelor pentru operatii

        private void plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            number1 = double.Parse(screen.Text);//valoarea de la ecran il transformam din carater in numar
            sequence = true;//ecranul se curata si se afiseaza alta valoare
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            number1 = double.Parse(screen.Text);
            sequence = true;
        }


        private void div_Click(object sender, EventArgs e)
        {
            operation = "/";
            number1 = double.Parse(screen.Text);
            sequence = true;
        }


        private void mul_Click(object sender, EventArgs e)
        {
            operation = "*";
            number1 = double.Parse(screen.Text);
            sequence = true;
        }



        private void sqrt_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(screen.Text);
            result = Math.Sqrt(number1);
            screen.Text = result.ToString();//afisarea valorii radicalului nr. 
            sequence = true;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(screen.Text);
            result = number1 * number1;
            screen.Text = result.ToString();//afisarea valorii nr. la patrat
            sequence = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            //number2 pentru stocarea valorii de la ecran afisate
            number2 = double.Parse(screen.Text);
            if (operation == "+")//daca operatia este egala cu suma 
            {
                result = number1 + number2;
                screen.Text = result.ToString();
                sequence = true;
            }

            if (operation == "-")//daca operatia este egala cu suma 
            {
                result = number1 - number2;
                screen.Text = result.ToString();
                sequence = true;
            }

            if (operation == "*")//daca operatia este egala cu suma 
            {
                result = number1 * number2;
                screen.Text = result.ToString();
                sequence = true;
            }

            if (operation == "/")//daca operatia este egala cu suma 
            {
                result = number1 / number2;
                screen.Text = result.ToString();
                sequence = true;
            }

        //Sfarsitul butoanelor pentru operatii

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Inceputul butoanelor de stergere

        private void back_Click(object sender, EventArgs e)
        {
            int x = 0;//0
            int y = 0;
            erased = screen.Text;// erased = 788
            point1 = screen.Text;
            x = erased.Length - 1;//x = 2
            y = point1.Length - 1;//25 -> y = 1
            point1 = point1.Substring(y, 1);//
            erased = erased.Substring(0, x);//x - pozitia pina unde se va sterge numarul; x = 78
            //substring - taie o parte din variabila noastra, se sterge ultimul numar; 
            screen.Text = erased;//screen = 78

            if (screen.Text == "")
            {
                screen.Text = "0";
                sequence = true;
            }

            if (screen.Text == "-") {//daca avem numar negativ
                screen.Text = "0";
                sequence = true;
            }
            if (point1 == ",")
            {
                dot1 = true;
            }
        }


        private void erase_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            number1 = 0;
            number2 = 0;
            sequence = true;//ecranul gol
            dot1 = true;
        }
        //EXIT
        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Punctul si inversarea semnelor
        private void point_Click(object sender, EventArgs e)
        {
           if (dot1 == true)
            {
                screen.Text = screen.Text + ",";
                dot1 = false;
            }
           else
            {              
                return;
            }
                sequence = false;
        }
        
        private void sign_Click(object sender, EventArgs e)
        {
            invsign = double.Parse(screen.Text);//25
            invsign = invsign - (invsign * 2);//invsign = 25 - (25 * 2) -> 25 - 50
            screen.Text = invsign.ToString();//invsign = -25, si invers cu un numar negativ
         }
    }
}