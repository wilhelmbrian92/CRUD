﻿namespace CRUD
{
    partial class Registrar_ENTRADA
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnSecretaria = new System.Windows.Forms.RadioButton();
            this.rbtnRemediar = new System.Windows.Forms.RadioButton();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 40);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(20, 200);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(62, 13);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor: ";
            // 
            // cboxProducto
            // 
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(100, 40);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(204, 21);
            this.cboxProducto.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(100, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnSecretaria
            // 
            this.rbtnSecretaria.AutoSize = true;
            this.rbtnSecretaria.Location = new System.Drawing.Point(100, 200);
            this.rbtnSecretaria.Name = "rbtnSecretaria";
            this.rbtnSecretaria.Size = new System.Drawing.Size(75, 17);
            this.rbtnSecretaria.TabIndex = 4;
            this.rbtnSecretaria.TabStop = true;
            this.rbtnSecretaria.Text = "Secretaría";
            this.rbtnSecretaria.UseVisualStyleBackColor = true;
            this.rbtnSecretaria.CheckedChanged += new System.EventHandler(this.rbtnSecretaria_CheckedChanged);
            // 
            // rbtnRemediar
            // 
            this.rbtnRemediar.AutoSize = true;
            this.rbtnRemediar.Location = new System.Drawing.Point(200, 200);
            this.rbtnRemediar.Name = "rbtnRemediar";
            this.rbtnRemediar.Size = new System.Drawing.Size(70, 17);
            this.rbtnRemediar.TabIndex = 5;
            this.rbtnRemediar.TabStop = true;
            this.rbtnRemediar.Text = "Remediar";
            this.rbtnRemediar.UseVisualStyleBackColor = true;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(20, 120);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(46, 13);
            this.lblLote.TabIndex = 6;
            this.lblLote.Text = "N° Lote:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 80);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(20, 160);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(68, 13);
            this.lblVencimiento.TabIndex = 8;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(100, 120);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(100, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(100, 160);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 11;
            // 
            // Registrar_ENTRADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 293);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.rbtnRemediar);
            this.Controls.Add(this.rbtnSecretaria);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboxProducto);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblProducto);
            this.Name = "Registrar_ENTRADA";
            this.Text = "Registrar ENTRADA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cboxProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbtnSecretaria;
        private System.Windows.Forms.RadioButton rbtnRemediar;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
    }
}