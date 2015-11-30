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
            this.seleccionarRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDeRutas
            // 
            this.listadoDeRutas.AllowUserToAddRows = false;
            this.listadoDeRutas.AllowUserToDeleteRows = false;
            this.listadoDeRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDeRutas.Location = new System.Drawing.Point(130, 72);
            this.listadoDeRutas.Name = "listadoDeRutas";
            this.listadoDeRutas.ReadOnly = true;
            this.listadoDeRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDeRutas.Size = new System.Drawing.Size(659, 295);
            this.listadoDeRutas.TabIndex = 0;
            this.listadoDeRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDeRutas_CellContentClick);
            // 
            // seleccionarRuta
            // 
            this.seleccionarRuta.Location = new System.Drawing.Point(651, 396);
            this.seleccionarRuta.Name = "seleccionarRuta";
            this.seleccionarRuta.Size = new System.Drawing.Size(147, 48);
            this.seleccionarRuta.TabIndex = 1;
            this.seleccionarRuta.Text = "Seleccionar Ruta";
            this.seleccionarRuta.UseVisualStyleBackColor = true;
            this.seleccionarRuta.Click += new System.EventHandler(this.seleccionarRuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Rutas";
            // 
            // Listado_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionarRuta);
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
        private Button seleccionarRuta;
        private Label label1;
    }
}