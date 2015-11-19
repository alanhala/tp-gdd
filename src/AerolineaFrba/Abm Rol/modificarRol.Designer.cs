namespace AerolineaFrba.Abm_Rol
{
    partial class ModificarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarRol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.quitarFuncionalidad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 81);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el rol que desea modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 31);
            this.button1.TabIndex = 56;
            this.button1.Text = "Agregar funcionalidad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // quitarFuncionalidad
            // 
            this.quitarFuncionalidad.Location = new System.Drawing.Point(35, 170);
            this.quitarFuncionalidad.Name = "quitarFuncionalidad";
            this.quitarFuncionalidad.Size = new System.Drawing.Size(269, 31);
            this.quitarFuncionalidad.TabIndex = 57;
            this.quitarFuncionalidad.Text = "Quitar funcionalidad";
            this.quitarFuncionalidad.UseVisualStyleBackColor = true;
            this.quitarFuncionalidad.Click += new System.EventHandler(this.quitarFuncionalidad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 31);
            this.button3.TabIndex = 58;
            this.button3.Text = "Cambiar el nombre del rol";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(114, 32);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(121, 21);
            this.cbNombre.TabIndex = 33;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.quitarFuncionalidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quitarFuncionalidad;
        private System.Windows.Forms.Button button3;
    }
}