namespace checkColores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnaceptar = new System.Windows.Forms.Button();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkAmarillo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(23, 81);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(92, 23);
            this.btnaceptar.TabIndex = 7;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Location = new System.Drawing.Point(23, 35);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(48, 17);
            this.chkRojo.TabIndex = 6;
            this.chkRojo.Text = "Rojo";
            this.chkRojo.UseVisualStyleBackColor = true;
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Location = new System.Drawing.Point(23, 58);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(46, 17);
            this.chkAzul.TabIndex = 5;
            this.chkAzul.Text = "Azul";
            this.chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Location = new System.Drawing.Point(23, 12);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(62, 17);
            this.chkAmarillo.TabIndex = 4;
            this.chkAmarillo.Text = "Amarillo";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 115);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.chkAzul);
            this.Controls.Add(this.chkAmarillo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkAmarillo;
    }
}

