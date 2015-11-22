namespace AerolineaFrba.Abm_Rol
{
    partial class quitarFuncionalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quitarFuncionalidad));
            this.seleccionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvShowRoles = new System.Windows.Forms.DataGridView();
            this.nombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(415, 105);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 57;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvShowRoles
            // 
            this.dgvShowRoles.AllowUserToAddRows = false;
            this.dgvShowRoles.AllowUserToDeleteRows = false;
            this.dgvShowRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreRol,
            this.funcionalidad});
            this.dgvShowRoles.Location = new System.Drawing.Point(22, 145);
            this.dgvShowRoles.MultiSelect = false;
            this.dgvShowRoles.Name = "dgvShowRoles";
            this.dgvShowRoles.ReadOnly = true;
            this.dgvShowRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowRoles.Size = new System.Drawing.Size(468, 164);
            this.dgvShowRoles.TabIndex = 58;
            this.dgvShowRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowRoles_CellContentClick);
            // 
            // nombreRol
            // 
            this.nombreRol.HeaderText = "Nombre Rol";
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.ReadOnly = true;
            // 
            // funcionalidad
            // 
            this.funcionalidad.HeaderText = "Funcionalidad";
            this.funcionalidad.Name = "funcionalidad";
            this.funcionalidad.ReadOnly = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(205, 27);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 56;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(83, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(22, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 82);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la funcionalidad que desee dar de baja";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // quitarFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.dgvShowRoles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quitarFuncionalidad";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvShowRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidad;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}