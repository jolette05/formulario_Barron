
namespace formulario_Barron
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtboxNombreSesion = new System.Windows.Forms.TextBox();
            this.txtboxContraseña = new System.Windows.Forms.TextBox();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_crear_cuenta_ = new System.Windows.Forms.Label();
            this.click_para_registrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::formulario_Barron.Properties.Resources.usuario_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::formulario_Barron.Properties.Resources.icon_contraseña;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(196, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 142);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtboxNombreSesion
            // 
            this.txtboxNombreSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombreSesion.Location = new System.Drawing.Point(489, 123);
            this.txtboxNombreSesion.Multiline = true;
            this.txtboxNombreSesion.Name = "txtboxNombreSesion";
            this.txtboxNombreSesion.Size = new System.Drawing.Size(343, 76);
            this.txtboxNombreSesion.TabIndex = 2;
            // 
            // txtboxContraseña
            // 
            this.txtboxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContraseña.Location = new System.Drawing.Point(489, 310);
            this.txtboxContraseña.Multiline = true;
            this.txtboxContraseña.Name = "txtboxContraseña";
            this.txtboxContraseña.PasswordChar = '*';
            this.txtboxContraseña.Size = new System.Drawing.Size(354, 72);
            this.txtboxContraseña.TabIndex = 3;
            this.txtboxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.BackColor = System.Drawing.Color.SlateBlue;
            this.botonIniciarSesion.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciarSesion.Location = new System.Drawing.Point(1106, 377);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(175, 91);
            this.botonIniciarSesion.TabIndex = 4;
            this.botonIniciarSesion.Text = "Iniciar ";
            this.botonIniciarSesion.UseVisualStyleBackColor = false;
            this.botonIniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Igrese nombre de usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese contraseña";
            // 
            // label_crear_cuenta_
            // 
            this.label_crear_cuenta_.AutoSize = true;
            this.label_crear_cuenta_.BackColor = System.Drawing.Color.Transparent;
            this.label_crear_cuenta_.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_crear_cuenta_.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label_crear_cuenta_.Location = new System.Drawing.Point(502, 463);
            this.label_crear_cuenta_.Name = "label_crear_cuenta_";
            this.label_crear_cuenta_.Size = new System.Drawing.Size(180, 20);
            this.label_crear_cuenta_.TabIndex = 7;
            this.label_crear_cuenta_.Text = "No tienes cuenta ? haz ";
            this.label_crear_cuenta_.Click += new System.EventHandler(this.label3_Click);
            // 
            // click_para_registrar
            // 
            this.click_para_registrar.AutoSize = true;
            this.click_para_registrar.BackColor = System.Drawing.Color.Transparent;
            this.click_para_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_para_registrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.click_para_registrar.Location = new System.Drawing.Point(683, 463);
            this.click_para_registrar.Name = "click_para_registrar";
            this.click_para_registrar.Size = new System.Drawing.Size(84, 20);
            this.click_para_registrar.TabIndex = 8;
            this.click_para_registrar.Text = "click aqui ";
            this.click_para_registrar.Click += new System.EventHandler(this.click_para_registrar_Click);
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario_Barron.Properties.Resources._12682__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 531);
            this.Controls.Add(this.click_para_registrar);
            this.Controls.Add(this.label_crear_cuenta_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.txtboxContraseña);
            this.Controls.Add(this.txtboxNombreSesion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Login de inicio ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtboxNombreSesion;
        private System.Windows.Forms.TextBox txtboxContraseña;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_crear_cuenta_;
        private System.Windows.Forms.Label click_para_registrar;
    }
}

