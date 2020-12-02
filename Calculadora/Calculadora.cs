using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CALCULADORA : Form
        

    {
        public static double Fac (int num)
        {
            if (num == 0 || num == 1)
                return 1;
                    return num * Fac(num - 1);
        }
       double cantidad1;
        double cantidad2;
        double resultado;
        double memoria;
        string operador;
        int num;
        Boolean inicio;
       
       
        public CALCULADORA()
            
        {
            InitializeComponent();
        }
        
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + ".";
            btnpunto.Enabled = false;
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            cantidad1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            cantidad1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            cantidad1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            cantidad1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            cantidad2 = double.Parse(txtpantalla.Text);



            switch (operador)
            {
                case "+":
                    resultado = cantidad1 + cantidad2;

                    txtpantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = cantidad1 - cantidad2;

                    txtpantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = cantidad1 * cantidad2;

                    txtpantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = cantidad1 / cantidad2;

                    txtpantalla.Text = resultado.ToString();
                    break;
                
                   
            }
              

            
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = " ";
            txtpantalla.Focus();
        }

        private void btnborrarderecha_Click(object sender, EventArgs e)
        {
            if (txtpantalla.TextLength > 1)
            {
                txtpantalla.Text = txtpantalla.Text.Remove(txtpantalla.Text.Length - 1, 1);
            }
            if (txtpantalla.Text.Length == 1)
            {
                txtpantalla.Text = "0";
                inicio = true;
                
            }

        }
                
           
        

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            double factorial = 1;
            resultado = double.Parse(txtpantalla.Text);

            for (int i = 1; i <= resultado; i++)
            {
                factorial = i * factorial;
            }
            txtpantalla.Text = factorial.ToString();





        }
            





        

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
             cantidad2 = double.Parse(txtpantalla.Text) ;
            resultado = cantidad1 + cantidad2;
            txtpantalla.Text = Convert.ToString((cantidad1 * cantidad2) / 100);
            

        }
    }
}
