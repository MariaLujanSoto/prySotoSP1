﻿namespace prySotoSP1
{
    partial class frmMain
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
            this.btnCrearArch = new System.Windows.Forms.Button();
            this.btnLeerArch = new System.Windows.Forms.Button();
            this.btnGrabarArch = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCrearArch
            // 
            this.btnCrearArch.Location = new System.Drawing.Point(32, 245);
            this.btnCrearArch.Name = "btnCrearArch";
            this.btnCrearArch.Size = new System.Drawing.Size(198, 48);
            this.btnCrearArch.TabIndex = 0;
            this.btnCrearArch.Text = "Crear Archivo";
            this.btnCrearArch.UseVisualStyleBackColor = true;
            this.btnCrearArch.Click += new System.EventHandler(this.btnCrearArch_Click);
            // 
            // btnLeerArch
            // 
            this.btnLeerArch.Location = new System.Drawing.Point(359, 245);
            this.btnLeerArch.Name = "btnLeerArch";
            this.btnLeerArch.Size = new System.Drawing.Size(198, 48);
            this.btnLeerArch.TabIndex = 1;
            this.btnLeerArch.Text = "Leer Archivo";
            this.btnLeerArch.UseVisualStyleBackColor = true;
            this.btnLeerArch.Click += new System.EventHandler(this.btnLeerArch_Click);
            // 
            // btnGrabarArch
            // 
            this.btnGrabarArch.Location = new System.Drawing.Point(198, 327);
            this.btnGrabarArch.Name = "btnGrabarArch";
            this.btnGrabarArch.Size = new System.Drawing.Size(198, 48);
            this.btnGrabarArch.TabIndex = 2;
            this.btnGrabarArch.Text = "Grabar Archivo";
            this.btnGrabarArch.UseVisualStyleBackColor = true;
            this.btnGrabarArch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(117, 62);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(344, 96);
            this.txtDatos.TabIndex = 5;
            this.txtDatos.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 423);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnGrabarArch);
            this.Controls.Add(this.btnLeerArch);
            this.Controls.Add(this.btnCrearArch);
            this.Name = "frmMain";
            this.Text = "Manejo de Archivos y Carpetas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArch;
        private System.Windows.Forms.Button btnLeerArch;
        private System.Windows.Forms.Button btnGrabarArch;
        private System.Windows.Forms.RichTextBox txtDatos;
    }
}

