namespace AerolineaFrba.Consulta_Millas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMillas = new System.Windows.Forms.Label();
            this.dgvDetalleMillas = new System.Windows.Forms.DataGridView();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAcumulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canjeRealizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMillas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consulta de Millas de Pasajero Frecuente";
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Location = new System.Drawing.Point(151, 30);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(128, 20);
            this.tbDNICliente.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingresar DNI del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Millas acumuladas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.Location = new System.Drawing.Point(148, 63);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(35, 13);
            this.lblMillas.TabIndex = 13;
            this.lblMillas.Text = "label4";
            // 
            // dgvDetalleMillas
            // 
            this.dgvDetalleMillas.AllowUserToAddRows = false;
            this.dgvDetalleMillas.AllowUserToDeleteRows = false;
            this.dgvDetalleMillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleMillas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.puntos,
            this.fechaAcumulacion,
            this.canjeRealizado});
            this.dgvDetalleMillas.Location = new System.Drawing.Point(65, 190);
            this.dgvDetalleMillas.Name = "dgvDetalleMillas";
            this.dgvDetalleMillas.ReadOnly = true;
            this.dgvDetalleMillas.Size = new System.Drawing.Size(339, 193);
            this.dgvDetalleMillas.TabIndex = 14;
            // 
            // puntos
            // 
            this.puntos.HeaderText = "Puntos";
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // fechaAcumulacion
            // 
            this.fechaAcumulacion.HeaderText = "Fecha en la que se acumularon";
            this.fechaAcumulacion.Name = "fechaAcumulacion";
            this.fechaAcumulacion.ReadOnly = true;
            // 
            // canjeRealizado
            // 
            this.canjeRealizado.HeaderText = "Canje realizado";
            this.canjeRealizado.Name = "canjeRealizado";
            this.canjeRealizado.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(381, 398);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDNICliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMillas);
            this.groupBox1.Location = new System.Drawing.Point(93, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 103);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes campos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpiar;
            this.ClientSize = new System.Drawing.Size(468, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvDetalleMillas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Pasajero frecuente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMillas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNICliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMillas;
        private System.Windows.Forms.DataGridView dgvDetalleMillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAcumulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn canjeRealizado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}