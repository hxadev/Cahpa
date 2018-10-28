using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahpa.PanelElementosGeometricos.Asimetricos
{
    public partial class FormTriangularAsimetrico : Form
    {
        public FormTriangularAsimetrico()
        {
            InitializeComponent();
        }

        /**
         * Metodos de calculos
         * */
        public String calcular_Ag(double k1, double k2, double y)
        {
            return (((k1 * Math.Pow(y, 2)) / 2) + ((k2 * Math.Pow(y, 2)) / 2)).ToString();
        }

        public String calcular_Pm(double k1, double k2, double y)
        {
            return (y * (Math.Sqrt(Math.Pow(k1, 2) + 1) + (Math.Sqrt(Math.Pow(k1, 2) + 1)))).ToString();
        }

        public String calcular_Asl(double k1, double k2, double y)
        {
            return ((k1 * y) + (k2 * y)).ToString();
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
                double tirante, talud1, talud2;
                tirante = Double.Parse(textTirante.Text);
                talud1 = Double.Parse(textTalud1.Text);
                talud2 = Double.Parse(textTalud2.Text);

                //Otorgando valores a los campos de texto
                textAreaH.Text = calcular_Ag(talud1, talud2, tirante);
                textPm.Text = calcular_Pm(talud1, talud2, tirante);
                textAsl.Text = calcular_Asl(talud1, talud2, tirante);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(talud1, talud2, tirante)), double.Parse(calcular_Pm(talud1, talud2, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(talud1, talud2, tirante)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textTalud2_Leave(object sender, EventArgs e)
        {
            try
            {
                double tirante, talud1, talud2;
                tirante = Double.Parse(textTirante.Text);
                talud1 = Double.Parse(textTalud1.Text);
                talud2 = Double.Parse(textTalud2.Text);

                //Otorgando valores a los campos de texto
                textAreaH.Text = calcular_Ag(talud1, talud2, tirante);
                textPm.Text = calcular_Pm(talud1, talud2, tirante);
                textAsl.Text = calcular_Asl(talud1, talud2, tirante);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(talud1, talud2, tirante)), double.Parse(calcular_Pm(talud1, talud2, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(talud1, talud2, tirante)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
