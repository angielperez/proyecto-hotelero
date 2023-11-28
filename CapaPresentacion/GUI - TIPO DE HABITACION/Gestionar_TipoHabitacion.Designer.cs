namespace CapaPresentacion.GUI___TIPO_DE_HABITACION
{
    partial class Gestionar_TipoHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_TipoHabitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcionTipoHabitacion = new System.Windows.Forms.TextBox();
            this.btnVolverCrearHabitacion = new System.Windows.Forms.Button();
            this.btnGuardarTipoHabitacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "GESTION DE TIPO DE  HABITACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescripcionTipoHabitacion);
            this.panel1.Controls.Add(this.btnVolverCrearHabitacion);
            this.panel1.Controls.Add(this.btnGuardarTipoHabitacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 211);
            this.panel1.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(469, 63);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(175, 20);
            this.txtPrecio.TabIndex = 28;
            // 
            // txtDescripcionTipoHabitacion
            // 
            this.txtDescripcionTipoHabitacion.Location = new System.Drawing.Point(117, 63);
            this.txtDescripcionTipoHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionTipoHabitacion.Name = "txtDescripcionTipoHabitacion";
            this.txtDescripcionTipoHabitacion.Size = new System.Drawing.Size(179, 20);
            this.txtDescripcionTipoHabitacion.TabIndex = 27;
            // 
            // btnVolverCrearHabitacion
            // 
            this.btnVolverCrearHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverCrearHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCrearHabitacion.Location = new System.Drawing.Point(302, 122);
            this.btnVolverCrearHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverCrearHabitacion.Name = "btnVolverCrearHabitacion";
            this.btnVolverCrearHabitacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverCrearHabitacion.TabIndex = 26;
            this.btnVolverCrearHabitacion.Text = "Volver";
            this.btnVolverCrearHabitacion.UseVisualStyleBackColor = false;
            this.btnVolverCrearHabitacion.Click += new System.EventHandler(this.btnVolverCrearHabitacion_Click);
            // 
            // btnGuardarTipoHabitacion
            // 
            this.btnGuardarTipoHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipoHabitacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGuardarTipoHabitacion.Location = new System.Drawing.Point(397, 122);
            this.btnGuardarTipoHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarTipoHabitacion.Name = "btnGuardarTipoHabitacion";
            this.btnGuardarTipoHabitacion.Size = new System.Drawing.Size(106, 38);
            this.btnGuardarTipoHabitacion.TabIndex = 25;
            this.btnGuardarTipoHabitacion.Text = "Guardar";
            this.btnGuardarTipoHabitacion.UseVisualStyleBackColor = false;
            this.btnGuardarTipoHabitacion.Click += new System.EventHandler(this.btnGuardarTipoHabitacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripciòn";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(317, 63);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 23);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Gestionar_TipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Gestionar_TipoHabitacion";
            this.Text = "Gestionar_TipoHabitacion";
            this.Load += new System.EventHandler(this.Gestionar_TipoHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcionTipoHabitacion;
        private System.Windows.Forms.Button btnVolverCrearHabitacion;
        private System.Windows.Forms.Button btnGuardarTipoHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
    }
}