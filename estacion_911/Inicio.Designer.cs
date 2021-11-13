namespace estacion_911
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_login = new System.Windows.Forms.TextBox();
            this.bt_salir = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesion ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // c_login
            // 
            this.c_login.Enabled = false;
            this.c_login.Location = new System.Drawing.Point(203, 187);
            this.c_login.Name = "c_login";
            this.c_login.Size = new System.Drawing.Size(186, 22);
            this.c_login.TabIndex = 3;
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(418, 341);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 23);
            this.bt_salir.TabIndex = 4;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(218, 261);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "INICIAR";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_empleado
            // 
            this.btn_empleado.Location = new System.Drawing.Point(124, 340);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(185, 23);
            this.btn_empleado.TabIndex = 6;
            this.btn_empleado.Text = "Entrar como empleado";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(521, 393);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.c_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_login;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_empleado;
    }
}

