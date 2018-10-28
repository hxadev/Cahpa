using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahpa.PanelTiranteNormal.SeccionRectangular
{
    public partial class SeccionRectangularTn : Form
    {
        TiranteNormal tiranteN;
        public SeccionRectangularTn()
        {
            InitializeComponent();
            
        }

        private void textTiranteN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                /*double n = Double.Parse(textRugosidad.Text);
                double Q = Double.Parse(textGasto.Text);
                double b = Double.Parse(textBase.Text);
                double s = Double.Parse(textPendiente.Text);
                tiranteN = new TiranteNormal(n,Q,b,s);
                double resultado = tiranteN.tiranteNormalRectangular();
                textTiranteN.Text = resultado.ToString("0.######");*/

                if (textTalud1.Text == "" && textTalud2.Text == "")
                {
                    textTalud1.Text = "0"; textTalud2.Text = "0";
                    labelTirante.Text = "Tirante Rectangular";
                }
                if (textBase.Text == "")
                {
                    textBase.Text = "0";
                    labelTirante.Text = "Tirante Triangular";
                }
                else if (!textTalud1.Text.Equals(textTalud2.Text)) {
                    labelTirante.Text = "Tirante Trapecial Asimetrico";
                }else if(textTalud1.Text.Equals(textTalud2.Text))
                {
                    labelTirante.Text = "Tirante Trapecial Simetrico";
                }else if(!textTalud1.Text.Equals(textTalud2.Text) && textBase.Text == "")
                {
                    textBase.Text = "0";
                    labelTirante.Text = "Tirante Triangular Asimetrico";
                }
                else if (textTalud1.Text.Equals(textTalud2.Text) && textBase.Text == "")
                {
                    textBase.Text = "0";
                    labelTirante.Text = "Tirante Triangular Simetrico";
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show("No haz introducido ningun valor");
            }
        }

        private void tablaDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
