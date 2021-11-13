namespace estacion_911
{
    partial class CiudadAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_ciudad = new System.Windows.Forms.TextBox();
            this.c_pais = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del pais";
            // 
            // c_ciudad
            // 
            this.c_ciudad.Location = new System.Drawing.Point(421, 130);
            this.c_ciudad.Name = "c_ciudad";
            this.c_ciudad.Size = new System.Drawing.Size(226, 22);
            this.c_ciudad.TabIndex = 2;
            // 
            // c_pais
            // 
            this.c_pais.Location = new System.Drawing.Point(421, 228);
            this.c_pais.Name = "c_pais";
            this.c_pais.Size = new System.Drawing.Size(226, 22);
            this.c_pais.TabIndex = 3;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(248, 314);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(270, 54);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // CiudadAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.c_pais);
            this.Controls.Add(this.c_ciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CiudadAgregar";
            this.Text = "CiudadAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_ciudad;
        private System.Windows.Forms.TextBox c_pais;
        private System.Windows.Forms.Button btn_registrar;
    }
}