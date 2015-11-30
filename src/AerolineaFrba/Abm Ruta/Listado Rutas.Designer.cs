using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    partial class Listado_Rutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Rutas));
            this.listadoDeRutas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDeRutas
            // 
            this.listadoDeRutas.AllowUserToAddRows = false;
            this.listadoDeRutas.AllowUserToDeleteRows = false;
            this.listadoDeRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDeRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.tipoServicio,
            this.destino,
            this.origen});
            this.listadoDeRutas.Location = new System.Drawing.Point(221, 64);
            this.listadoDeRutas.Name = "listadoDeRutas";
            this.listadoDeRutas.ReadOnly = true;
            this.listadoDeRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDeRutas.Size = new System.Drawing.Size(535, 246);
            this.listadoDeRutas.TabIndex = 0;
            this.listadoDeRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDeRutas_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(423, 316);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 48);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Ruta";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.seleccionarRuta_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            this.tipoServicio.Width = 150;
            // 
            // destino
            // 
            this.destino.HeaderText = "Ciudad Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            this.destino.Width = 140;
            // 
            // origen
            // 
            this.origen.HeaderText = "Ciudad Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rutas Existentes";
            // 
            // Listado_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.listadoDeRutas);
            this.Name = "Listado_Rutas";
            this.Text = "Listado de rutas aéreas";
            this.Load += new System.EventHandler(this.Listado_Rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoDeRutas;
        private Button btnModificar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn tipoServicio;
        private DataGridViewTextBoxColumn destino;
        private DataGridViewTextBoxColumn origen;
        private Label label1;
    }
}