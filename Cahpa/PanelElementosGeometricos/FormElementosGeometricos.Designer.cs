namespace Cahpa.PanelElementosGeometricos
{
    partial class FormElementosGeometricos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElementosGeometricos));
            this.ActionBar_Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.barMenu = new System.Windows.Forms.Panel();
            this.btnCircular = new System.Windows.Forms.Button();
            this.btnSimetricas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.btnAsimetricas = new System.Windows.Forms.Button();
            this.panelAsimetricas = new System.Windows.Forms.Panel();
            this.btnAsimTrap = new System.Windows.Forms.Button();
            this.btnAsimTri = new System.Windows.Forms.Button();
            this.panelSimetricas = new System.Windows.Forms.Panel();
            this.btnTrapSim = new System.Windows.Forms.Button();
            this.btnRecSim = new System.Windows.Forms.Button();
            this.btnTriSim = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.ActionBar_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.panelAsimetricas.SuspendLayout();
            this.panelSimetricas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
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
            this.ActionBar_Header.TabIndex = 2;
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
            this.labelTitle.Size = new System.Drawing.Size(267, 16);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "CAHPA - Calculo de Elementos Geometricos";
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
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Close_Click_1);
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
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.barMenu);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 21);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(200, 440);
            this.panelSlide.TabIndex = 3;
            // 
            // barMenu
            // 
            this.barMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.barMenu.Controls.Add(this.btnCircular);
            this.barMenu.Controls.Add(this.btnSimetricas);
            this.barMenu.Controls.Add(this.panel2);
            this.barMenu.Controls.Add(this.btnAsimetricas);
            this.barMenu.Controls.Add(this.panelAsimetricas);
            this.barMenu.Controls.Add(this.panelSimetricas);
            this.barMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(200, 440);
            this.barMenu.TabIndex = 2;
            // 
            // btnCircular
            // 
            this.btnCircular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnCircular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircular.FlatAppearance.BorderSize = 0;
            this.btnCircular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircular.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCircular.Location = new System.Drawing.Point(0, 385);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(200, 38);
            this.btnCircular.TabIndex = 2;
            this.btnCircular.Text = "Circular";
            this.btnCircular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCircular.UseVisualStyleBackColor = false;
            this.btnCircular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCircular_MouseClick);
            // 
            // btnSimetricas
            // 
            this.btnSimetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnSimetricas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimetricas.FlatAppearance.BorderSize = 0;
            this.btnSimetricas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimetricas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimetricas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSimetricas.Location = new System.Drawing.Point(0, 68);
            this.btnSimetricas.Name = "btnSimetricas";
            this.btnSimetricas.Size = new System.Drawing.Size(200, 38);
            this.btnSimetricas.TabIndex = 0;
            this.btnSimetricas.Text = "Secciones Simetricas";
            this.btnSimetricas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimetricas.UseVisualStyleBackColor = false;
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
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
            // btnAsimetricas
            // 
            this.btnAsimetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnAsimetricas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsimetricas.FlatAppearance.BorderSize = 0;
            this.btnAsimetricas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsimetricas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsimetricas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAsimetricas.Location = new System.Drawing.Point(0, 246);
            this.btnAsimetricas.Name = "btnAsimetricas";
            this.btnAsimetricas.Size = new System.Drawing.Size(200, 38);
            this.btnAsimetricas.TabIndex = 1;
            this.btnAsimetricas.Text = "Secciones Asimetricas";
            this.btnAsimetricas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsimetricas.UseVisualStyleBackColor = false;
            // 
            // panelAsimetricas
            // 
            this.panelAsimetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panelAsimetricas.Controls.Add(this.btnAsimTrap);
            this.panelAsimetricas.Controls.Add(this.btnAsimTri);
            this.panelAsimetricas.Location = new System.Drawing.Point(0, 290);
            this.panelAsimetricas.Name = "panelAsimetricas";
            this.panelAsimetricas.Size = new System.Drawing.Size(200, 89);
            this.panelAsimetricas.TabIndex = 3;
            // 
            // btnAsimTrap
            // 
            this.btnAsimTrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsimTrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsimTrap.FlatAppearance.BorderSize = 0;
            this.btnAsimTrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsimTrap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsimTrap.ForeColor = System.Drawing.Color.White;
            this.btnAsimTrap.Location = new System.Drawing.Point(0, 47);
            this.btnAsimTrap.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.btnAsimTrap.Name = "btnAsimTrap";
            this.btnAsimTrap.Size = new System.Drawing.Size(200, 38);
            this.btnAsimTrap.TabIndex = 4;
            this.btnAsimTrap.Text = "Trapecial";
            this.btnAsimTrap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsimTrap.UseVisualStyleBackColor = false;
            this.btnAsimTrap.Click += new System.EventHandler(this.btnAsimTrap_Click);
            // 
            // btnAsimTri
            // 
            this.btnAsimTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsimTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsimTri.FlatAppearance.BorderSize = 0;
            this.btnAsimTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsimTri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsimTri.ForeColor = System.Drawing.Color.White;
            this.btnAsimTri.Location = new System.Drawing.Point(0, 3);
            this.btnAsimTri.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnAsimTri.Name = "btnAsimTri";
            this.btnAsimTri.Size = new System.Drawing.Size(200, 38);
            this.btnAsimTri.TabIndex = 3;
            this.btnAsimTri.Text = "Triangular";
            this.btnAsimTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsimTri.UseVisualStyleBackColor = false;
            this.btnAsimTri.Click += new System.EventHandler(this.btnAsimTri_Click);
            // 
            // panelSimetricas
            // 
            this.panelSimetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panelSimetricas.Controls.Add(this.btnTrapSim);
            this.panelSimetricas.Controls.Add(this.btnRecSim);
            this.panelSimetricas.Controls.Add(this.btnTriSim);
            this.panelSimetricas.Location = new System.Drawing.Point(0, 111);
            this.panelSimetricas.Name = "panelSimetricas";
            this.panelSimetricas.Size = new System.Drawing.Size(200, 129);
            this.panelSimetricas.TabIndex = 2;
            // 
            // btnTrapSim
            // 
            this.btnTrapSim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrapSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrapSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrapSim.BackgroundImage")));
            this.btnTrapSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrapSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrapSim.FlatAppearance.BorderSize = 0;
            this.btnTrapSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapSim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrapSim.ForeColor = System.Drawing.Color.White;
            this.btnTrapSim.Location = new System.Drawing.Point(0, 88);
            this.btnTrapSim.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnTrapSim.Name = "btnTrapSim";
            this.btnTrapSim.Size = new System.Drawing.Size(200, 38);
            this.btnTrapSim.TabIndex = 2;
            this.btnTrapSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrapSim.UseVisualStyleBackColor = false;
            this.btnTrapSim.Click += new System.EventHandler(this.btnTrapSim_Click);
            // 
            // btnRecSim
            // 
            this.btnRecSim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecSim.BackgroundImage")));
            this.btnRecSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecSim.FlatAppearance.BorderSize = 0;
            this.btnRecSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecSim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecSim.ForeColor = System.Drawing.Color.White;
            this.btnRecSim.Location = new System.Drawing.Point(0, 0);
            this.btnRecSim.Name = "btnRecSim";
            this.btnRecSim.Size = new System.Drawing.Size(200, 38);
            this.btnRecSim.TabIndex = 0;
            this.btnRecSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecSim.UseVisualStyleBackColor = false;
            this.btnRecSim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRecSim_MouseClick);
            // 
            // btnTriSim
            // 
            this.btnTriSim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTriSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTriSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTriSim.BackgroundImage")));
            this.btnTriSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTriSim.FlatAppearance.BorderSize = 0;
            this.btnTriSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriSim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriSim.ForeColor = System.Drawing.Color.White;
            this.btnTriSim.Location = new System.Drawing.Point(0, 44);
            this.btnTriSim.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnTriSim.Name = "btnTriSim";
            this.btnTriSim.Size = new System.Drawing.Size(200, 38);
            this.btnTriSim.TabIndex = 1;
            this.btnTriSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTriSim.UseVisualStyleBackColor = false;
            this.btnTriSim.Click += new System.EventHandler(this.btnTriSim_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFormulario.Location = new System.Drawing.Point(203, 21);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(631, 440);
            this.panelFormulario.TabIndex = 3;
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
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // FormElementosGeometricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.ActionBar_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormElementosGeometricos";
            this.Text = "FormElementosGeometricos";
            this.ActionBar_Header.ResumeLayout(false);
            this.ActionBar_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.barMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.panelAsimetricas.ResumeLayout(false);
            this.panelSimetricas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
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
        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.Button btnSimetricas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.Button btnAsimetricas;
        private System.Windows.Forms.Panel panelAsimetricas;
        private System.Windows.Forms.Button btnAsimTrap;
        private System.Windows.Forms.Button btnAsimTri;
        private System.Windows.Forms.Panel panelSimetricas;
        private System.Windows.Forms.Button btnTrapSim;
        private System.Windows.Forms.Button btnRecSim;
        private System.Windows.Forms.Button btnTriSim;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.PictureBox btnSlide;
    }
}