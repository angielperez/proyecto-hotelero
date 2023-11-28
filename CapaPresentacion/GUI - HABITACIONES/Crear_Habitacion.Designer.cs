namespace CapaPresentacion.GUI___HABITACIONES
{
    partial class Crear_Habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Habitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumHabitacion = new System.Windows.Forms.NumericUpDown();
            this.listaEstado = new System.Windows.Forms.ComboBox();
            this.listaTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.btnVolverCrearHabitacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarHabitacion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "REGISTRO DE HABITACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtNumHabitacion);
            this.panel1.Controls.Add(this.listaEstado);
            this.panel1.Controls.Add(this.listaTipoHabitacion);
            this.panel1.Controls.Add(this.btnVolverCrearHabitacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.btnGuardarHabitacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 393);
            this.panel1.TabIndex = 6;
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Location = new System.Drawing.Point(54, 40);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(187, 20);
            this.txtNumHabitacion.TabIndex = 19;
            // 
            // listaEstado
            // 
            this.listaEstado.FormattingEnabled = true;
            this.listaEstado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.listaEstado.Location = new System.Drawing.Point(571, 39);
            this.listaEstado.Name = "listaEstado";
            this.listaEstado.Size = new System.Drawing.Size(172, 21);
            this.listaEstado.TabIndex = 18;
            // 
            // listaTipoHabitacion
            // 
            this.listaTipoHabitacion.FormattingEnabled = true;
            this.listaTipoHabitacion.Location = new System.Drawing.Point(315, 38);
            this.listaTipoHabitacion.Name = "listaTipoHabitacion";
            this.listaTipoHabitacion.Size = new System.Drawing.Size(175, 21);
            this.listaTipoHabitacion.TabIndex = 17;
            // 
            // btnVolverCrearHabitacion
            // 
            this.btnVolverCrearHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverCrearHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCrearHabitacion.Location = new System.Drawing.Point(542, 301);
            this.btnVolverCrearHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverCrearHabitacion.Name = "btnVolverCrearHabitacion";
            this.btnVolverCrearHabitacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverCrearHabitacion.TabIndex = 16;
            this.btnVolverCrearHabitacion.Text = "Volver";
            this.btnVolverCrearHabitacion.UseVisualStyleBackColor = false;
            this.btnVolverCrearHabitacion.Click += new System.EventHandler(this.btnVolverCrearHabitacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(53, 84);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(4, 400);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(690, 200);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(690, 200);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnGuardarHabitacion
            // 
            this.btnGuardarHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHabitacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGuardarHabitacion.Location = new System.Drawing.Point(637, 301);
            this.btnGuardarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarHabitacion.Name = "btnGuardarHabitacion";
            this.btnGuardarHabitacion.Size = new System.Drawing.Size(106, 38);
            this.btnGuardarHabitacion.TabIndex = 12;
            this.btnGuardarHabitacion.Text = "Guardar";
            this.btnGuardarHabitacion.UseVisualStyleBackColor = false;
            this.btnGuardarHabitacion.Click += new System.EventHandler(this.btnGuardarHabitacion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de habitación";
            // 
            // Crear_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(761, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Crear_Habitacion";
            this.Text = "Crear_Habitacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarHabitacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnVolverCrearHabitacion;
        private System.Windows.Forms.ComboBox listaTipoHabitacion;
        private System.Windows.Forms.ComboBox listaEstado;
        private System.Windows.Forms.NumericUpDown txtNumHabitacion;
    }
}