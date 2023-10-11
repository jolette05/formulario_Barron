
namespace formulario_Barron.Formas.Login
{
    partial class numerodelatidos
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
            this.labellatidos = new System.Windows.Forms.Label();
            this.labeledad = new System.Windows.Forms.Label();
            this.labelpulso = new System.Windows.Forms.Label();
            this.labelgenero = new System.Windows.Forms.Label();
            this.cmbxgenero = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxedad = new System.Windows.Forms.TextBox();
            this.txtboxlatidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllatidos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAHomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.botoncalcularlatidos = new System.Windows.Forms.Button();
            this.botonlimpiarlatidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labellatidos
            // 
            this.labellatidos.AutoSize = true;
            this.labellatidos.BackColor = System.Drawing.Color.Transparent;
            this.labellatidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellatidos.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labellatidos.Location = new System.Drawing.Point(508, 44);
            this.labellatidos.Name = "labellatidos";
            this.labellatidos.Size = new System.Drawing.Size(308, 38);
            this.labellatidos.TabIndex = 0;
            this.labellatidos.Text = "Número de latidos ";
            // 
            // labeledad
            // 
            this.labeledad.AutoSize = true;
            this.labeledad.BackColor = System.Drawing.Color.Transparent;
            this.labeledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledad.ForeColor = System.Drawing.Color.SlateBlue;
            this.labeledad.Location = new System.Drawing.Point(223, 181);
            this.labeledad.Name = "labeledad";
            this.labeledad.Size = new System.Drawing.Size(97, 38);
            this.labeledad.TabIndex = 2;
            this.labeledad.Text = "Edad";
            // 
            // labelpulso
            // 
            this.labelpulso.AutoSize = true;
            this.labelpulso.BackColor = System.Drawing.Color.Transparent;
            this.labelpulso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpulso.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelpulso.Location = new System.Drawing.Point(223, 359);
            this.labelpulso.Name = "labelpulso";
            this.labelpulso.Size = new System.Drawing.Size(139, 38);
            this.labelpulso.TabIndex = 3;
            this.labelpulso.Text = "Latidos ";
            // 
            // labelgenero
            // 
            this.labelgenero.AutoSize = true;
            this.labelgenero.BackColor = System.Drawing.Color.Transparent;
            this.labelgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgenero.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelgenero.Location = new System.Drawing.Point(192, 263);
            this.labelgenero.Name = "labelgenero";
            this.labelgenero.Size = new System.Drawing.Size(142, 38);
            this.labelgenero.TabIndex = 4;
            this.labelgenero.Text = "Género ";
            // 
            // cmbxgenero
            // 
            this.cmbxgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxgenero.FormattingEnabled = true;
            this.cmbxgenero.Items.AddRange(new object[] {
            "Femenino ",
            "Masculino "});
            this.cmbxgenero.Location = new System.Drawing.Point(388, 278);
            this.cmbxgenero.Name = "cmbxgenero";
            this.cmbxgenero.Size = new System.Drawing.Size(308, 39);
            this.cmbxgenero.TabIndex = 5;
            this.cmbxgenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::formulario_Barron.Properties.Resources.Captura_de_pantalla_2023_09_28_221427;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(909, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 237);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxedad
            // 
            this.txtboxedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxedad.Location = new System.Drawing.Point(388, 188);
            this.txtboxedad.Multiline = true;
            this.txtboxedad.Name = "txtboxedad";
            this.txtboxedad.Size = new System.Drawing.Size(312, 42);
            this.txtboxedad.TabIndex = 7;
            this.txtboxedad.TextChanged += new System.EventHandler(this.txtboxedad_TextChanged);
            // 
            // txtboxlatidos
            // 
            this.txtboxlatidos.Enabled = false;
            this.txtboxlatidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxlatidos.Location = new System.Drawing.Point(400, 359);
            this.txtboxlatidos.Multiline = true;
            this.txtboxlatidos.Name = "txtboxlatidos";
            this.txtboxlatidos.Size = new System.Drawing.Size(296, 47);
            this.txtboxlatidos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(726, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 9;
            // 
            // lbllatidos
            // 
            this.lbllatidos.AutoSize = true;
            this.lbllatidos.BackColor = System.Drawing.Color.Transparent;
            this.lbllatidos.Location = new System.Drawing.Point(720, 383);
            this.lbllatidos.Name = "lbllatidos";
            this.lbllatidos.Size = new System.Drawing.Size(0, 17);
            this.lbllatidos.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAHomeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.ayudaToolStripMenuItem.Text = "Archivo";
            // 
            // regresarAHomeToolStripMenuItem
            // 
            this.regresarAHomeToolStripMenuItem.Name = "regresarAHomeToolStripMenuItem";
            this.regresarAHomeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.regresarAHomeToolStripMenuItem.Text = "regresar a home ";
            this.regresarAHomeToolStripMenuItem.Click += new System.EventHandler(this.regresarAHomeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAHomeToolStripMenuItem1});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(69, 26);
            this.ayudaToolStripMenuItem1.Text = "Ayuda ";
            // 
            // regresarAHomeToolStripMenuItem1
            // 
            this.regresarAHomeToolStripMenuItem1.Name = "regresarAHomeToolStripMenuItem1";
            this.regresarAHomeToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.regresarAHomeToolStripMenuItem1.Text = "¿ Cómo funciona ?";
            // 
            // botoncalcularlatidos
            // 
            this.botoncalcularlatidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botoncalcularlatidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncalcularlatidos.ForeColor = System.Drawing.Color.DarkMagenta;
            this.botoncalcularlatidos.Location = new System.Drawing.Point(903, 430);
            this.botoncalcularlatidos.Name = "botoncalcularlatidos";
            this.botoncalcularlatidos.Size = new System.Drawing.Size(172, 72);
            this.botoncalcularlatidos.TabIndex = 12;
            this.botoncalcularlatidos.Text = "Calcular";
            this.botoncalcularlatidos.UseVisualStyleBackColor = false;
            this.botoncalcularlatidos.Click += new System.EventHandler(this.botoncalcularlatidos_Click);
            // 
            // botonlimpiarlatidos
            // 
            this.botonlimpiarlatidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonlimpiarlatidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiarlatidos.ForeColor = System.Drawing.Color.DarkMagenta;
            this.botonlimpiarlatidos.Location = new System.Drawing.Point(1103, 430);
            this.botonlimpiarlatidos.Name = "botonlimpiarlatidos";
            this.botonlimpiarlatidos.Size = new System.Drawing.Size(158, 72);
            this.botonlimpiarlatidos.TabIndex = 13;
            this.botonlimpiarlatidos.Text = "Limpiar";
            this.botonlimpiarlatidos.UseVisualStyleBackColor = false;
            this.botonlimpiarlatidos.Click += new System.EventHandler(this.botonlimpiarlatidos_Click);
            // 
            // numerodelatidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources.fondo_de_latidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 537);
            this.Controls.Add(this.botonlimpiarlatidos);
            this.Controls.Add(this.botoncalcularlatidos);
            this.Controls.Add(this.lbllatidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxlatidos);
            this.Controls.Add(this.txtboxedad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbxgenero);
            this.Controls.Add(this.labelgenero);
            this.Controls.Add(this.labelpulso);
            this.Controls.Add(this.labeledad);
            this.Controls.Add(this.labellatidos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "numerodelatidos";
            this.Text = "Pulsaciones ";
            this.Load += new System.EventHandler(this.numerodelatidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellatidos;
        private System.Windows.Forms.Label labeledad;
        private System.Windows.Forms.Label labelpulso;
        private System.Windows.Forms.Label labelgenero;
        private System.Windows.Forms.ComboBox cmbxgenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxedad;
        private System.Windows.Forms.TextBox txtboxlatidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllatidos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regresarAHomeToolStripMenuItem1;
        private System.Windows.Forms.Button botoncalcularlatidos;
        private System.Windows.Forms.Button botonlimpiarlatidos;
    }
}