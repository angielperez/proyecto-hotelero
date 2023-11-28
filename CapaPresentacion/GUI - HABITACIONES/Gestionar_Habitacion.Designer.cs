namespace CapaPresentacion.GUI___HABITACIONES
{
    partial class Gestionar_Habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Habitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumHabitacion = new System.Windows.Forms.NumericUpDown();
            this.listaEstado = new System.Windows.Forms.ComboBox();
            this.listaTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarHabitacion = new System.Windows.Forms.Button();
            this.btnVolverConsultaHabitacion = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "GESTIONAR HABITACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNumHabitacion);
            this.panel1.Controls.Add(this.listaEstado);
            this.panel1.Controls.Add(this.listaTipoHabitacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConsultarHabitacion);
            this.panel1.Controls.Add(this.btnVolverConsultaHabitacion);
            this.panel1.Location = new System.Drawing.Point(-5, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 402);
            this.panel1.TabIndex = 9;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(41, 289);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(52, 15);
            this.labelPrecio.TabIndex = 29;
            this.labelPrecio.Text = "Precio:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Location = new System.Drawing.Point(44, 43);
            this.txtNumHabitacion.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(187, 20);
            this.txtNumHabitacion.TabIndex = 27;
            // 
            // listaEstado
            // 
            this.listaEstado.FormattingEnabled = true;
            this.listaEstado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.listaEstado.Location = new System.Drawing.Point(561, 42);
            this.listaEstado.Name = "listaEstado";
            this.listaEstado.Size = new System.Drawing.Size(172, 21);
            this.listaEstado.TabIndex = 26;
            // 
            // listaTipoHabitacion
            // 
            this.listaTipoHabitacion.FormattingEnabled = true;
            this.listaTipoHabitacion.Location = new System.Drawing.Point(326, 41);
            this.listaTipoHabitacion.Name = "listaTipoHabitacion";
            this.listaTipoHabitacion.Size = new System.Drawing.Size(190, 21);
            this.listaTipoHabitacion.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(43, 87);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(4, 400);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(690, 200);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(690, 200);
            this.txtDescripcion.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(558, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número de habitación";
            // 
            // btnConsultarHabitacion
            // 
            this.btnConsultarHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarHabitacion.Location = new System.Drawing.Point(236, 41);
            this.btnConsultarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarHabitacion.Name = "btnConsultarHabitacion";
            this.btnConsultarHabitacion.Size = new System.Drawing.Size(60, 25);
            this.btnConsultarHabitacion.TabIndex = 18;
            this.btnConsultarHabitacion.Text = "Buscar";
            this.btnConsultarHabitacion.UseVisualStyleBackColor = false;
            this.btnConsultarHabitacion.Click += new System.EventHandler(this.btnConsultarHabitacion_Click);
            // 
            // btnVolverConsultaHabitacion
            // 
            this.btnVolverConsultaHabitacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverConsultaHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverConsultaHabitacion.Location = new System.Drawing.Point(479, 309);
            this.btnVolverConsultaHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverConsultaHabitacion.Name = "btnVolverConsultaHabitacion";
            this.btnVolverConsultaHabitacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverConsultaHabitacion.TabIndex = 15;
            this.btnVolverConsultaHabitacion.Text = "Volver";
            this.btnVolverConsultaHabitacion.UseVisualStyleBackColor = false;
            this.btnVolverConsultaHabitacion.Click += new System.EventHandler(this.btnVolverConsultaHabitacion_Click);
            // 
            // Gestionar_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(763, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestionar_Habitacion";
            this.Text = "Gestionar_Habitacion";
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
        private System.Windows.Forms.Button btnVolverConsultaHabitacion;
        private System.Windows.Forms.Button btnConsultarHabitacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtNumHabitacion;
        private System.Windows.Forms.ComboBox listaEstado;
        private System.Windows.Forms.ComboBox listaTipoHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrecio;
    }
}