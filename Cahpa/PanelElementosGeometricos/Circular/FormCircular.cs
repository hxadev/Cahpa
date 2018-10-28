using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahpa.PanelElementosGeometricos.Circular
{
    public partial class FormCircular : Form
    {

        private double diametro;
        private double tetha;
        private double tirante;

        public FormCircular()
        {
            InitializeComponent();
            labelTirante.Text = "Diametro (d" + "\x2080" + ")";
            labelAngulo.Text = "Angulo(\u03B8)";
        }

        /**
      * Metodos de calculos
      * */
        public String calcular_Ag(double d, double tetha)
        {
            return (((tetha - Math.Sin(tetha)) * Math.Pow(d, 2)) / 8).ToString();
        }

        public String calcular_Pm(double d, double tetha)
        {
            return ((tetha * d) / 2).ToString();
        }

        public String calcular_Asl(double d, double tetha)
        {
            return ((Math.Sin(tetha / 2)) * d).ToString();
        }

        public String calcular_Rh(double d, double tetha)
        {
            return (((1 - (Math.Sin(tetha) / tetha)) * d) / 4).ToString();
        }

        public String calcular_Tm(double d, double tetha)
        {
            return ((((tetha - Math.Sin(tetha)) / (Math.Sin(tetha / 2))) * diametro) / 8).ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double diametro, tetha;

                diametro = this.diametro;
                tetha = this.tetha;

                //Otorgando valores a los campos de texto
                textAreaH.Text = calcular_Ag(this.diametro, this.tetha);
                textPm.Text = calcular_Pm(this.diametro, this.tetha);
                textAsl.Text = calcular_Asl(this.diametro, this.tetha);
                textRh.Text = calcular_Rh(this.diametro, this.tetha);
                textTm.Text = calcular_Tm(this.diametro, this.tetha);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }
        }

        private void textDiametro_Leave(object sender, EventArgs e)
        {
            this.diametro = Double.Parse(textDiametro.Text);
        }

        private void textTirante_Leave(object sender, EventArgs e)
        {
            if (Double.Parse(textTirante.Text) > this.diametro)
            {
                MessageBox.Show("El tirante no puede ser mayor que el diametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textTirante.Text = "";
                textDiametro.Text = "";
                textTetha.Text = "";
                textDiametro.TabIndex = 1;
            }
            else
            {
                this.tirante = Double.Parse(textTirante.Text);
            }
        }

        private void textTetha_Enter(object sender, EventArgs e)
        {
            String anguloFinal;
            anguloFinal = ((this.diametro * ((Math.Acos(1 - (this.diametro * this.tirante) / 2))))).ToString();
            textTetha.Text = anguloFinal;
            this.tetha = Double.Parse(textTetha.Text);
        }

        public void limpiarCampos()
        {
            TextBox[] txtArray = new TextBox[7];
            txtArray[0] = textTetha;
            txtArray[1] = textTirante;
            txtArray[2] = textAreaH;
            txtArray[3] = textPm;
            txtArray[4] = textAsl;
            txtArray[5] = textRh;
            txtArray[6] = textTm;

            for (int i = 0; i < txtArray.Length; i++)
            {
                txtArray[i].Text = "";
            }
        }

        private void textTetha_Leave(object sender, EventArgs e)
        {
            try
            {
                double diametro, tetha, tirante;

                diametro = this.diametro;
                tetha = this.tetha;
                tirante = this.tirante;

                if (tirante > diametro)
                {
                    MessageBox.Show("El tirante no puede ser mayor que el diametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textDiametro.Text = "";
                    textTirante.Text = "";
                    textTetha.Text = "";

                }
                else
                {
                    //Otorgando valores a los campos de texto
                    textAreaH.Text = calcular_Ag(this.diametro, this.tetha);
                    textPm.Text = calcular_Pm(this.diametro, this.tetha);
                    textAsl.Text = calcular_Asl(this.diametro, this.tetha);
                    textRh.Text = calcular_Rh(this.diametro, this.tetha);
                    textTm.Text = calcular_Tm(this.diametro, this.tetha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
