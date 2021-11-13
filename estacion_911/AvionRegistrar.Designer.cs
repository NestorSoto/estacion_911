namespace estacion_911
{
    partial class AvionRegistrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c_marca = new System.Windows.Forms.TextBox();
            this.c_modelo = new System.Windows.Forms.TextBox();
            this.c_capacidad = new System.Windows.Forms.TextBox();
            this.btn_registrarAvion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de aviones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // c_marca
            // 
            this.c_marca.Location = new System.Drawing.Point(227, 100);
            this.c_marca.Name = "c_marca";
            this.c_marca.Size = new System.Drawing.Size(224, 22);
            this.c_marca.TabIndex = 4;
            // 
            // c_modelo
            // 
            this.c_modelo.Location = new System.Drawing.Point(227, 166);
            this.c_modelo.Name = "c_modelo";
            this.c_modelo.Size = new System.Drawing.Size(224, 22);
            this.c_modelo.TabIndex = 5;
            // 
            // c_capacidad
            // 
            this.c_capacidad.Location = new System.Drawing.Point(227, 222);
            this.c_capacidad.Name = "c_capacidad";
            this.c_capacidad.Size = new System.Drawing.Size(224, 22);
            this.c_capacidad.TabIndex = 6;
            // 
            // btn_registrarAvion
            // 
            this.btn_registrarAvion.Location = new System.Drawing.Point(227, 280);
            this.btn_registrarAvion.Name = "btn_registrarAvion";
            this.btn_registrarAvion.Size = new System.Drawing.Size(200, 23);
            this.btn_registrarAvion.TabIndex = 7;
            this.btn_registrarAvion.Text = "Registrar";
            this.btn_registrarAvion.UseVisualStyleBackColor = true;
            this.btn_registrarAvion.Click += new System.EventHandler(this.btn_registrarAvion_Click);
            // 
            // AvionRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.btn_registrarAvion);
            this.Controls.Add(this.c_capacidad);
            this.Controls.Add(this.c_modelo);
            this.Controls.Add(this.c_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvionRegistrar";
            this.Text = "AvionRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_marca;
        private System.Windows.Forms.TextBox c_modelo;
        private System.Windows.Forms.TextBox c_capacidad;
        private System.Windows.Forms.Button btn_registrarAvion;
    }
}