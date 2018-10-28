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
    public partial class FormElementosGeometricos : Form
    {
        public int xClick = 0, yClick = 0;

        public FormElementosGeometricos()
        {
            InitializeComponent();
        }

        //Metodo abrir un formulario dentro del panel
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



        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionBar_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }

        private void btnRecSim_MouseClick(object sender, MouseEventArgs e)
        {
            abrirFormulario<FormRectagularSimetrico>();
        }

        private void btnTriSim_Click(object sender, EventArgs e)
        {
            abrirFormulario<FormTriangularSimetrico>();
        }

        private void btnTrapSim_Click(object sender, EventArgs e)
        {
            abrirFormulario<FormTrapecialSimetrico>();
        }

        private void btnAsimTri_Click(object sender, EventArgs e)
        {
            abrirFormulario<Asimetricos.FormTriangularAsimetrico>();
        }

        private void btnAsimTrap_Click(object sender, EventArgs e)
        {
            abrirFormulario<Asimetricos.FormTrapecialSimetrico>();
        }

        private void btnCircular_MouseClick(object sender, MouseEventArgs e)
        {
            abrirFormulario<Circular.FormCircular>();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelSlide.Width == 200)
                panelSlide.Width = 54;
            else
                panelSlide.Width = 200;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelSlide.Width == 200)
                panelSlide.Width = 54;
            else
                panelSlide.Width = 200;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
