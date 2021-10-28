using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicadeexamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            lblimpr.Text = "haif aiiaaa!!!";
        }

        private void btnAdios_Click(object sender, EventArgs e)
        {
            lblMandarSaludo.Text = "aaaaaaaaaaa";
            this.Text = "ashica wata?";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string v = "";
            string tipoedad = "";
            string edad = "";

            if (rbtMenorEdad.Checked == true)
            {
                edad = rbtMenorEdad.Text;


            }

            if (rbtTerceraEdad.Checked == true)
            {
                edad = rbtTerceraEdad.Text;


            }

            if (rbtAdulto.Checked == true)
            {
                edad = rbtAdulto.Text;


            }

           


            if (txtIng.Text == v)
                {

                    lblMandarSaludo.Text="Porfavor introduzca el nombre en la casilla correspondiente";
                   
                }
                else
                {
                    lblMandarSaludo.Text = "hola, " + txtIng.Text + " es tu nombre, ehh? y eres un "+edad;




                    

                }



          
                

                   
            


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBanderaBotonUsado.Text = "";
            lblimpr.Text = "";
            lblRespuestaCalculable.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);

            double b = Convert.ToDouble(txtB.Text);


            double resultado = a + b;

            lblRespuestaCalculable.Text = "La suma de los valores ingresados " + a + " y " + b + " es: " 
                + resultado;

            lbl2.Text = resultado.ToString();
            txtA.Text = resultado.ToString();


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);

            double b = Convert.ToDouble(txtB.Text);


            double resultado = a - b;

            lblRespuestaCalculable.Text = "La resta de los valores ingresados " + a + " y " + b + " es: "
                + resultado;

            lbl2.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);

            double b = Convert.ToDouble(txtB.Text);


            double resultado = a * b;

            lblRespuestaCalculable.Text = "La multiplicacion de los valores ingresados " + a + " y " + b + " es: "
                + resultado;

            lbl2.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);

            double b = Convert.ToDouble(txtB.Text);


            double resultado = a / b;

            lblRespuestaCalculable.Text = "La division de los valores ingresados " + a + " y " + b + " es: "
                + resultado;

            lbl2.Text = resultado.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMostrado_Click(object sender, EventArgs e)
        {
            

            DialogResult señal= MessageBox.Show("presione un boton para probar", "muestra de boton", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if(señal == DialogResult.Yes)
            {

                lblBanderaBotonUsado.Text = "seleccionaste el boton ´Si´";



            }


            if (señal == DialogResult.No)
            {

                lblBanderaBotonUsado.Text = "seleccionaste el boton ´No´";



            }




        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            Form2 CambioForm = new Form2();

            CambioForm.ShowDialog();
        }
    }
}
