namespace AerolineaFrba.Abm_Aeronave
{
    partial class AeronaveAModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AeronaveAModificar));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvModificarAeronave = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_butacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacio_encomiendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarAeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(578, 338);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvModificarAeronave
            // 
            this.dgvModificarAeronave.AllowUserToAddRows = false;
            this.dgvModificarAeronave.AllowUserToDeleteRows = false;
            this.dgvModificarAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarAeronave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.modelo,
            this.fabricante,
            this.tipo_servicio,
            this.cant_butacas,
            this.espacio_encomiendas});
            this.dgvModificarAeronave.Location = new System.Drawing.Point(12, 46);
            this.dgvModificarAeronave.MultiSelect = false;
            this.dgvModificarAeronave.Name = "dgvModificarAeronave";
            this.dgvModificarAeronave.ReadOnly = true;
            this.dgvModificarAeronave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificarAeronave.Size = new System.Drawing.Size(641, 286);
            this.dgvModificarAeronave.TabIndex = 60;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo de Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // cant_butacas
            // 
            this.cant_butacas.HeaderText = "Cantidad de Butacas";
            this.cant_butacas.Name = "cant_butacas";
            this.cant_butacas.ReadOnly = true;
            // 
            // espacio_encomiendas
            // 
            this.espacio_encomiendas.HeaderText = "Espacio para Encomiendas";
            this.espacio_encomiendas.Name = "espacio_encomiendas";
            this.espacio_encomiendas.ReadOnly = true;
            // 
            // AeronaveAModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 373);
            this.Controls.Add(this.dgvModificarAeronave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "AeronaveAModificar";
            this.Text = "Seleccionar Aeronave a Modificar";
            this.Load += new System.EventHandler(this.AeronaveAModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarAeronave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvModificarAeronave;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_butacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacio_encomiendas;
    }
}