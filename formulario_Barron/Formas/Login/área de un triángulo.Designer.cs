
namespace formulario_Barron.Formas.Login
{
    partial class Area_de_un_trianfulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Base_triangulo = new System.Windows.Forms.Label();
            this.Altura_triangulo = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Calcular_area = new System.Windows.Forms.Button();
            this.txtboxbase = new System.Windows.Forms.TextBox();
            this.txtboxarea = new System.Windows.Forms.TextBox();
            this.txtboxaltura = new System.Windows.Forms.TextBox();
            this.triangulo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarahomearea = new System.Windows.Forms.ToolStripMenuItem();
            this.salirarea = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonlimpiartriangulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.triangulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(541, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área del triángulo ";
            // 
            // Base_triangulo
            // 
            this.Base_triangulo.AutoSize = true;
            this.Base_triangulo.BackColor = System.Drawing.Color.Transparent;
            this.Base_triangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_triangulo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Base_triangulo.Location = new System.Drawing.Point(111, 131);
            this.Base_triangulo.Name = "Base_triangulo";
            this.Base_triangulo.Size = new System.Drawing.Size(86, 36);
            this.Base_triangulo.TabIndex = 1;
            this.Base_triangulo.Text = "Base";
            this.Base_triangulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Altura_triangulo
            // 
            this.Altura_triangulo.AutoSize = true;
            this.Altura_triangulo.BackColor = System.Drawing.Color.Transparent;
            this.Altura_triangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura_triangulo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Altura_triangulo.Location = new System.Drawing.Point(111, 222);
            this.Altura_triangulo.Name = "Altura_triangulo";
            this.Altura_triangulo.Size = new System.Drawing.Size(109, 36);
            this.Altura_triangulo.TabIndex = 2;
            this.Altura_triangulo.Text = "Altura ";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Area.Location = new System.Drawing.Point(111, 324);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(82, 36);
            this.Area.TabIndex = 3;
            this.Area.Text = "Área";
            // 
            // Calcular_area
            // 
            this.Calcular_area.BackColor = System.Drawing.Color.Black;
            this.Calcular_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular_area.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Calcular_area.Location = new System.Drawing.Point(663, 412);
            this.Calcular_area.Name = "Calcular_area";
            this.Calcular_area.Size = new System.Drawing.Size(259, 89);
            this.Calcular_area.TabIndex = 4;
            this.Calcular_area.Text = "Calcular ";
            this.Calcular_area.UseVisualStyleBackColor = false;
            this.Calcular_area.Click += new System.EventHandler(this.Calcular_area_Click);
            // 
            // txtboxbase
            // 
            this.txtboxbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxbase.Location = new System.Drawing.Point(295, 131);
            this.txtboxbase.Multiline = true;
            this.txtboxbase.Name = "txtboxbase";
            this.txtboxbase.Size = new System.Drawing.Size(330, 57);
            this.txtboxbase.TabIndex = 6;
            this.txtboxbase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxarea
            // 
            this.txtboxarea.Enabled = false;
            this.txtboxarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxarea.Location = new System.Drawing.Point(295, 324);
            this.txtboxarea.Multiline = true;
            this.txtboxarea.Name = "txtboxarea";
            this.txtboxarea.Size = new System.Drawing.Size(330, 58);
            this.txtboxarea.TabIndex = 7;
            this.txtboxarea.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtboxaltura
            // 
            this.txtboxaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxaltura.Location = new System.Drawing.Point(295, 217);
            this.txtboxaltura.Multiline = true;
            this.txtboxaltura.Name = "txtboxaltura";
            this.txtboxaltura.Size = new System.Drawing.Size(330, 57);
            this.txtboxaltura.TabIndex = 8;
            // 
            // triangulo
            // 
            this.triangulo.BackgroundImage = global::formulario_Barron.Properties.Resources.Captura_de_pantalla_2023_09_27_232206;
            this.triangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangulo.Location = new System.Drawing.Point(996, 150);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(275, 210);
            this.triangulo.TabIndex = 9;
            this.triangulo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarahomearea,
            this.salirarea});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.archivoToolStripMenuItem.Text = "Archivo ";
            // 
            // regresarahomearea
            // 
            this.regresarahomearea.Name = "regresarahomearea";
            this.regresarahomearea.Size = new System.Drawing.Size(205, 26);
            this.regresarahomearea.Text = "Regresas a home";
            this.regresarahomearea.Click += new System.EventHandler(this.regresasAHomeToolStripMenuItem_Click);
            // 
            // salirarea
            // 
            this.salirarea.Name = "salirarea";
            this.salirarea.Size = new System.Drawing.Size(205, 26);
            this.salirarea.Text = "Salir";
            this.salirarea.Click += new System.EventHandler(this.salirarea_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cómoFuncionaToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cómoFuncionaToolStripMenuItem
            // 
            this.cómoFuncionaToolStripMenuItem.Name = "cómoFuncionaToolStripMenuItem";
            this.cómoFuncionaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.cómoFuncionaToolStripMenuItem.Text = "¿Cómo funciona ?";
            // 
            // botonlimpiartriangulo
            // 
            this.botonlimpiartriangulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonlimpiartriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiartriangulo.ForeColor = System.Drawing.Color.SlateBlue;
            this.botonlimpiartriangulo.Location = new System.Drawing.Point(955, 412);
            this.botonlimpiartriangulo.Name = "botonlimpiartriangulo";
            this.botonlimpiartriangulo.Size = new System.Drawing.Size(212, 89);
            this.botonlimpiartriangulo.TabIndex = 11;
            this.botonlimpiartriangulo.Text = "Limpiar ";
            this.botonlimpiartriangulo.UseVisualStyleBackColor = false;
            this.botonlimpiartriangulo.Click += new System.EventHandler(this.botonlimpiartriangulo_Click);
            // 
            // Area_de_un_trianfulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources.fondo_del_area;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 532);
            this.Controls.Add(this.botonlimpiartriangulo);
            this.Controls.Add(this.triangulo);
            this.Controls.Add(this.txtboxaltura);
            this.Controls.Add(this.txtboxarea);
            this.Controls.Add(this.txtboxbase);
            this.Controls.Add(this.Calcular_area);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Altura_triangulo);
            this.Controls.Add(this.Base_triangulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Area_de_un_trianfulo";
            this.Text = "área de un triángulo";
            ((System.ComponentModel.ISupportInitialize)(this.triangulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Base_triangulo;
        private System.Windows.Forms.Label Altura_triangulo;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button Calcular_area;
        private System.Windows.Forms.TextBox txtboxbase;
        private System.Windows.Forms.TextBox txtboxarea;
        private System.Windows.Forms.TextBox txtboxaltura;
        private System.Windows.Forms.PictureBox triangulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarahomearea;
        private System.Windows.Forms.ToolStripMenuItem salirarea;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cómoFuncionaToolStripMenuItem;
        private System.Windows.Forms.Button botonlimpiartriangulo;
    }
}