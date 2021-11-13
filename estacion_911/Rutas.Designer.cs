namespace estacion_911
{
    partial class Rutas
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
            this.tabla_rutas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_rutas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_rutas
            // 
            this.tabla_rutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_rutas.Location = new System.Drawing.Point(40, 28);
            this.tabla_rutas.Name = "tabla_rutas";
            this.tabla_rutas.RowHeadersWidth = 51;
            this.tabla_rutas.RowTemplate.Height = 24;
            this.tabla_rutas.Size = new System.Drawing.Size(1037, 339);
            this.tabla_rutas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabla_rutas);
            this.Name = "Rutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_rutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_rutas;
        private System.Windows.Forms.Button button1;
    }
}