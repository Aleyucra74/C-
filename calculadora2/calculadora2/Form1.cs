using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaracao de variaveis
        double numero1, numero2, resultado;
        int operacao=1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)//verifica se esta habilitado
            {
                operacao = 1;//alimenta a variavel com valor
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                operacao = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                operacao = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                operacao = 4;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text);// importa valor do formulario
            numero2 = double.Parse(textBox2.Text);// conversao de string para double 
            
            if(operacao==1) //cadeia de condicoes if else
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();//exportar valor para formulario como texto
            }
            else if(operacao==2)
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }
            else if(operacao==3)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }
            else if(operacao==4)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Não existe divisão com 0");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    resultado = numero1 / numero2;
                    textBox3.Text = resultado.ToString();
                }
            }         
        }
    }
}