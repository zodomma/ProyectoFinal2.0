﻿namespace Zodomma
{
    partial class Mesa
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
            this.btncobrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btntransferir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.clcategoria = new System.Windows.Forms.CheckedListBox();
            this.productos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnanadir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncobrar
            // 
            this.btncobrar.Location = new System.Drawing.Point(12, 12);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(75, 23);
            this.btncobrar.TabIndex = 0;
            this.btncobrar.Text = "COBRAR";
            this.btncobrar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(84, 12);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btntransferir
            // 
            this.btntransferir.Location = new System.Drawing.Point(154, 12);
            this.btntransferir.Name = "btntransferir";
            this.btntransferir.Size = new System.Drawing.Size(75, 23);
            this.btntransferir.TabIndex = 3;
            this.btntransferir.Text = "TRANSFERIR";
            this.btntransferir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(226, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANACELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // clcategoria
            // 
            this.clcategoria.FormattingEnabled = true;
            this.clcategoria.Location = new System.Drawing.Point(28, 42);
            this.clcategoria.Name = "clcategoria";
            this.clcategoria.Size = new System.Drawing.Size(120, 109);
            this.clcategoria.TabIndex = 4;
            // 
            // productos
            // 
            this.productos.FormattingEnabled = true;
            this.productos.Location = new System.Drawing.Point(172, 41);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(120, 109);
            this.productos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(28, 183);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 7;
            this.txtcantidad.Text = "1";
            // 
            // btnanadir
            // 
            this.btnanadir.Location = new System.Drawing.Point(193, 182);
            this.btnanadir.Name = "btnanadir";
            this.btnanadir.Size = new System.Drawing.Size(75, 23);
            this.btnanadir.TabIndex = 8;
            this.btnanadir.Text = "AÑADIR";
            this.btnanadir.UseVisualStyleBackColor = true;
            this.btnanadir.Click += new System.EventHandler(this.btnanadir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnanadir);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productos);
            this.Controls.Add(this.clcategoria);
            this.Controls.Add(this.btntransferir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncobrar);
            this.Name = "Mesa";
            this.Text = "Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btntransferir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckedListBox clcategoria;
        private System.Windows.Forms.CheckedListBox productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnanadir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}