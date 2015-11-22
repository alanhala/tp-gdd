namespace AerolineaFrba.Abm_Rol
{
    partial class modificarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarRol));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.modificarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShowRoles = new System.Windows.Forms.DataGridView();
            this.nombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.agregarFuncionalidad = new System.Windows.Forms.Button();
            this.quitarFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(22, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de modificación que desee realizar";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(244, 417);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // modificarNombre
            // 
            this.modificarNombre.Location = new System.Drawing.Point(26, 365);
            this.modificarNombre.Name = "modificarNombre";
            this.modificarNombre.Size = new System.Drawing.Size(156, 27);
            this.modificarNombre.TabIndex = 5;
            this.modificarNombre.Text = "Modificar el nombre de un rol";
            this.modificarNombre.UseVisualStyleBackColor = true;
            this.modificarNombre.Click += new System.EventHandler(this.modificarNombre_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el rol que desea modificar";
            // 
            // dgvShowRoles
            // 
            this.dgvShowRoles.AllowUserToAddRows = false;
            this.dgvShowRoles.AllowUserToDeleteRows = false;
            this.dgvShowRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreRol});
            this.dgvShowRoles.Location = new System.Drawing.Point(26, 146);
            this.dgvShowRoles.MultiSelect = false;
            this.dgvShowRoles.Name = "dgvShowRoles";
            this.dgvShowRoles.ReadOnly = true;
            this.dgvShowRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowRoles.Size = new System.Drawing.Size(208, 155);
            this.dgvShowRoles.TabIndex = 59;
            this.dgvShowRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowRoles_CellContentClick);
            // 
            // nombreRol
            // 
            this.nombreRol.HeaderText = "Nombre Rol";
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 82);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(83, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
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
            // agregarFuncionalidad
            // 
            this.agregarFuncionalidad.Location = new System.Drawing.Point(209, 365);
            this.agregarFuncionalidad.Name = "agregarFuncionalidad";
            this.agregarFuncionalidad.Size = new System.Drawing.Size(156, 27);
            this.agregarFuncionalidad.TabIndex = 62;
            this.agregarFuncionalidad.Text = "Agregar una funcionalidad";
            this.agregarFuncionalidad.UseVisualStyleBackColor = true;
            this.agregarFuncionalidad.Click += new System.EventHandler(this.agregarFuncionalidad_Click);
            // 
            // quitarFunc
            // 
            this.quitarFunc.Location = new System.Drawing.Point(392, 365);
            this.quitarFunc.Name = "quitarFunc";
            this.quitarFunc.Size = new System.Drawing.Size(156, 27);
            this.quitarFunc.TabIndex = 63;
            this.quitarFunc.Text = "Quitar una funcionalidad";
            this.quitarFunc.UseVisualStyleBackColor = true;
            this.quitarFunc.Click += new System.EventHandler(this.quitarFunc_Click);
            // 
            // modificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 451);
            this.Controls.Add(this.quitarFunc);
            this.Controls.Add(this.agregarFuncionalidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShowRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificarNombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label1);
            this.Name = "modificarRol";
            this.Text = "Modificar Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button modificarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShowRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button agregarFuncionalidad;
        private System.Windows.Forms.Button quitarFunc;
    }
}