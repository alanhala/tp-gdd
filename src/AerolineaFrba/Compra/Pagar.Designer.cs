﻿namespace AerolineaFrba.Compra
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimientoPasajero = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMailPasajero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefonoPasajero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionPasajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPasajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagaConTarjeta = new System.Windows.Forms.Button();
            this.btnPagaEnEfectivo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSoyCliente = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dtpFechaNacimientoPasajero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMailPasajero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefonoPasajero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDireccionPasajero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidoPasajero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombrePasajero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // dtpFechaNacimientoPasajero
            // 
            this.dtpFechaNacimientoPasajero.Location = new System.Drawing.Point(150, 169);
            this.dtpFechaNacimientoPasajero.Name = "dtpFechaNacimientoPasajero";
            this.dtpFechaNacimientoPasajero.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimientoPasajero.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // txtMailPasajero
            // 
            this.txtMailPasajero.Location = new System.Drawing.Point(222, 147);
            this.txtMailPasajero.Name = "txtMailPasajero";
            this.txtMailPasajero.Size = new System.Drawing.Size(128, 20);
            this.txtMailPasajero.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mail";
            // 
            // txtTelefonoPasajero
            // 
            this.txtTelefonoPasajero.Location = new System.Drawing.Point(222, 122);
            this.txtTelefonoPasajero.Name = "txtTelefonoPasajero";
            this.txtTelefonoPasajero.Size = new System.Drawing.Size(128, 20);
            this.txtTelefonoPasajero.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Teléfono";
            // 
            // txtDireccionPasajero
            // 
            this.txtDireccionPasajero.Location = new System.Drawing.Point(222, 97);
            this.txtDireccionPasajero.Name = "txtDireccionPasajero";
            this.txtDireccionPasajero.Size = new System.Drawing.Size(128, 20);
            this.txtDireccionPasajero.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dirección";
            // 
            // txtApellidoPasajero
            // 
            this.txtApellidoPasajero.Location = new System.Drawing.Point(222, 72);
            this.txtApellidoPasajero.Name = "txtApellidoPasajero";
            this.txtApellidoPasajero.Size = new System.Drawing.Size(128, 20);
            this.txtApellidoPasajero.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellido";
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Location = new System.Drawing.Point(222, 47);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.Size = new System.Drawing.Size(128, 20);
            this.txtNombrePasajero.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(222, 22);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(128, 20);
            this.txtDNI.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingresar DNI del Pasajero";
            // 
            // btnPagaConTarjeta
            // 
            this.btnPagaConTarjeta.Location = new System.Drawing.Point(56, 19);
            this.btnPagaConTarjeta.Name = "btnPagaConTarjeta";
            this.btnPagaConTarjeta.Size = new System.Drawing.Size(114, 23);
            this.btnPagaConTarjeta.TabIndex = 27;
            this.btnPagaConTarjeta.Text = "Tarjeta de Crédito";
            this.btnPagaConTarjeta.UseVisualStyleBackColor = true;
            this.btnPagaConTarjeta.Click += new System.EventHandler(this.btnPagaConTarjeta_Click);
            // 
            // btnPagaEnEfectivo
            // 
            this.btnPagaEnEfectivo.Location = new System.Drawing.Point(213, 19);
            this.btnPagaEnEfectivo.Name = "btnPagaEnEfectivo";
            this.btnPagaEnEfectivo.Size = new System.Drawing.Size(75, 23);
            this.btnPagaEnEfectivo.TabIndex = 28;
            this.btnPagaEnEfectivo.Text = "Efectivo";
            this.btnPagaEnEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnPagaConTarjeta);
            this.groupBox2.Controls.Add(this.btnPagaEnEfectivo);
            this.groupBox2.Location = new System.Drawing.Point(30, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 55);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo  de Pago";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(255, 350);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(161, 350);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 33;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(67, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSoyCliente
            // 
            this.btnSoyCliente.Location = new System.Drawing.Point(150, 253);
            this.btnSoyCliente.Name = "btnSoyCliente";
            this.btnSoyCliente.Size = new System.Drawing.Size(121, 23);
            this.btnSoyCliente.TabIndex = 35;
            this.btnSoyCliente.Text = "Ya soy cliente";
            this.btnSoyCliente.UseVisualStyleBackColor = true;
            this.btnSoyCliente.Click += new System.EventHandler(this.btnSoyCliente_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Image = ((System.Drawing.Image)(resources.GetObject("lblCosto.Image")));
            this.lblCosto.Location = new System.Drawing.Point(210, 25);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(0, 22);
            this.lblCosto.TabIndex = 36;
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 385);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnSoyCliente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pagar";
            this.Text = "Pagar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoPasajero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMailPasajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefonoPasajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionPasajero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPasajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombrePasajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagaConTarjeta;
        private System.Windows.Forms.Button btnPagaEnEfectivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSoyCliente;
        private System.Windows.Forms.Label lblCosto;
    }
}