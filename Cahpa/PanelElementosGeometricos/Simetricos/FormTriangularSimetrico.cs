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
    public partial class FormTriangularSimetrico : Form
    {
        public FormTriangularSimetrico()
        {
            InitializeComponent();
        }

        /**
        * Metodos de calculos
        * */
        public String calcular_Ah(double k, double y)
        {
            return (k * Math.Pow(y, 2)).ToString();
        }

        public String calcular_Pm(double k, double y)
        {
            return (2 * y * (Math.Sqrt((Math.Pow(k, 2) + 1)))).ToString();
        }

        public String calcular_Asl(double k, double y)
        {
            return (2 * (k * y)).ToString();
        }

        public String calcular_Rh(double A, double P)
        {
            return (A / P).ToString();
        }

        public String calcular_Tm(double A, double T)
        {
            return (A / T).ToString();
        }

        private void btnCalcular_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                double tirante, talud, area, tiranteM;
                tirante = double.Parse(textTirante.Text);
                talud = double.Parse(textTalud.Text);

                textAreaH.Text = calcular_Ah(talud, tirante);
                textPm.Text = calcular_Pm(talud, tirante);
                textAsl.Text = calcular_Asl(talud, tirante);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ah(talud, tirante)), double.Parse(calcular_Pm(talud, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ah(talud, tirante)), talud);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha introducido ningun valor");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBox[] txtArray = new TextBox[7];
            txtArray[0] = textTalud;
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

        private void textTalud_Leave(object sender, EventArgs e)
        {
            try
            {
                double tirante, talud, area, tiranteM;
                tirante = double.Parse(textTirante.Text);
                talud = double.Parse(textTalud.Text);

                textAreaH.Text = calcular_Ah(talud, tirante);
                textPm.Text = calcular_Pm(talud, tirante);
                textAsl.Text = calcular_Asl(talud, tirante);
                textRh.Text = calcular_Rh(double.Parse(calcular_Ah(talud, tirante)), double.Parse(calcular_Pm(talud, tirante)));
                textTm.Text = calcular_Tm(double.Parse(calcular_Ah(talud, tirante)), talud);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha Ocurrido algun error!");
            }
        }
    }
}
