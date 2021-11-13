namespace estacion_911
{
    partial class AdministradorF
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
            this.btn_rutas = new System.Windows.Forms.Button();
            this.btn_ciudades = new System.Windows.Forms.Button();
            this.btn_Avion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rutas
            // 
            this.btn_rutas.Location = new System.Drawing.Point(180, 117);
            this.btn_rutas.Name = "btn_rutas";
            this.btn_rutas.Size = new System.Drawing.Size(138, 23);
            this.btn_rutas.TabIndex = 1;
            this.btn_rutas.Text = "Gestionar rutas";
            this.btn_rutas.UseVisualStyleBackColor = true;
            this.btn_rutas.Click += new System.EventHandler(this.btn_rutas_Click);
            // 
            // btn_ciudades
            // 
            this.btn_ciudades.Location = new System.Drawing.Point(180, 160);
            this.btn_ciudades.Name = "btn_ciudades";
            this.btn_ciudades.Size = new System.Drawing.Size(149, 23);
            this.btn_ciudades.TabIndex = 2;
            this.btn_ciudades.Text = "Gestionar cuidades";
            this.btn_ciudades.UseVisualStyleBackColor = true;
            this.btn_ciudades.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Avion
            // 
            this.btn_Avion.Location = new System.Drawing.Point(180, 73);
            this.btn_Avion.Name = "btn_Avion";
            this.btn_Avion.Size = new System.Drawing.Size(138, 23);
            this.btn_Avion.TabIndex = 3;
            this.btn_Avion.Text = "Gestionar Aviones";
            this.btn_Avion.UseVisualStyleBackColor = true;
            this.btn_Avion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdministradorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 273);
            this.Controls.Add(this.btn_Avion);
            this.Controls.Add(this.btn_ciudades);
            this.Controls.Add(this.btn_rutas);
            this.Name = "AdministradorF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_rutas;
        private System.Windows.Forms.Button btn_ciudades;
        private System.Windows.Forms.Button btn_Avion;
    }
}