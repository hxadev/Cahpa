using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahpa.PanelTiranteNormal
{
    public partial class FormTiranteNormal : Form
    {
        public int xClick = 0, yClick = 0;
        public FormTiranteNormal()
        {
            InitializeComponent();
        }

        private void abrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void ActionBar_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnRectangularTn_Click(object sender, EventArgs e)
        {
            abrirFormulario<SeccionRectangular.SeccionRectangularTn>();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
