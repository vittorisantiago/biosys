﻿namespace biosys
{
    partial class Recolecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recolecciones));
            this.label10 = new System.Windows.Forms.Label();
            this.listDetalleRecoleccion = new System.Windows.Forms.ListBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaRecoleccion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new biosys.RoundedButton();
            this.btnCancelar = new biosys.RoundedButton();
            this.btnGuardarDetalle = new biosys.RoundedButton();
            this.btnRegistrarRecoleccion = new biosys.RoundedButton();
            this.btnHistorialRecolecciones = new biosys.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(933, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 24);
            this.label10.TabIndex = 92;
            this.label10.Text = "Detalle de recolección";
            // 
            // listDetalleRecoleccion
            // 
            this.listDetalleRecoleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetalleRecoleccion.FormattingEnabled = true;
            this.listDetalleRecoleccion.ItemHeight = 18;
            this.listDetalleRecoleccion.Location = new System.Drawing.Point(725, 203);
            this.listDetalleRecoleccion.Name = "listDetalleRecoleccion";
            this.listDetalleRecoleccion.Size = new System.Drawing.Size(610, 310);
            this.listDetalleRecoleccion.TabIndex = 91;
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(304, 203);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(336, 24);
            this.txtLugar.TabIndex = 90;
            this.txtLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(228, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Lugar de recolección:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(500, 50);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(337, 55);
            this.labelTitulo.TabIndex = 87;
            this.labelTitulo.Text = "Recolecciones";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(170, 517);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(122, 18);
            this.lblError.TabIndex = 95;
            this.lblError.Text = "Mensaje de Error";
            this.lblError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(486, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 94;
            this.label9.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(310, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(299, 16);
            this.label13.TabIndex = 93;
            this.label13.Text = "Los campos con asteriscos (      ) son obligatorios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(148, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 108;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 107;
            this.label7.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidad.Location = new System.Drawing.Point(421, 391);
            this.numericCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(90, 24);
            this.numericCantidad.TabIndex = 106;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(132, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 104;
            this.label4.Text = "Fecha:";
            // 
            // fechaRecoleccion
            // 
            this.fechaRecoleccion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRecoleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRecoleccion.Location = new System.Drawing.Point(304, 325);
            this.fechaRecoleccion.Name = "fechaRecoleccion";
            this.fechaRecoleccion.Size = new System.Drawing.Size(336, 24);
            this.fechaRecoleccion.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(151, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 101;
            this.label3.Text = "Producto:";
            // 
            // comboProductos
            // 
            this.comboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(304, 262);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(336, 26);
            this.comboProductos.TabIndex = 100;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(245, 585);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 48);
            this.btnLimpiar.TabIndex = 153;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(80, 585);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 48);
            this.btnCancelar.TabIndex = 154;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDetalle.Location = new System.Drawing.Point(410, 585);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(119, 48);
            this.btnGuardarDetalle.TabIndex = 155;
            this.btnGuardarDetalle.Text = "Guardar detalle";
            this.btnGuardarDetalle.UseVisualStyleBackColor = true;
            this.btnGuardarDetalle.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // btnRegistrarRecoleccion
            // 
            this.btnRegistrarRecoleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRecoleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRecoleccion.Location = new System.Drawing.Point(575, 585);
            this.btnRegistrarRecoleccion.Name = "btnRegistrarRecoleccion";
            this.btnRegistrarRecoleccion.Size = new System.Drawing.Size(119, 48);
            this.btnRegistrarRecoleccion.TabIndex = 156;
            this.btnRegistrarRecoleccion.Text = "Registrar recolección";
            this.btnRegistrarRecoleccion.UseVisualStyleBackColor = true;
            this.btnRegistrarRecoleccion.Click += new System.EventHandler(this.btnRegistrarRecoleccion_Click);
            this.btnRegistrarRecoleccion.MouseEnter += new System.EventHandler(this.btnRegistrarRecoleccion_MouseEnter);
            this.btnRegistrarRecoleccion.MouseLeave += new System.EventHandler(this.btnRegistrarRecoleccion_MouseLeave);
            // 
            // btnHistorialRecolecciones
            // 
            this.btnHistorialRecolecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialRecolecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialRecolecciones.Location = new System.Drawing.Point(965, 535);
            this.btnHistorialRecolecciones.Name = "btnHistorialRecolecciones";
            this.btnHistorialRecolecciones.Size = new System.Drawing.Size(119, 48);
            this.btnHistorialRecolecciones.TabIndex = 157;
            this.btnHistorialRecolecciones.Text = "Historial de recolecciones";
            this.btnHistorialRecolecciones.UseVisualStyleBackColor = true;
            this.btnHistorialRecolecciones.Click += new System.EventHandler(this.btnHistorialRecolecciones_Click);
            // 
            // Recolecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1400, 782);
            this.Controls.Add(this.btnHistorialRecolecciones);
            this.Controls.Add(this.btnRegistrarRecoleccion);
            this.Controls.Add(this.btnGuardarDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaRecoleccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listDetalleRecoleccion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recolecciones";
            this.Text = "Recolecciones";
            this.Load += new System.EventHandler(this.Recolecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listDetalleRecoleccion;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaRecoleccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProductos;
        private RoundedButton btnLimpiar;
        private RoundedButton btnCancelar;
        private RoundedButton btnGuardarDetalle;
        private RoundedButton btnRegistrarRecoleccion;
        private RoundedButton btnHistorialRecolecciones;
    }
}