namespace AerolineaFrba.Abm_Aeronave
{
    partial class ReemplazoAeronaveFinVidaUtil
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
            this.listadoDeRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDeRutas
            // 
            this.listadoDeRutas.AllowUserToAddRows = false;
            this.listadoDeRutas.AllowUserToDeleteRows = false;
            this.listadoDeRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDeRutas.Location = new System.Drawing.Point(25, 42);
            this.listadoDeRutas.Name = "listadoDeRutas";
            this.listadoDeRutas.ReadOnly = true;
            this.listadoDeRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDeRutas.Size = new System.Drawing.Size(638, 272);
            this.listadoDeRutas.TabIndex = 1;
            this.listadoDeRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDeRutas_CellContentClick);
            // 
            // ReemplazoAeronaveFinVidaUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 363);
            this.Controls.Add(this.listadoDeRutas);
            this.Name = "ReemplazoAeronaveFinVidaUtil";
            this.Text = "Seleccionar el reemplazo de la Aeronave";
            this.Load += new System.EventHandler(this.ReemplazoAeronaveFinVidaUtil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoDeRutas;
    }
}