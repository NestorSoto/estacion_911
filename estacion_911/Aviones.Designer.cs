namespace estacion_911
{
    partial class Aviones
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.DataGridView();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avionMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.avionMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoGenerateColumns = false;
            this.panel1.CausesValidation = false;
            this.panel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capacidadDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn});
            this.panel1.DataSource = this.avionMBindingSource;
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.RowHeadersWidth = 51;
            this.panel1.RowTemplate.Height = 24;
            this.panel1.Size = new System.Drawing.Size(776, 269);
            this.panel1.TabIndex = 2;
            this.panel1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panel1_CellContentClick);
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            this.capacidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // avionMBindingSource
            // 
            this.avionMBindingSource.DataSource = typeof(estacion_911.Modelos.AvionM);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(430, 371);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(244, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // avionMBindingSource1
            // 
            this.avionMBindingSource1.DataSource = typeof(estacion_911.Modelos.AvionM);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrar nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Aviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Aviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviones";
            this.Load += new System.EventHandler(this.Aviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionMBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource avionMBindingSource;
        private System.Windows.Forms.DataGridView panel1;
        private System.Windows.Forms.BindingSource avionMBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}