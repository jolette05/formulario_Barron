
namespace formulario_Barron.Formas.Login
{
    partial class conversiones_de_moneda
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
            this.labeLConversiones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelequivale = new System.Windows.Forms.Label();
            this.convertirpesos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxequivale = new System.Windows.Forms.TextBox();
            this.txtboxingresarcantidad = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botoncalculardinero = new System.Windows.Forms.Button();
            this.botonlimpiardinero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeLConversiones
            // 
            this.labeLConversiones.AutoSize = true;
            this.labeLConversiones.BackColor = System.Drawing.Color.Transparent;
            this.labeLConversiones.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLConversiones.Location = new System.Drawing.Point(407, 55);
            this.labeLConversiones.Name = "labeLConversiones";
            this.labeLConversiones.Size = new System.Drawing.Size(482, 35);
            this.labeLConversiones.TabIndex = 0;
            this.labeLConversiones.Text = "CONVERSIONES DE DINERO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar pesos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir a :";
            // 
            // labelequivale
            // 
            this.labelequivale.AutoSize = true;
            this.labelequivale.BackColor = System.Drawing.Color.Transparent;
            this.labelequivale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelequivale.Location = new System.Drawing.Point(184, 364);
            this.labelequivale.Name = "labelequivale";
            this.labelequivale.Size = new System.Drawing.Size(176, 32);
            this.labelequivale.TabIndex = 3;
            this.labelequivale.Text = "Equivale a :";
            // 
            // convertirpesos
            // 
            this.convertirpesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertirpesos.FormattingEnabled = true;
            this.convertirpesos.Items.AddRange(new object[] {
            "Dolares",
            "Euros"});
            this.convertirpesos.Location = new System.Drawing.Point(453, 271);
            this.convertirpesos.Name = "convertirpesos";
            this.convertirpesos.Size = new System.Drawing.Size(238, 39);
            this.convertirpesos.TabIndex = 4;
            this.convertirpesos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::formulario_Barron.Properties.Resources.Captura_de_pantalla_2023_09_28_194840;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(880, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 236);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxequivale
            // 
            this.txtboxequivale.Enabled = false;
            this.txtboxequivale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxequivale.Location = new System.Drawing.Point(441, 346);
            this.txtboxequivale.Multiline = true;
            this.txtboxequivale.Name = "txtboxequivale";
            this.txtboxequivale.Size = new System.Drawing.Size(232, 50);
            this.txtboxequivale.TabIndex = 6;
            // 
            // txtboxingresarcantidad
            // 
            this.txtboxingresarcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxingresarcantidad.Location = new System.Drawing.Point(453, 173);
            this.txtboxingresarcantidad.Multiline = true;
            this.txtboxingresarcantidad.Name = "txtboxingresarcantidad";
            this.txtboxingresarcantidad.Size = new System.Drawing.Size(232, 51);
            this.txtboxingresarcantidad.TabIndex = 7;
            this.txtboxingresarcantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(716, 377);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 32);
            this.lblmsg.TabIndex = 8;
            this.lblmsg.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAHomeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.archivoToolStripMenuItem.Text = "Archivo ";
            // 
            // regresarAHomeToolStripMenuItem
            // 
            this.regresarAHomeToolStripMenuItem.Name = "regresarAHomeToolStripMenuItem";
            this.regresarAHomeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.regresarAHomeToolStripMenuItem.Text = "Regresar a home";
            this.regresarAHomeToolStripMenuItem.Click += new System.EventHandler(this.regresarAHomeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cómoFuncionaToolStripMenuItem});
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
            // botoncalculardinero
            // 
            this.botoncalculardinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.botoncalculardinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncalculardinero.Location = new System.Drawing.Point(855, 427);
            this.botoncalculardinero.Name = "botoncalculardinero";
            this.botoncalculardinero.Size = new System.Drawing.Size(199, 75);
            this.botoncalculardinero.TabIndex = 10;
            this.botoncalculardinero.Text = "Calcular ";
            this.botoncalculardinero.UseVisualStyleBackColor = false;
            this.botoncalculardinero.Click += new System.EventHandler(this.botoncalculardinero_Click);
            // 
            // botonlimpiardinero
            // 
            this.botonlimpiardinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.botonlimpiardinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiardinero.Location = new System.Drawing.Point(1070, 427);
            this.botonlimpiardinero.Name = "botonlimpiardinero";
            this.botonlimpiardinero.Size = new System.Drawing.Size(202, 75);
            this.botonlimpiardinero.TabIndex = 11;
            this.botonlimpiardinero.Text = "Limpiar";
            this.botonlimpiardinero.UseVisualStyleBackColor = false;
            this.botonlimpiardinero.Click += new System.EventHandler(this.botonlimpiardinero_Click);
            // 
            // conversiones_de_moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources.fondo_de_conversiones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 526);
            this.Controls.Add(this.botonlimpiardinero);
            this.Controls.Add(this.botoncalculardinero);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtboxingresarcantidad);
            this.Controls.Add(this.txtboxequivale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertirpesos);
            this.Controls.Add(this.labelequivale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeLConversiones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "conversiones_de_moneda";
            this.Text = "conversiones_de_moneda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeLConversiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelequivale;
        private System.Windows.Forms.ComboBox convertirpesos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxequivale;
        private System.Windows.Forms.TextBox txtboxingresarcantidad;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cómoFuncionaToolStripMenuItem;
        private System.Windows.Forms.Button botoncalculardinero;
        private System.Windows.Forms.Button botonlimpiardinero;
    }
}