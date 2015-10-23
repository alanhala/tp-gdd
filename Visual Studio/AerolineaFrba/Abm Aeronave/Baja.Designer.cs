namespace AerolineaFrba.Abm_Aeronave
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumeroMatricula = new System.Windows.Forms.ComboBox();
            this.cbRazon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaReinicioServicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFueraServicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(529, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDarDeBaja.Location = new System.Drawing.Point(624, 245);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.btnDarDeBaja.TabIndex = 27;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha de reinicio de servicio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Razon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número de matrícula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbNumeroMatricula
            // 
            this.cbNumeroMatricula.FormattingEnabled = true;
            this.cbNumeroMatricula.Location = new System.Drawing.Point(134, 30);
            this.cbNumeroMatricula.Name = "cbNumeroMatricula";
            this.cbNumeroMatricula.Size = new System.Drawing.Size(100, 21);
            this.cbNumeroMatricula.TabIndex = 30;
            // 
            // cbRazon
            // 
            this.cbRazon.FormattingEnabled = true;
            this.cbRazon.Items.AddRange(new object[] {
            "xñc,x4x",
            "xx",
            "x",
            "x",
            "x"});
            this.cbRazon.Location = new System.Drawing.Point(134, 59);
            this.cbRazon.Name = "cbRazon";
            this.cbRazon.Size = new System.Drawing.Size(100, 21);
            this.cbRazon.TabIndex = 31;
            this.cbRazon.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de fuera de servicio";
            // 
            // dtpFechaReinicioServicio
            // 
            this.dtpFechaReinicioServicio.Location = new System.Drawing.Point(414, 33);
            this.dtpFechaReinicioServicio.Name = "dtpFechaReinicioServicio";
            this.dtpFechaReinicioServicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReinicioServicio.TabIndex = 32;
            // 
            // dtpFechaFueraServicio
            // 
            this.dtpFechaFueraServicio.Location = new System.Drawing.Point(414, 56);
            this.dtpFechaFueraServicio.Name = "dtpFechaFueraServicio";
            this.dtpFechaFueraServicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFueraServicio.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.cbNumeroMatricula);
            this.groupBox1.Controls.Add(this.dtpFechaFueraServicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaReinicioServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbRazon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 151);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes campos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Suspender aeronave";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(22, 105);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(212, 40);
            this.tbDescripcion.TabIndex = 34;
            // 
            // Baja
            // 
            this.AcceptButton = this.btnDarDeBaja;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDarDeBaja;
            this.ClientSize = new System.Drawing.Size(711, 278);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDarDeBaja);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baja";
            this.Text = "Aeronave";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumeroMatricula;
        private System.Windows.Forms.ComboBox cbRazon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaReinicioServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFueraServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}