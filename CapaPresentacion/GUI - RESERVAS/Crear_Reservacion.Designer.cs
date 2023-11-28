namespace CapaPresentacion.GUI___RESERVAS
{
    partial class Crear_Reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Reservacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaHabitaciones = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.txtNombreReservacion = new System.Windows.Forms.TextBox();
            this.txtTelReservacion = new System.Windows.Forms.TextBox();
            this.txtCedulaReservacion = new System.Windows.Forms.TextBox();
            this.txtNumAdultos = new System.Windows.Forms.TextBox();
            this.txtNumNiños = new System.Windows.Forms.TextBox();
            this.txtCorreoReservacion = new System.Windows.Forms.TextBox();
            this.txtApellidoReservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listaHabitaciones);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFechaFin);
            this.panel1.Controls.Add(this.txtFechaInicio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnGuardarReserva);
            this.panel1.Controls.Add(this.txtNombreReservacion);
            this.panel1.Controls.Add(this.txtTelReservacion);
            this.panel1.Controls.Add(this.txtCedulaReservacion);
            this.panel1.Controls.Add(this.txtNumAdultos);
            this.panel1.Controls.Add(this.txtNumNiños);
            this.panel1.Controls.Add(this.txtCorreoReservacion);
            this.panel1.Controls.Add(this.txtApellidoReservacion);
            this.panel1.Location = new System.Drawing.Point(-7, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 394);
            this.panel1.TabIndex = 0;
            // 
            // listaHabitaciones
            // 
            this.listaHabitaciones.FormattingEnabled = true;
            this.listaHabitaciones.Location = new System.Drawing.Point(476, 95);
            this.listaHabitaciones.Name = "listaHabitaciones";
            this.listaHabitaciones.Size = new System.Drawing.Size(165, 21);
            this.listaHabitaciones.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nº HABITACION";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "CHECK-OUT-DATE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "CHECK-IN-DATE";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(274, 217);
            this.txtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(165, 20);
            this.txtFechaFin.TabIndex = 30;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(72, 217);
            this.txtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(165, 20);
            this.txtFechaInicio.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "TELÉFONO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "NÚMERO DE NIÑOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "NÚMERO DE ADULTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CÉDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "NOMBRE";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(391, 322);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 44);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReserva.Location = new System.Drawing.Point(264, 322);
            this.btnGuardarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarReserva.Name = "btnGuardarReserva";
            this.btnGuardarReserva.Size = new System.Drawing.Size(98, 44);
            this.btnGuardarReserva.TabIndex = 20;
            this.btnGuardarReserva.Text = "Guardar";
            this.btnGuardarReserva.UseVisualStyleBackColor = false;
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // txtNombreReservacion
            // 
            this.txtNombreReservacion.Location = new System.Drawing.Point(72, 31);
            this.txtNombreReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreReservacion.Name = "txtNombreReservacion";
            this.txtNombreReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtNombreReservacion.TabIndex = 11;
            // 
            // txtTelReservacion
            // 
            this.txtTelReservacion.Location = new System.Drawing.Point(476, 31);
            this.txtTelReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelReservacion.Name = "txtTelReservacion";
            this.txtTelReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtTelReservacion.TabIndex = 19;
            // 
            // txtCedulaReservacion
            // 
            this.txtCedulaReservacion.Location = new System.Drawing.Point(71, 92);
            this.txtCedulaReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaReservacion.Name = "txtCedulaReservacion";
            this.txtCedulaReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtCedulaReservacion.TabIndex = 12;
            // 
            // txtNumAdultos
            // 
            this.txtNumAdultos.Location = new System.Drawing.Point(71, 158);
            this.txtNumAdultos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumAdultos.Name = "txtNumAdultos";
            this.txtNumAdultos.Size = new System.Drawing.Size(165, 20);
            this.txtNumAdultos.TabIndex = 13;
            // 
            // txtNumNiños
            // 
            this.txtNumNiños.Location = new System.Drawing.Point(274, 158);
            this.txtNumNiños.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumNiños.Name = "txtNumNiños";
            this.txtNumNiños.Size = new System.Drawing.Size(165, 20);
            this.txtNumNiños.TabIndex = 17;
            // 
            // txtCorreoReservacion
            // 
            this.txtCorreoReservacion.Location = new System.Drawing.Point(274, 92);
            this.txtCorreoReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoReservacion.Name = "txtCorreoReservacion";
            this.txtCorreoReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtCorreoReservacion.TabIndex = 16;
            // 
            // txtApellidoReservacion
            // 
            this.txtApellidoReservacion.Location = new System.Drawing.Point(274, 31);
            this.txtApellidoReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoReservacion.Name = "txtApellidoReservacion";
            this.txtApellidoReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtApellidoReservacion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESERVACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Crear_Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(793, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Crear_Reservacion";
            this.Text = "Crear_Reservacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarReserva;
        private System.Windows.Forms.TextBox txtNombreReservacion;
        private System.Windows.Forms.TextBox txtTelReservacion;
        private System.Windows.Forms.TextBox txtApellidoReservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaHabitaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedulaReservacion;
        private System.Windows.Forms.TextBox txtNumAdultos;
        private System.Windows.Forms.TextBox txtNumNiños;
        private System.Windows.Forms.TextBox txtCorreoReservacion;
    }
}