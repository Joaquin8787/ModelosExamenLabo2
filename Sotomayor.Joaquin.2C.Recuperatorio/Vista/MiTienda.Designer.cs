namespace Vista
{
    partial class MiTienda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTalle = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(12, 386);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(193, 52);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(84, 32);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 23);
            this.cmbProducto.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 104);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 15;
            this.lstProductos.Location = new System.Drawing.Point(211, 1);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(417, 439);
            this.lstProductos.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(84, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 23);
            this.txtModelo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(193, 52);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTalle
            // 
            this.cmbTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalle.FormattingEnabled = true;
            this.cmbTalle.Location = new System.Drawing.Point(84, 68);
            this.cmbTalle.Name = "cmbTalle";
            this.cmbTalle.Size = new System.Drawing.Size(121, 23);
            this.cmbTalle.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Producto";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Location = new System.Drawing.Point(12, 68);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(30, 15);
            this.lblTalle.TabIndex = 8;
            this.lblTalle.Text = "Talle";
            // 
            // MiTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 449);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbTalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnQuitar);
            this.Name = "MiTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de Joaquin Sotomayor";
            this.Load += new System.EventHandler(this.MiTienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTalle;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTalle;
    }
}
