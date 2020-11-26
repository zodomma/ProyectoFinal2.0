namespace Zodomma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnanadir = new System.Windows.Forms.Button();
            this.dgListarProductos = new System.Windows.Forms.DataGridView();
            this.lbCategoria = new System.Windows.Forms.ListBox();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.aa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProductos)).BeginInit();
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
            // dgListarProductos
            // 
            this.dgListarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aa,
            this.Cantidad,
            this.Precio,
            this.total});
            this.dgListarProductos.Location = new System.Drawing.Point(12, 209);
            this.dgListarProductos.Name = "dgListarProductos";
            this.dgListarProductos.Size = new System.Drawing.Size(425, 150);
            this.dgListarProductos.TabIndex = 9;
            // 
            // lbCategoria
            // 
            this.lbCategoria.FormattingEnabled = true;
            this.lbCategoria.Location = new System.Drawing.Point(12, 41);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(120, 95);
            this.lbCategoria.TabIndex = 12;
            this.lbCategoria.SelectedIndexChanged += new System.EventHandler(this.lbCategoria_SelectedIndexChanged);
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(226, 41);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(120, 95);
            this.lbProductos.TabIndex = 13;
            // 
            // aa
            // 
            this.aa.HeaderText = "Producto";
            this.aa.Name = "aa";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.dgListarProductos);
            this.Controls.Add(this.btnanadir);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntransferir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncobrar);
            this.Name = "Mesa";
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.Mesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btntransferir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnanadir;
        private System.Windows.Forms.DataGridView dgListarProductos;
        private System.Windows.Forms.ListBox lbCategoria;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn aa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label2;
    }
}