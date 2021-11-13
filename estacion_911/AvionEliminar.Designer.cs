namespace estacion_911
{
    partial class AvionEliminar
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
            this.c_modelo = new System.Windows.Forms.TextBox();
            this.c_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminarAvion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_modelo
            // 
            this.c_modelo.Location = new System.Drawing.Point(252, 185);
            this.c_modelo.Name = "c_modelo";
            this.c_modelo.Size = new System.Drawing.Size(224, 22);
            this.c_modelo.TabIndex = 10;
            // 
            // c_marca
            // 
            this.c_marca.Location = new System.Drawing.Point(252, 119);
            this.c_marca.Name = "c_marca";
            this.c_marca.Size = new System.Drawing.Size(224, 22);
            this.c_marca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro de aviones";
            // 
            // btn_eliminarAvion
            // 
            this.btn_eliminarAvion.Location = new System.Drawing.Point(300, 252);
            this.btn_eliminarAvion.Name = "btn_eliminarAvion";
            this.btn_eliminarAvion.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarAvion.TabIndex = 11;
            this.btn_eliminarAvion.Text = "Eliminar";
            this.btn_eliminarAvion.UseVisualStyleBackColor = true;
            this.btn_eliminarAvion.Click += new System.EventHandler(this.btn_eliminarAvion_Click);
            // 
            // AvionEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 349);
            this.Controls.Add(this.btn_eliminarAvion);
            this.Controls.Add(this.c_modelo);
            this.Controls.Add(this.c_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvionEliminar";
            this.Text = "AvionEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_modelo;
        private System.Windows.Forms.TextBox c_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminarAvion;
    }
}