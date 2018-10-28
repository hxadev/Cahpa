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
    public partial class FormTrapecialSimetrico : Form
    {
        public FormTrapecialSimetrico()
        {
            InitializeComponent();
        }

        /******************************************
         *          Metodos de calculos           *
         ******************************************/
        public String calcular_Ag(double B, double y, double k)
        {
            return ((B * y) + (k * (Math.Pow(y, 2)))).ToString();
        }

        public String calcular_Pm(double B, double y, double k)
        {
            return (B + (2 * y) * (Math.Sqrt((Math.Pow(k, 2) + 1)))).ToString();
        }

        public String calcular_Asl(double B, double y, double k)
        {
            return (B + (2 * k * y)).ToString();
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
                double bas, tirante, talud;
                bas = double.Parse(textBase.Text);
                tirante = double.Parse(textTirante.Text);
                talud = double.Parse(textTalud.Text);

                textAreaH.Text = calcular_Ag(bas, tirante, talud);
                textPm.Text = calcular_Pm(bas, tirante, talud);
                textAsl.Text = calcular_Asl(bas, tirante, talud);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(bas, tirante, talud)), double.Parse(calcular_Pm(bas, tirante, talud)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(bas, tirante, talud)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textTalud_Leave(object sender, EventArgs e)
        {
            try
            {
                double bas, tirante, talud;
                bas = double.Parse(textBase.Text);
                tirante = double.Parse(textTirante.Text);
                talud = double.Parse(textTalud.Text);

                textAreaH.Text = calcular_Ag(bas, tirante, talud);
                textPm.Text = calcular_Pm(bas, tirante, talud);
                textAsl.Text = calcular_Asl(bas, tirante, talud);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ag(bas, tirante, talud)), double.Parse(calcular_Pm(bas, tirante, talud)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ag(bas, tirante, talud)), tirante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
