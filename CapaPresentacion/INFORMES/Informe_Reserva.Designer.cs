namespace CapaPresentacion.INFORMES
{
    partial class Informe_Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_Reserva));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarFactura = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.ClnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverInformeFacturacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "HISTORICO DE RESERVAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.btnConsultarFactura);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.btnVolverInformeFacturacion);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 395);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Inicio";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(339, 48);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(265, 20);
            this.dtpFechaFin.TabIndex = 20;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(11, 49);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(280, 20);
            this.dtpFechaInicio.TabIndex = 19;
            // 
            // btnConsultarFactura
            // 
            this.btnConsultarFactura.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFactura.Location = new System.Drawing.Point(630, 43);
            this.btnConsultarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarFactura.Name = "btnConsultarFactura";
            this.btnConsultarFactura.Size = new System.Drawing.Size(99, 35);
            this.btnConsultarFactura.TabIndex = 18;
            this.btnConsultarFactura.Text = "Consultar";
            this.btnConsultarFactura.UseVisualStyleBackColor = false;
            this.btnConsultarFactura.Click += new System.EventHandler(this.btnConsultarFactura_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumero,
            this.ClnTitular,
            this.ClnValor,
            this.ClnFecha,
            this.fecha_fin,
            this.num_habitacion,
            this.estado});
            this.tabla.Location = new System.Drawing.Point(10, 105);
            this.tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersWidth = 62;
            this.tabla.RowTemplate.Height = 28;
            this.tabla.Size = new System.Drawing.Size(779, 237);
            this.tabla.TabIndex = 17;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInformeFactura_CellContentClick);
            // 
            // ClnNumero
            // 
            this.ClnNumero.HeaderText = "N° RESERVA";
            this.ClnNumero.MinimumWidth = 8;
            this.ClnNumero.Name = "ClnNumero";
            this.ClnNumero.ReadOnly = true;
            this.ClnNumero.Width = 150;
            // 
            // ClnTitular
            // 
            this.ClnTitular.HeaderText = "TITULAR";
            this.ClnTitular.MinimumWidth = 8;
            this.ClnTitular.Name = "ClnTitular";
            this.ClnTitular.ReadOnly = true;
            this.ClnTitular.Width = 150;
            // 
            // ClnValor
            // 
            this.ClnValor.HeaderText = "VALOR";
            this.ClnValor.MinimumWidth = 8;
            this.ClnValor.Name = "ClnValor";
            this.ClnValor.ReadOnly = true;
            this.ClnValor.Width = 150;
            // 
            // ClnFecha
            // 
            this.ClnFecha.HeaderText = "FECHA INICIO";
            this.ClnFecha.MinimumWidth = 8;
            this.ClnFecha.Name = "ClnFecha";
            this.ClnFecha.ReadOnly = true;
            this.ClnFecha.Width = 150;
            // 
            // fecha_fin
            // 
            this.fecha_fin.HeaderText = "FECHA FIN";
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            // 
            // num_habitacion
            // 
            this.num_habitacion.HeaderText = "N° HABITACION";
            this.num_habitacion.Name = "num_habitacion";
            this.num_habitacion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnVolverInformeFacturacion
            // 
            this.btnVolverInformeFacturacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverInformeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInformeFacturacion.Location = new System.Drawing.Point(698, 346);
            this.btnVolverInformeFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverInformeFacturacion.Name = "btnVolverInformeFacturacion";
            this.btnVolverInformeFacturacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverInformeFacturacion.TabIndex = 16;
            this.btnVolverInformeFacturacion.Text = "Volver";
            this.btnVolverInformeFacturacion.UseVisualStyleBackColor = false;
            this.btnVolverInformeFacturacion.Click += new System.EventHandler(this.btnVolverInformeFacturacion_Click);
            // 
            // Informe_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Informe_Reserva";
            this.Text = "Informe_Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnConsultarFactura;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnVolverInformeFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}