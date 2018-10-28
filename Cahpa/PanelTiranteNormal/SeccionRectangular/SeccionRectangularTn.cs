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
                double n = Double.Parse(textRugosidad.Text);
                double Q = Double.Parse(textGasto.Text);
                double b = Double.Parse(textBase.Text);
                double s = Double.Parse(textPendiente.Text);
                tiranteN = new TiranteNormal(n,Q,b,s);
                double resultado = tiranteN.tiranteNormalRectangular();
                
                textTiranteN.Text = resultado.ToString("0.######");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No haz introducido ningun valor");
            }
        }
    }
}
