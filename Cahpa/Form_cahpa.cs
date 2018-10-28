using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cahpa
{
    public partial class FormCAHPA : Form
    {

        public int xClick = 0, yClick = 0;
        public FormCAHPA()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void botonTiranteN_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonGeometricos_Body_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void botonGeometricos_Body_Click(object sender, EventArgs e)
        {
            PanelElementosGeometricos.FormElementosGeometricos fr = new PanelElementosGeometricos.FormElementosGeometricos();
            fr.Show();
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }

        private void botonTiranteN_Body_MouseClick(object sender, MouseEventArgs e)
        {
            PanelTiranteNormal.FormTiranteNormal ftn = new PanelTiranteNormal.FormTiranteNormal();
            ftn.Show();
        }

        private void ActionBar_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
            
        }
    }
}
