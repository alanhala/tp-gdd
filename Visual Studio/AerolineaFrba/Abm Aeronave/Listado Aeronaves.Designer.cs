namespace AerolineaFrba.Abm_Aeronave
{
    partial class Listado_Aeronaves
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
            this.listadoAeronaves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoAeronaves
            // 
            this.listadoAeronaves.AllowUserToAddRows = false;
            this.listadoAeronaves.AllowUserToDeleteRows = false;
            this.listadoAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAeronaves.Location = new System.Drawing.Point(30, 92);
            this.listadoAeronaves.Name = "listadoAeronaves";
            this.listadoAeronaves.ReadOnly = true;
            this.listadoAeronaves.Size = new System.Drawing.Size(862, 422);
            this.listadoAeronaves.TabIndex = 0;
            // 
            // Listado_Aeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 569);
            this.Controls.Add(this.listadoAeronaves);
            this.Name = "Listado_Aeronaves";
            this.Text = "Listado_Aeronaves";
            this.Load += new System.EventHandler(this.Listado_Aeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoAeronaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoAeronaves;
    }
}