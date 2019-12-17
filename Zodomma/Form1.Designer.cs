namespace Zodomma
{
    partial class Form1
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
            this.cbpregunta = new System.Windows.Forms.ComboBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.txtrcontraseña = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.lblpregunta = new System.Windows.Forms.Label();
            this.lblrcontraseña = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbpregunta
            // 
            this.cbpregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbpregunta.FormattingEnabled = true;
            this.cbpregunta.Items.AddRange(new object[] {
            "Nombre de la madre",
            "Nombre del padre",
            "Nombre de la primera mascota",
            "Lugar de nacimiento"});
            this.cbpregunta.Location = new System.Drawing.Point(216, 200);
            this.cbpregunta.Name = "cbpregunta";
            this.cbpregunta.Size = new System.Drawing.Size(150, 21);
            this.cbpregunta.TabIndex = 26;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(173, 327);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 25;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.Location = new System.Drawing.Point(216, 236);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(150, 20);
            this.txtrespuesta.TabIndex = 24;
            // 
            // txtrcontraseña
            // 
            this.txtrcontraseña.Location = new System.Drawing.Point(216, 164);
            this.txtrcontraseña.Name = "txtrcontraseña";
            this.txtrcontraseña.PasswordChar = 'x';
            this.txtrcontraseña.Size = new System.Drawing.Size(150, 20);
            this.txtrcontraseña.TabIndex = 23;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(216, 130);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = 'x';
            this.txtcontraseña.Size = new System.Drawing.Size(150, 20);
            this.txtcontraseña.TabIndex = 22;

            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(216, 95);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(150, 20);
            this.txtusuario.TabIndex = 21;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Enabled = false;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(228, 293);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 16);
            this.lblmensaje.TabIndex = 20;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(49, 241);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(77, 16);
            this.lblrespuesta.TabIndex = 19;
            this.lblrespuesta.Text = "Respuesta:";
            // 
            // lblpregunta
            // 
            this.lblpregunta.AutoSize = true;
            this.lblpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta.Location = new System.Drawing.Point(49, 206);
            this.lblpregunta.Name = "lblpregunta";
            this.lblpregunta.Size = new System.Drawing.Size(68, 16);
            this.lblpregunta.TabIndex = 18;
            this.lblpregunta.Text = "Pregunta: ";
            // 
            // lblrcontraseña
            // 
            this.lblrcontraseña.AutoSize = true;
            this.lblrcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrcontraseña.Location = new System.Drawing.Point(49, 169);
            this.lblrcontraseña.Name = "lblrcontraseña";
            this.lblrcontraseña.Size = new System.Drawing.Size(128, 16);
            this.lblrcontraseña.TabIndex = 17;
            this.lblrcontraseña.Text = "Repetir contraseña: ";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(49, 134);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(80, 16);
            this.lblcontraseña.TabIndex = 16;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(49, 99);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 16);
            this.lblusuario.TabIndex = 15;
            this.lblusuario.Text = "Usuario: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(168, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Registro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.cbpregunta);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtrespuesta);
            this.Controls.Add(this.txtrcontraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblpregunta);
            this.Controls.Add(this.lblrcontraseña);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbpregunta;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtrespuesta;
        private System.Windows.Forms.TextBox txtrcontraseña;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Label lblpregunta;
        private System.Windows.Forms.Label lblrcontraseña;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblTitulo;
    }
}

