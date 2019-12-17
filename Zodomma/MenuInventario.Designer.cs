namespace Zodomma
{
    partial class MenuInventario
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
            this.gbadministrar = new System.Windows.Forms.GroupBox();
            this.categoriaactual = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.lbltituloadministrar = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbadministrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbadministrar
            // 
            this.gbadministrar.Controls.Add(this.categoriaactual);
            this.gbadministrar.Controls.Add(this.btnRegresar);
            this.gbadministrar.Controls.Add(this.txtcodigo);
            this.gbadministrar.Controls.Add(this.txtcantidad);
            this.gbadministrar.Controls.Add(this.txtprecio);
            this.gbadministrar.Controls.Add(this.txtnombre);
            this.gbadministrar.Controls.Add(this.lblcategoria);
            this.gbadministrar.Controls.Add(this.cbcategoria);
            this.gbadministrar.Controls.Add(this.lblcodigo);
            this.gbadministrar.Controls.Add(this.lblcantidad);
            this.gbadministrar.Controls.Add(this.lblprecio);
            this.gbadministrar.Controls.Add(this.lblnombreproducto);
            this.gbadministrar.Controls.Add(this.lbltituloadministrar);
            this.gbadministrar.Controls.Add(this.btnRegistrar);
            this.gbadministrar.Controls.Add(this.btnCancelar);
            this.gbadministrar.Controls.Add(this.btnActualizar);
            this.gbadministrar.Controls.Add(this.btnEliminar);
            this.gbadministrar.Location = new System.Drawing.Point(12, 165);
            this.gbadministrar.Name = "gbadministrar";
            this.gbadministrar.Size = new System.Drawing.Size(543, 256);
            this.gbadministrar.TabIndex = 15;
            this.gbadministrar.TabStop = false;
            this.gbadministrar.Text = "Administrar inventario";
            // 
            // categoriaactual
            // 
            this.categoriaactual.AutoSize = true;
            this.categoriaactual.Location = new System.Drawing.Point(185, 96);
            this.categoriaactual.Name = "categoriaactual";
            this.categoriaactual.Size = new System.Drawing.Size(0, 13);
            this.categoriaactual.TabIndex = 19;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(428, 227);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(373, 16);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 20);
            this.txtcodigo.TabIndex = 17;
            this.txtcodigo.Visible = false;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(278, 93);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(207, 20);
            this.txtcantidad.TabIndex = 16;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(278, 127);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(207, 20);
            this.txtprecio.TabIndex = 15;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(278, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(207, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(27, 163);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 16);
            this.lblcategoria.TabIndex = 13;
            this.lblcategoria.Text = "Categoria: ";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(278, 162);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(207, 21);
            this.cbcategoria.TabIndex = 12;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(275, 19);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(66, 13);
            this.lblcodigo.TabIndex = 11;
            this.lblcodigo.Text = "ID producto:";
            this.lblcodigo.Visible = false;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(27, 93);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(104, 16);
            this.lblcantidad.TabIndex = 10;
            this.lblcantidad.Text = "Cantidad (total): ";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(27, 131);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(161, 16);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Precio producto (unidad): ";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(27, 58);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(138, 16);
            this.lblnombreproducto.TabIndex = 8;
            this.lblnombreproducto.Text = "Nombre del producto:";
            // 
            // lbltituloadministrar
            // 
            this.lbltituloadministrar.AutoSize = true;
            this.lbltituloadministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloadministrar.Location = new System.Drawing.Point(26, 16);
            this.lbltituloadministrar.Name = "lbltituloadministrar";
            this.lbltituloadministrar.Size = new System.Drawing.Size(180, 20);
            this.lbltituloadministrar.TabIndex = 7;
            this.lbltituloadministrar.Text = "Información producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(6, 227);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(112, 227);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(216, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(12, 27);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(543, 132);
            this.dgvproductos.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.aumentarCantidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // aumentarCantidadToolStripMenuItem
            // 
            this.aumentarCantidadToolStripMenuItem.Name = "aumentarCantidadToolStripMenuItem";
            this.aumentarCantidadToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.aumentarCantidadToolStripMenuItem.Text = "Aumentar cantidad";
            // 
            // MenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 431);
            this.Controls.Add(this.gbadministrar);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInventario";
            this.Text = "Menu Inventario";
            this.Load += new System.EventHandler(this.MenuInventario_Load);
            this.gbadministrar.ResumeLayout(false);
            this.gbadministrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbadministrar;
        private System.Windows.Forms.Label categoriaactual;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label lbltituloadministrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentarCantidadToolStripMenuItem;
    }
}