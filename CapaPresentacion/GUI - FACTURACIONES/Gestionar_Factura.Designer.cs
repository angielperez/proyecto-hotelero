namespace CapaPresentacion.GUI___FACTURACIONES
{
    partial class Gestionar_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Factura));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.ClnNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverFacturacion = new System.Windows.Forms.Button();
            this.txtNumReserva = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.btnAnularFactura = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtInfoCliente = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(79, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "GESTIONAR FACTURACIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelEstado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtValorReserva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.btnVolverFacturacion);
            this.panel1.Controls.Add(this.txtNumReserva);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtTotalVenta);
            this.panel1.Controls.Add(this.btnAnularFactura);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtInfoCliente);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 389);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "Valor reserva";
            // 
            // txtValorReserva
            // 
            this.txtValorReserva.Location = new System.Drawing.Point(613, 275);
            this.txtValorReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorReserva.Name = "txtValorReserva";
            this.txtValorReserva.ReadOnly = true;
            this.txtValorReserva.Size = new System.Drawing.Size(105, 20);
            this.txtValorReserva.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Seleccione un producto";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumer,
            this.ClnEstado,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tabla.Location = new System.Drawing.Point(54, 100);
            this.tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersWidth = 62;
            this.tabla.RowTemplate.Height = 28;
            this.tabla.Size = new System.Drawing.Size(662, 164);
            this.tabla.TabIndex = 52;
            // 
            // ClnNumer
            // 
            this.ClnNumer.HeaderText = "ID";
            this.ClnNumer.MinimumWidth = 8;
            this.ClnNumer.Name = "ClnNumer";
            this.ClnNumer.ReadOnly = true;
            this.ClnNumer.Width = 150;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "PRODUCTO";
            this.ClnEstado.MinimumWidth = 8;
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            this.ClnEstado.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRECIO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CANTIDAD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TOTAL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnVolverFacturacion
            // 
            this.btnVolverFacturacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverFacturacion.Location = new System.Drawing.Point(512, 336);
            this.btnVolverFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverFacturacion.Name = "btnVolverFacturacion";
            this.btnVolverFacturacion.Size = new System.Drawing.Size(97, 38);
            this.btnVolverFacturacion.TabIndex = 51;
            this.btnVolverFacturacion.Text = "Volver";
            this.btnVolverFacturacion.UseVisualStyleBackColor = false;
            this.btnVolverFacturacion.Click += new System.EventHandler(this.btnVolverFacturacion_Click);
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.FormattingEnabled = true;
            this.txtNumReserva.Location = new System.Drawing.Point(54, 37);
            this.txtNumReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(70, 21);
            this.txtNumReserva.TabIndex = 47;
            this.txtNumReserva.SelectedIndexChanged += new System.EventHandler(this.txtNumReserva_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(533, 306);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 45;
            this.label13.Text = "Total Venta";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(613, 303);
            this.txtTotalVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.ReadOnly = true;
            this.txtTotalVenta.Size = new System.Drawing.Size(105, 20);
            this.txtTotalVenta.TabIndex = 39;
            // 
            // btnAnularFactura
            // 
            this.btnAnularFactura.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnularFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularFactura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAnularFactura.Location = new System.Drawing.Point(624, 336);
            this.btnAnularFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnularFactura.Name = "btnAnularFactura";
            this.btnAnularFactura.Size = new System.Drawing.Size(94, 38);
            this.btnAnularFactura.TabIndex = 12;
            this.btnAnularFactura.Text = "Anular";
            this.btnAnularFactura.UseVisualStyleBackColor = false;
            this.btnAnularFactura.Click += new System.EventHandler(this.btnAnularFactura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(512, 38);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // txtInfoCliente
            // 
            this.txtInfoCliente.Enabled = false;
            this.txtInfoCliente.Location = new System.Drawing.Point(161, 37);
            this.txtInfoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoCliente.Name = "txtInfoCliente";
            this.txtInfoCliente.Size = new System.Drawing.Size(321, 20);
            this.txtInfoCliente.TabIndex = 1;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(51, 280);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 15);
            this.labelEstado.TabIndex = 62;
            this.labelEstado.Text = "Estado: ";
            // 
            // Gestionar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Gestionar_Factura";
            this.Text = "Gestionar_Factura";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorReserva;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnVolverFacturacion;
        private System.Windows.Forms.ComboBox txtNumReserva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Button btnAnularFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtInfoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEstado;
    }
}