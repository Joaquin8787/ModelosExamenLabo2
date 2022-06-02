namespace Vista
{
    partial class FrmAtencion
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
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(12, 304);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(452, 163);
            this.rtbInfoMedico.TabIndex = 0;
            this.rtbInfoMedico.Text = "";
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(12, 24);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(223, 274);
            this.lstMedicos.TabIndex = 1;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(12, 6);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(52, 15);
            this.lblMedicos.TabIndex = 2;
            this.lblMedicos.Text = "Medicos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(470, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 56);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(241, 24);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(223, 274);
            this.lstPacientes.TabIndex = 4;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(241, 6);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 15);
            this.lblPacientes.TabIndex = 5;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(470, 24);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(122, 56);
            this.btnAtender.TabIndex = 6;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 474);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.rtbInfoMedico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joaquin Sotomayor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfoMedico;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Button btnAtender;
    }
}
