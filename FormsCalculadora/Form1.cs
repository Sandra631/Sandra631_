using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean secuencia = true;
        string operacion, borrado;
        double variable1, variable2, resultado;

 
        //Apartado de los números.
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if(secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "1";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "1";
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "2";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "3";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "3";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "4";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "5";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "5";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "6";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "7";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "8";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtBoxVentana.Text = "";
                txtBoxVentana.Text = "9";
                secuencia = false;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "9";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txtBoxVentana.Text == "0")
            {
                return;
            }
            else
            {
                txtBoxVentana.Text = txtBoxVentana.Text + "0";
            }
        }
        //Fin del apartado de los números

        //Apartado de Operadores
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            variable1 = double.Parse(txtBoxVentana.Text);
            secuencia = true;
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            variable1 = double.Parse(txtBoxVentana.Text);
            secuencia = true;
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            variable1 = double.Parse(txtBoxVentana.Text);
            secuencia = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            variable1 = double.Parse(txtBoxVentana.Text);
            secuencia = true;
        }

        private void btnExponenciacion_Click(object sender, EventArgs e)
        {
            variable1 = double.Parse(txtBoxVentana.Text);
            resultado = variable1 * variable1;
            txtBoxVentana.Text = resultado.ToString();
            secuencia = true;
        }

        private void btnRadicacion_Click(object sender, EventArgs e)
        {
            variable1 = double.Parse(txtBoxVentana.Text);
            resultado = Math.Sqrt(variable1);
            txtBoxVentana.Text = resultado.ToString();
            secuencia = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            variable2 = double.Parse(txtBoxVentana.Text);
            if (operacion == "+")
            {
                resultado = variable1 + variable2;
                txtBoxVentana.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = variable1 - variable2;
                txtBoxVentana.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = variable1 * variable2;
                txtBoxVentana.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = variable1 / variable2;
                txtBoxVentana.Text = resultado.ToString();
                secuencia = true;
            }
        }
        //Fin del apartado de Operadores.

        //Apartado de operaciones especiales
        private void btnClearTextBox_Click(object sender, EventArgs e)
        {
            txtBoxVentana.Text = "0";
            variable1 = 0;
            variable2 = 0;
            secuencia = true;
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            int x;
            borrado = txtBoxVentana.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            txtBoxVentana.Text = borrado;

            if (txtBoxVentana.Text == "")
            {
                txtBoxVentana.Text = "0";
                secuencia = true;
            }
            if(txtBoxVentana.Text== "-")
            {
                txtBoxVentana.Text = "0";
                secuencia = true;
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin del Apartado de Operadores Especiales.

    }
}
