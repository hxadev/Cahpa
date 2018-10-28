namespace Cahpa.PanelTiranteNormal
{
    partial class FormTiranteNormal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiranteNormal));
            this.ActionBar_Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.barMenu = new System.Windows.Forms.Panel();
            this.btnTriangularTn = new System.Windows.Forms.Button();
            this.btnRectangularTn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.btnTrapecialTn = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.ActionBar_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionBar_Header
            // 
            this.ActionBar_Header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ActionBar_Header.Controls.Add(this.pictureBox1);
            this.ActionBar_Header.Controls.Add(this.labelTitle);
            this.ActionBar_Header.Controls.Add(this.btn_Minimize);
            this.ActionBar_Header.Controls.Add(this.btn_Close);
            this.ActionBar_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionBar_Header.Location = new System.Drawing.Point(0, 0);
            this.ActionBar_Header.Margin = new System.Windows.Forms.Padding(0);
            this.ActionBar_Header.Name = "ActionBar_Header";
            this.ActionBar_Header.Size = new System.Drawing.Size(834, 21);
            this.ActionBar_Header.TabIndex = 3;
            this.ActionBar_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ActionBar_Header_MouseMove);
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
            this.labelTitle.Size = new System.Drawing.Size(214, 16);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "CAHPA - Calculo de Tirante Normal";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
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
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.barMenu);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 21);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(200, 440);
            this.panelSlide.TabIndex = 4;
            // 
            // barMenu
            // 
            this.barMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.barMenu.Controls.Add(this.btnTriangularTn);
            this.barMenu.Controls.Add(this.btnRectangularTn);
            this.barMenu.Controls.Add(this.panel2);
            this.barMenu.Controls.Add(this.btnTrapecialTn);
            this.barMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(200, 440);
            this.barMenu.TabIndex = 2;
            // 
            // btnTriangularTn
            // 
            this.btnTriangularTn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnTriangularTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTriangularTn.FlatAppearance.BorderSize = 0;
            this.btnTriangularTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangularTn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangularTn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTriangularTn.Location = new System.Drawing.Point(0, 156);
            this.btnTriangularTn.Name = "btnTriangularTn";
            this.btnTriangularTn.Size = new System.Drawing.Size(200, 38);
            this.btnTriangularTn.TabIndex = 2;
            this.btnTriangularTn.Text = "Seccion Triangular";
            this.btnTriangularTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTriangularTn.UseVisualStyleBackColor = false;
            // 
            // btnRectangularTn
            // 
            this.btnRectangularTn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnRectangularTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangularTn.FlatAppearance.BorderSize = 0;
            this.btnRectangularTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangularTn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangularTn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRectangularTn.Location = new System.Drawing.Point(0, 68);
            this.btnRectangularTn.Name = "btnRectangularTn";
            this.btnRectangularTn.Size = new System.Drawing.Size(200, 38);
            this.btnRectangularTn.TabIndex = 0;
            this.btnRectangularTn.Text = "Seccion Rectangular";
            this.btnRectangularTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRectangularTn.UseVisualStyleBackColor = false;
            this.btnRectangularTn.Click += new System.EventHandler(this.btnRectangularTn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.btnSlide);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 64);
            this.panel2.TabIndex = 0;
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(174, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(23, 22);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 1;
            this.btnSlide.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picHide);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 50);
            this.panel1.TabIndex = 0;
            // 
            // picHide
            // 
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(174, 3);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(23, 22);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 0;
            this.picHide.TabStop = false;
            // 
            // btnTrapecialTn
            // 
            this.btnTrapecialTn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnTrapecialTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrapecialTn.FlatAppearance.BorderSize = 0;
            this.btnTrapecialTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapecialTn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrapecialTn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTrapecialTn.Location = new System.Drawing.Point(0, 112);
            this.btnTrapecialTn.Name = "btnTrapecialTn";
            this.btnTrapecialTn.Size = new System.Drawing.Size(200, 38);
            this.btnTrapecialTn.TabIndex = 1;
            this.btnTrapecialTn.Text = "Seccion Trapecial";
            this.btnTrapecialTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrapecialTn.UseVisualStyleBackColor = false;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFormulario.Location = new System.Drawing.Point(203, 21);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(631, 440);
            this.panelFormulario.TabIndex = 5;
            // 
            // FormTiranteNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.ActionBar_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTiranteNormal";
            this.Text = "FormTiranteNormal";
            this.ActionBar_Header.ResumeLayout(false);
            this.ActionBar_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.barMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ActionBar_Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox btn_Minimize;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel barMenu;
        private System.Windows.Forms.Button btnTriangularTn;
        private System.Windows.Forms.Button btnRectangularTn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.Button btnTrapecialTn;
        private System.Windows.Forms.Panel panelFormulario;
    }
}