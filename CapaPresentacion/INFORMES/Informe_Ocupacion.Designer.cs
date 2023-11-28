namespace CapaPresentacion.INFORMES
{
    partial class Informe_Ocupacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_Ocupacion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.ClnNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverInformeOcupacion = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(80, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "INFORME DE OCUPACIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.btnVolverInformeOcupacion);
            this.panel1.Location = new System.Drawing.Point(-4, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 393);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumer,
            this.ClnEstado});
            this.tabla.Location = new System.Drawing.Point(97, 23);
            this.tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersWidth = 62;
            this.tabla.RowTemplate.Height = 28;
            this.tabla.Size = new System.Drawing.Size(365, 302);
            this.tabla.TabIndex = 17;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInformeOcupacion_CellContentClick);
            // 
            // ClnNumer
            // 
            this.ClnNumer.HeaderText = "NUMERO DE HABITACIÓN";
            this.ClnNumer.MinimumWidth = 8;
            this.ClnNumer.Name = "ClnNumer";
            this.ClnNumer.ReadOnly = true;
            this.ClnNumer.Width = 150;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "ESTADO";
            this.ClnEstado.MinimumWidth = 8;
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            this.ClnEstado.Width = 150;
            // 
            // btnVolverInformeOcupacion
            // 
            this.btnVolverInformeOcupacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolverInformeOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInformeOcupacion.Location = new System.Drawing.Point(223, 339);
            this.btnVolverInformeOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverInformeOcupacion.Name = "btnVolverInformeOcupacion";
            this.btnVolverInformeOcupacion.Size = new System.Drawing.Size(91, 38);
            this.btnVolverInformeOcupacion.TabIndex = 16;
            this.btnVolverInformeOcupacion.Text = "Volver";
            this.btnVolverInformeOcupacion.UseVisualStyleBackColor = false;
            this.btnVolverInformeOcupacion.Click += new System.EventHandler(this.btnVolverInformeOcupacion_Click);
            // 
            // Informe_Ocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(548, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Informe_Ocupacion";
            this.Text = "Informe_Ocupacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolverInformeOcupacion;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstado;
    }
}