
namespace formulario_Barron.Formas.Login
{
    partial class Visor_de_imagenes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checboxAjustar = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonmostrarimagen = new System.Windows.Forms.Button();
            this.botonborrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.botoncerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.53597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.46403F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checboxAjustar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(141, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.12698F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checboxAjustar
            // 
            this.checboxAjustar.AutoSize = true;
            this.checboxAjustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checboxAjustar.Location = new System.Drawing.Point(3, 375);
            this.checboxAjustar.Name = "checboxAjustar";
            this.checboxAjustar.Size = new System.Drawing.Size(150, 42);
            this.checboxAjustar.TabIndex = 1;
            this.checboxAjustar.Text = " Ajustar";
            this.checboxAjustar.UseVisualStyleBackColor = true;
            this.checboxAjustar.CheckedChanged += new System.EventHandler(this.checboxAjustar_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonmostrarimagen);
            this.flowLayoutPanel1.Controls.Add(this.botonborrar);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.botoncerrar);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 375);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(912, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // botonmostrarimagen
            // 
            this.botonmostrarimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmostrarimagen.Location = new System.Drawing.Point(3, 3);
            this.botonmostrarimagen.Name = "botonmostrarimagen";
            this.botonmostrarimagen.Size = new System.Drawing.Size(142, 61);
            this.botonmostrarimagen.TabIndex = 0;
            this.botonmostrarimagen.Text = "Mostrar una imagen ";
            this.botonmostrarimagen.UseVisualStyleBackColor = true;
            this.botonmostrarimagen.Click += new System.EventHandler(this.botonmostrarimagen_Click);
            // 
            // botonborrar
            // 
            this.botonborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonborrar.Location = new System.Drawing.Point(151, 3);
            this.botonborrar.Name = "botonborrar";
            this.botonborrar.Size = new System.Drawing.Size(108, 61);
            this.botonborrar.TabIndex = 1;
            this.botonborrar.Text = "Borrar Imagen ";
            this.botonborrar.UseVisualStyleBackColor = true;
            this.botonborrar.Click += new System.EventHandler(this.botonborrar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(265, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Establecer color de fondo ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // botoncerrar
            // 
            this.botoncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncerrar.Location = new System.Drawing.Point(444, 3);
            this.botoncerrar.Name = "botoncerrar";
            this.botoncerrar.Size = new System.Drawing.Size(133, 61);
            this.botoncerrar.TabIndex = 3;
            this.botoncerrar.Text = "Cerrar";
            this.botoncerrar.UseVisualStyleBackColor = true;
            this.botoncerrar.Click += new System.EventHandler(this.botoncerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(580, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
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
            this.regresarAHomeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regresarAHomeToolStripMenuItem.Text = "Regresar a Home";
            this.regresarAHomeToolStripMenuItem.Click += new System.EventHandler(this.regresarAHomeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cómoFuncionaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda ";
            // 
            // cómoFuncionaToolStripMenuItem
            // 
            this.cómoFuncionaToolStripMenuItem.Name = "cómoFuncionaToolStripMenuItem";
            this.cómoFuncionaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cómoFuncionaToolStripMenuItem.Text = "¿Cómo funciona ?";
            // 
            // Visor_de_imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources.fondo_visorimagrn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Visor_de_imagenes";
            this.Text = "Visor_de_imagenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checboxAjustar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button botonmostrarimagen;
        private System.Windows.Forms.Button botonborrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button botoncerrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cómoFuncionaToolStripMenuItem;
    }
}