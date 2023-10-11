
namespace formulario_Barron.Formas.Login
{
    partial class ejercicio1
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
            this.titulo_calculadora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_calcular = new System.Windows.Forms.Button();
            this.txtboxvalor1 = new System.Windows.Forms.TextBox();
            this.txtboxvalor2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxresultadosuma = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btonlimpiarsuma = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_calculadora
            // 
            this.titulo_calculadora.AutoSize = true;
            this.titulo_calculadora.BackColor = System.Drawing.Color.Transparent;
            this.titulo_calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_calculadora.ForeColor = System.Drawing.Color.BlueViolet;
            this.titulo_calculadora.Location = new System.Drawing.Point(451, 31);
            this.titulo_calculadora.Name = "titulo_calculadora";
            this.titulo_calculadora.Size = new System.Drawing.Size(391, 51);
            this.titulo_calculadora.TabIndex = 0;
            this.titulo_calculadora.Text = "Suma de Numeros ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(178, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(177, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese Valor 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boton_calcular
            // 
            this.boton_calcular.BackColor = System.Drawing.Color.Black;
            this.boton_calcular.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_calcular.ForeColor = System.Drawing.Color.MediumPurple;
            this.boton_calcular.Location = new System.Drawing.Point(835, 413);
            this.boton_calcular.Name = "boton_calcular";
            this.boton_calcular.Size = new System.Drawing.Size(183, 70);
            this.boton_calcular.TabIndex = 3;
            this.boton_calcular.Text = "Calcular ";
            this.boton_calcular.UseVisualStyleBackColor = false;
            this.boton_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxvalor1
            // 
            this.txtboxvalor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxvalor1.Location = new System.Drawing.Point(460, 154);
            this.txtboxvalor1.Multiline = true;
            this.txtboxvalor1.Name = "txtboxvalor1";
            this.txtboxvalor1.Size = new System.Drawing.Size(398, 69);
            this.txtboxvalor1.TabIndex = 4;
            // 
            // txtboxvalor2
            // 
            this.txtboxvalor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxvalor2.Location = new System.Drawing.Point(460, 290);
            this.txtboxvalor2.Multiline = true;
            this.txtboxvalor2.Name = "txtboxvalor2";
            this.txtboxvalor2.Size = new System.Drawing.Size(398, 77);
            this.txtboxvalor2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(281, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado ";
            // 
            // txtboxresultadosuma
            // 
            this.txtboxresultadosuma.Enabled = false;
            this.txtboxresultadosuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxresultadosuma.Location = new System.Drawing.Point(460, 413);
            this.txtboxresultadosuma.Multiline = true;
            this.txtboxresultadosuma.Name = "txtboxresultadosuma";
            this.txtboxresultadosuma.Size = new System.Drawing.Size(245, 54);
            this.txtboxresultadosuma.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAHomeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // regresarAHomeToolStripMenuItem
            // 
            this.regresarAHomeToolStripMenuItem.Name = "regresarAHomeToolStripMenuItem";
            this.regresarAHomeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.regresarAHomeToolStripMenuItem.Text = "Regresar a home ";
            this.regresarAHomeToolStripMenuItem.Click += new System.EventHandler(this.regresarAHomeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btonlimpiarsuma
            // 
            this.btonlimpiarsuma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btonlimpiarsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonlimpiarsuma.ForeColor = System.Drawing.Color.MediumPurple;
            this.btonlimpiarsuma.Location = new System.Drawing.Point(1056, 413);
            this.btonlimpiarsuma.Name = "btonlimpiarsuma";
            this.btonlimpiarsuma.Size = new System.Drawing.Size(201, 70);
            this.btonlimpiarsuma.TabIndex = 9;
            this.btonlimpiarsuma.Text = "Limpiar ";
            this.btonlimpiarsuma.UseVisualStyleBackColor = false;
            this.btonlimpiarsuma.Click += new System.EventHandler(this.btonlimpiarsuma_Click);
            // 
            // ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(1333, 517);
            this.Controls.Add(this.btonlimpiarsuma);
            this.Controls.Add(this.txtboxresultadosuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxvalor2);
            this.Controls.Add(this.txtboxvalor1);
            this.Controls.Add(this.boton_calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo_calculadora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ejercicio1";
            this.Text = "Calculadora ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_calculadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_calcular;
        private System.Windows.Forms.TextBox txtboxvalor1;
        private System.Windows.Forms.TextBox txtboxvalor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxresultadosuma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btonlimpiarsuma;
    }
}