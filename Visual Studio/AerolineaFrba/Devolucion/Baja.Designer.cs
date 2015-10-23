namespace AerolineaFrba.Devolucion
{
    partial class Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baja));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMotivoCancelacionPasajeOEncomienda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigoPasajeOEncomienda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeroCompraPNR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucionPasajeOEncomienda = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Devolución/Cancelación de Pasaje o Encomienda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMotivoCancelacionPasajeOEncomienda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCodigoPasajeOEncomienda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNumeroCompraPNR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFechaDevolucionPasajeOEncomienda);
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 204);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de devolución o cancelación";
            // 
            // tbMotivoCancelacionPasajeOEncomienda
            // 
            this.tbMotivoCancelacionPasajeOEncomienda.Location = new System.Drawing.Point(13, 131);
            this.tbMotivoCancelacionPasajeOEncomienda.Multiline = true;
            this.tbMotivoCancelacionPasajeOEncomienda.Name = "tbMotivoCancelacionPasajeOEncomienda";
            this.tbMotivoCancelacionPasajeOEncomienda.Size = new System.Drawing.Size(352, 55);
            this.tbMotivoCancelacionPasajeOEncomienda.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Motivo de cancelación";
            // 
            // tbCodigoPasajeOEncomienda
            // 
            this.tbCodigoPasajeOEncomienda.Location = new System.Drawing.Point(237, 78);
            this.tbCodigoPasajeOEncomienda.Name = "tbCodigoPasajeOEncomienda";
            this.tbCodigoPasajeOEncomienda.Size = new System.Drawing.Size(128, 20);
            this.tbCodigoPasajeOEncomienda.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código de Pasaje y/o Encomienda";
            // 
            // tbNumeroCompraPNR
            // 
            this.tbNumeroCompraPNR.Location = new System.Drawing.Point(237, 48);
            this.tbNumeroCompraPNR.Name = "tbNumeroCompraPNR";
            this.tbNumeroCompraPNR.Size = new System.Drawing.Size(128, 20);
            this.tbNumeroCompraPNR.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de compra o PNR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fecha de devolución";
            // 
            // dtpFechaDevolucionPasajeOEncomienda
            // 
            this.dtpFechaDevolucionPasajeOEncomienda.Location = new System.Drawing.Point(165, 19);
            this.dtpFechaDevolucionPasajeOEncomienda.Name = "dtpFechaDevolucionPasajeOEncomienda";
            this.dtpFechaDevolucionPasajeOEncomienda.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDevolucionPasajeOEncomienda.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(332, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpiar.Location = new System.Drawing.Point(238, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpiar;
            this.ClientSize = new System.Drawing.Size(440, 335);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Baja";
            this.Text = "Pasaje/Encomienda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMotivoCancelacionPasajeOEncomienda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigoPasajeOEncomienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeroCompraPNR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucionPasajeOEncomienda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}