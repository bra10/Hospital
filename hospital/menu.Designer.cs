namespace hospital
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApoinment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPatient,
            this.menuApoinment,
            this.menuConsultation,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPatient
            // 
            this.menuPatient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPatient.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuPatient.Image = global::hospital.Properties.Resources.patient;
            this.menuPatient.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.menuPatient.Name = "menuPatient";
            this.menuPatient.Size = new System.Drawing.Size(162, 24);
            this.menuPatient.Text = "Nuevo Paciente";
            this.menuPatient.Click += new System.EventHandler(this.menuPatient_Click);
            // 
            // menuApoinment
            // 
            this.menuApoinment.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuApoinment.Image = global::hospital.Properties.Resources.apoinment;
            this.menuApoinment.Name = "menuApoinment";
            this.menuApoinment.Size = new System.Drawing.Size(138, 24);
            this.menuApoinment.Text = "Agregar Cita";
            this.menuApoinment.Click += new System.EventHandler(this.menuApoinment_Click);
            // 
            // menuConsultation
            // 
            this.menuConsultation.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuConsultation.Image = global::hospital.Properties.Resources.consultation;
            this.menuConsultation.Name = "menuConsultation";
            this.menuConsultation.Size = new System.Drawing.Size(117, 24);
            this.menuConsultation.Text = "Consultas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salirToolStripMenuItem.Image = global::hospital.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(518, 326);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Hospital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPatient;
        private System.Windows.Forms.ToolStripMenuItem menuApoinment;
        private System.Windows.Forms.ToolStripMenuItem menuConsultation;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

