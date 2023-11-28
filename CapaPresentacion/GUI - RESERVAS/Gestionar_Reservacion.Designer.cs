namespace CapaPresentacion.GUI___RESERVAS
{
    partial class Gestionar_Reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Reservacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtNumHabitacion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumReservacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpConsultarSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpConsultarEntrada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtConsultarNom = new System.Windows.Forms.TextBox();
            this.txtConsultarTel = new System.Windows.Forms.TextBox();
            this.txtConsultarCedu = new System.Windows.Forms.TextBox();
            this.txtConsultarNumAdultos = new System.Windows.Forms.TextBox();
            this.txtConsultarNumNinos = new System.Windows.Forms.TextBox();
            this.txtConsultarCorreo = new System.Windows.Forms.TextBox();
            this.txtConsultarApell = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelEstado);
            this.panel1.Controls.Add(this.txtNumHabitacion);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelValor);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtNumReservacion);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpConsultarSalida);
            this.panel1.Controls.Add(this.dtpConsultarEntrada);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.txtConsultarNom);
            this.panel1.Controls.Add(this.txtConsultarTel);
            this.panel1.Controls.Add(this.txtConsultarCedu);
            this.panel1.Controls.Add(this.txtConsultarNumAdultos);
            this.panel1.Controls.Add(this.txtConsultarNumNinos);
            this.panel1.Controls.Add(this.txtConsultarCorreo);
            this.panel1.Controls.Add(this.txtConsultarApell);
            this.panel1.Location = new System.Drawing.Point(-7, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 393);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(300, 230);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(106, 24);
            this.labelEstado.TabIndex = 42;
            this.labelEstado.Text = "ESTADO: ";
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.FormattingEnabled = true;
            this.txtNumHabitacion.Location = new System.Drawing.Point(48, 149);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(233, 21);
            this.txtNumHabitacion.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(467, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(304, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Cancelar reserva";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(237, 267);
            this.labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(227, 29);
            this.labelValor.TabIndex = 38;
            this.labelValor.Text = "TOTAL A PAGAR: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "N° HABITACION";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(214, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "NÚMERO RESERVACION";
            // 
            // txtNumReservacion
            // 
            this.txtNumReservacion.Location = new System.Drawing.Point(46, 30);
            this.txtNumReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumReservacion.Name = "txtNumReservacion";
            this.txtNumReservacion.Size = new System.Drawing.Size(165, 20);
            this.txtNumReservacion.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "CHECK-IN-DATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "CHECK-IN-DATE";
            // 
            // dtpConsultarSalida
            // 
            this.dtpConsultarSalida.Location = new System.Drawing.Point(407, 208);
            this.dtpConsultarSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dtpConsultarSalida.Name = "dtpConsultarSalida";
            this.dtpConsultarSalida.Size = new System.Drawing.Size(325, 20);
            this.dtpConsultarSalida.TabIndex = 30;
            // 
            // dtpConsultarEntrada
            // 
            this.dtpConsultarEntrada.Location = new System.Drawing.Point(47, 208);
            this.dtpConsultarEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.dtpConsultarEntrada.Name = "dtpConsultarEntrada";
            this.dtpConsultarEntrada.Size = new System.Drawing.Size(328, 20);
            this.dtpConsultarEntrada.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 76);
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
            this.label7.Location = new System.Drawing.Point(505, 134);
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
            this.label6.Location = new System.Drawing.Point(283, 134);
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
            this.label5.Location = new System.Drawing.Point(479, 76);
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
            this.label4.Location = new System.Drawing.Point(326, 76);
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
            this.label3.Location = new System.Drawing.Point(178, 76);
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
            this.label2.Location = new System.Drawing.Point(44, 76);
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
            this.btnVolver.Location = new System.Drawing.Point(173, 310);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 36);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtConsultarNom
            // 
            this.txtConsultarNom.Location = new System.Drawing.Point(46, 91);
            this.txtConsultarNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarNom.Name = "txtConsultarNom";
            this.txtConsultarNom.Size = new System.Drawing.Size(119, 20);
            this.txtConsultarNom.TabIndex = 11;
            // 
            // txtConsultarTel
            // 
            this.txtConsultarTel.Location = new System.Drawing.Point(619, 91);
            this.txtConsultarTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarTel.Name = "txtConsultarTel";
            this.txtConsultarTel.Size = new System.Drawing.Size(113, 20);
            this.txtConsultarTel.TabIndex = 19;
            // 
            // txtConsultarCedu
            // 
            this.txtConsultarCedu.Location = new System.Drawing.Point(329, 91);
            this.txtConsultarCedu.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarCedu.Name = "txtConsultarCedu";
            this.txtConsultarCedu.Size = new System.Drawing.Size(135, 20);
            this.txtConsultarCedu.TabIndex = 12;
            // 
            // txtConsultarNumAdultos
            // 
            this.txtConsultarNumAdultos.Location = new System.Drawing.Point(286, 149);
            this.txtConsultarNumAdultos.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarNumAdultos.Name = "txtConsultarNumAdultos";
            this.txtConsultarNumAdultos.Size = new System.Drawing.Size(215, 20);
            this.txtConsultarNumAdultos.TabIndex = 13;
            // 
            // txtConsultarNumNinos
            // 
            this.txtConsultarNumNinos.Location = new System.Drawing.Point(508, 149);
            this.txtConsultarNumNinos.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarNumNinos.Name = "txtConsultarNumNinos";
            this.txtConsultarNumNinos.Size = new System.Drawing.Size(224, 20);
            this.txtConsultarNumNinos.TabIndex = 17;
            // 
            // txtConsultarCorreo
            // 
            this.txtConsultarCorreo.Location = new System.Drawing.Point(482, 91);
            this.txtConsultarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarCorreo.Name = "txtConsultarCorreo";
            this.txtConsultarCorreo.Size = new System.Drawing.Size(130, 20);
            this.txtConsultarCorreo.TabIndex = 16;
            // 
            // txtConsultarApell
            // 
            this.txtConsultarApell.Location = new System.Drawing.Point(181, 91);
            this.txtConsultarApell.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarApell.Name = "txtConsultarApell";
            this.txtConsultarApell.Size = new System.Drawing.Size(132, 20);
            this.txtConsultarApell.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "GESTIONAR RESERVACIÓN";
            // 
            // Gestionar_Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(761, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestionar_Reservacion";
            this.Text = "Reservacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpConsultarSalida;
        private System.Windows.Forms.DateTimePicker dtpConsultarEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtConsultarNom;
        private System.Windows.Forms.TextBox txtConsultarTel;
        private System.Windows.Forms.TextBox txtConsultarCedu;
        private System.Windows.Forms.TextBox txtConsultarNumAdultos;
        private System.Windows.Forms.TextBox txtConsultarNumNinos;
        private System.Windows.Forms.TextBox txtConsultarCorreo;
        private System.Windows.Forms.TextBox txtConsultarApell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumReservacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtNumHabitacion;
        private System.Windows.Forms.Label labelEstado;
    }
}