namespace estacion_911
{
    partial class Empleado
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
            this.TablaPasajero = new System.Windows.Forms.DataGridView();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaPasajero
            // 
            this.TablaPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPasajero.Location = new System.Drawing.Point(34, 36);
            this.TablaPasajero.Name = "TablaPasajero";
            this.TablaPasajero.RowHeadersWidth = 51;
            this.TablaPasajero.RowTemplate.Height = 24;
            this.TablaPasajero.Size = new System.Drawing.Size(1029, 264);
            this.TablaPasajero.TabIndex = 0;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(34, 315);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(123, 33);
            this.Btn_actualizar.TabIndex = 1;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Pasajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(1033, 477);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 23);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 524);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.TablaPasajero);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPasajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPasajero;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_salir;
    }
}