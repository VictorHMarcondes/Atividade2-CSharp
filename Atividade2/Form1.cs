using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
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

        private void btnCAL_Click(object sender, EventArgs e)
        {
            // iniciando variavel com valor 0
            double peso = 0;
            double altura = 0;
            double imc= 0;
            //passando valor pra variavel
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
               peso = double.Parse(txtPeso.Text);
               altura = double.Parse(txtAltura.Text);
                
            }
            //CALCULANDO IMC
            if(peso !=0)
            {
                imc = peso / (altura * altura) ;
            }

            //Classificando IMC
            if (imc < 18.5)
            {
                lblResultado.Text = "Abaixo do peso";
                lblResultado.ForeColor = Color.Red;
            }
            else if(imc >= 18.6 && imc <= 24.9)
            {
                lblResultado.Text = "Peso ideal" ;
                lblResultado.ForeColor = Color.Green;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lblResultado.Text = "levemente acima do peso";
                lblResultado.ForeColor = Color.Red;
            }
             else if (imc >= 30 && imc <= 34.9)
            {
                lblResultado.Text = "Obesidade grau I";
                lblResultado.ForeColor = Color.Red;
            }
             else if (imc >= 35 && imc <= 39.9)
            {
                lblResultado.Text = "Obesidade grau II";
                lblResultado.ForeColor = Color.Red;
            }
             else if (imc >= 40 )
            {
                lblResultado.Text = "Obesidade grau III";
                lblResultado.ForeColor = Color.Red;
            }

            //mostrar o valor:
            txtIMC.Text = imc.ToString();
        }
    }
}
