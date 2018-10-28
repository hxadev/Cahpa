namespace Cahpa
{
    partial class FormCAHPA
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCAHPA));
            this.Banner_Header = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.ActionBar_Header = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.botonGeometricos_Body = new System.Windows.Forms.Panel();
            this.botonTiranteN_Body = new System.Windows.Forms.Panel();
            this.Body = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            this.labelDerechos = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconoLogin = new System.Windows.Forms.PictureBox();
            this.Banner_Header.SuspendLayout();
            this.Header.SuspendLayout();
            this.ActionBar_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner_Header
            // 
            this.Banner_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Banner_Header.BackgroundImage")));
            this.Banner_Header.Controls.Add(this.IconoLogin);
            this.Banner_Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Banner_Header.Location = new System.Drawing.Point(0, 21);
            this.Banner_Header.Name = "Banner_Header";
            this.Banner_Header.Size = new System.Drawing.Size(834, 100);
            this.Banner_Header.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.ActionBar_Header);
            this.Header.Controls.Add(this.Banner_Header);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(834, 121);
            this.Header.TabIndex = 0;
            // 
            // ActionBar_Header
            // 
            this.ActionBar_Header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ActionBar_Header.Controls.Add(this.pictureBox1);
            this.ActionBar_Header.Controls.Add(this.labelTitle);
            this.ActionBar_Header.Controls.Add(this.btn_Minimize);
            this.ActionBar_Header.Controls.Add(this.btn_Close);
            this.ActionBar_Header.Location = new System.Drawing.Point(0, 0);
            this.ActionBar_Header.Margin = new System.Windows.Forms.Padding(0);
            this.ActionBar_Header.Name = "ActionBar_Header";
            this.ActionBar_Header.Size = new System.Drawing.Size(834, 21);
            this.ActionBar_Header.TabIndex = 1;
            this.ActionBar_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ActionBar_Header_MouseMove);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.Location = new System.Drawing.Point(775, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(806, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // botonGeometricos_Body
            // 
            this.botonGeometricos_Body.BackColor = System.Drawing.Color.Transparent;
            this.botonGeometricos_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonGeometricos_Body.BackgroundImage")));
            this.botonGeometricos_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonGeometricos_Body.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonGeometricos_Body.Location = new System.Drawing.Point(27, 139);
            this.botonGeometricos_Body.Margin = new System.Windows.Forms.Padding(15);
            this.botonGeometricos_Body.Name = "botonGeometricos_Body";
            this.botonGeometricos_Body.Size = new System.Drawing.Size(200, 100);
            this.botonGeometricos_Body.TabIndex = 4;
            this.botonGeometricos_Body.Click += new System.EventHandler(this.botonGeometricos_Body_Click);
            this.botonGeometricos_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.botonGeometricos_Body_Paint);
            // 
            // botonTiranteN_Body
            // 
            this.botonTiranteN_Body.BackColor = System.Drawing.Color.Transparent;
            this.botonTiranteN_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonTiranteN_Body.BackgroundImage")));
            this.botonTiranteN_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonTiranteN_Body.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTiranteN_Body.Location = new System.Drawing.Point(245, 139);
            this.botonTiranteN_Body.Name = "botonTiranteN_Body";
            this.botonTiranteN_Body.Padding = new System.Windows.Forms.Padding(10);
            this.botonTiranteN_Body.Size = new System.Drawing.Size(200, 100);
            this.botonTiranteN_Body.TabIndex = 5;
            this.botonTiranteN_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.botonTiranteN_Body_Paint);
            this.botonTiranteN_Body.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonTiranteN_Body_MouseClick);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.botonTiranteN_Body);
            this.Body.Controls.Add(this.botonGeometricos_Body);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(834, 441);
            this.Body.TabIndex = 0;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Footer.Controls.Add(this.labelDescripcion);
            this.Footer.Controls.Add(this.labelDerechos);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 441);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(834, 20);
            this.Footer.TabIndex = 2;
            // 
            // labelDerechos
            // 
            this.labelDerechos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDerechos.AutoSize = true;
            this.labelDerechos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDerechos.Location = new System.Drawing.Point(610, 4);
            this.labelDerechos.Name = "labelDerechos";
            this.labelDerechos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDerechos.Size = new System.Drawing.Size(221, 13);
            this.labelDerechos.TabIndex = 2;
            this.labelDerechos.Text = "G. Paola - H. Alfonso - Derechos Reservados";
            this.labelDerechos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDescripcion.Location = new System.Drawing.Point(27, 4);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDescripcion.Size = new System.Drawing.Size(0, 13);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(25, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(191, 16);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "CAHPA  Soluciones en Canales ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // IconoLogin
            // 
            this.IconoLogin.BackColor = System.Drawing.Color.Transparent;
            this.IconoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoLogin.Image = ((System.Drawing.Image)(resources.GetObject("IconoLogin.Image")));
            this.IconoLogin.Location = new System.Drawing.Point(394, 0);
            this.IconoLogin.Name = "IconoLogin";
            this.IconoLogin.Size = new System.Drawing.Size(50, 50);
            this.IconoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconoLogin.TabIndex = 1;
            this.IconoLogin.TabStop = false;
            // 
            // FormCAHPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCAHPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Banner_Header.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ActionBar_Header.ResumeLayout(false);
            this.ActionBar_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Banner_Header;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ActionBar_Header;
        private System.Windows.Forms.Panel botonGeometricos_Body;
        private System.Windows.Forms.Panel botonTiranteN_Body;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.PictureBox btn_Minimize;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label labelDerechos;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IconoLogin;
    }
}

