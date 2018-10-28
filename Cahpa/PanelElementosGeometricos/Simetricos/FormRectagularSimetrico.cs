using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahpa.PanelElementosGeometricos
{
    public partial class FormRectagularSimetrico : Form
    {
        public FormRectagularSimetrico()
        {
            InitializeComponent();
        }

        public String calcular_Ag(double B, double y)
        {
            return (B * y).ToString();
        }

        public String calcular_Pm(double B, double y)
        {
            return (B + (2 * y)).ToString();
        }

        public String calcular_Asl(double B)
        {
            return B.ToString();
        }

        public String calcular_Rh(double A, double P)
        {
            return (A / P).ToString();
        }

        public String calcular_Tm(double A, double T)
        {
            return (A / T).ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double bas, tirante;
                bas = double.Parse(textBase.Text);
                tirante = double.Parse(textTirante.Text);

                //Otorgando valores a los campos de texto
                textAreaH.Text = calcular_Ag(bas, tirante);
                textPm.Text = calcular_Pm(bas, tirante);
                textAsl.Text = calcular_Asl(bas);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(bas, tirante)), double.Parse(calcular_Pm(bas, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(bas, tirante)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No haz introducido ningun valor");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBox[] txtArray = new TextBox[7];
            txtArray[0] = textBase;
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

        private void textTirante_Leave(object sender, EventArgs e)
        {
            try
            {
                double bas, tirante;
                bas = double.Parse(textBase.Text);
                tirante = double.Parse(textTirante.Text);

                //Otorgando valores a los campos de texto
                textAreaH.Text = calcular_Ag(bas, tirante);
                textPm.Text = calcular_Pm(bas, tirante);
                textAsl.Text = calcular_Asl(bas);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(bas, tirante)), double.Parse(calcular_Pm(bas, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(bas, tirante)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha introducido ningun valor");
            }
        }
    }
}
