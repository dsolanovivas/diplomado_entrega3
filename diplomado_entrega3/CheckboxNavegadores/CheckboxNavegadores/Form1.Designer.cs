namespace CheckboxNavegadores
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
            this.chkgoogle = new System.Windows.Forms.CheckBox();
            this.chksafari = new System.Windows.Forms.CheckBox();
            this.chkfirefox = new System.Windows.Forms.CheckBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkgoogle
            // 
            this.chkgoogle.AutoSize = true;
            this.chkgoogle.Location = new System.Drawing.Point(85, 12);
            this.chkgoogle.Name = "chkgoogle";
            this.chkgoogle.Size = new System.Drawing.Size(99, 17);
            this.chkgoogle.TabIndex = 0;
            this.chkgoogle.Text = "Google Crhome";
            this.chkgoogle.UseVisualStyleBackColor = true;
            // 
            // chksafari
            // 
            this.chksafari.AutoSize = true;
            this.chksafari.Location = new System.Drawing.Point(85, 58);
            this.chksafari.Name = "chksafari";
            this.chksafari.Size = new System.Drawing.Size(53, 17);
            this.chksafari.TabIndex = 1;
            this.chksafari.Text = "Safari";
            this.chksafari.UseVisualStyleBackColor = true;
            // 
            // chkfirefox
            // 
            this.chkfirefox.AutoSize = true;
            this.chkfirefox.Location = new System.Drawing.Point(85, 35);
            this.chkfirefox.Name = "chkfirefox";
            this.chkfirefox.Size = new System.Drawing.Size(92, 17);
            this.chkfirefox.TabIndex = 2;
            this.chkfirefox.Text = "Mozilla Firefox";
            this.chkfirefox.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(85, 81);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(92, 23);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.chkfirefox);
            this.Controls.Add(this.chksafari);
            this.Controls.Add(this.chkgoogle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkgoogle;
        private System.Windows.Forms.CheckBox chksafari;
        private System.Windows.Forms.CheckBox chkfirefox;
        private System.Windows.Forms.Button btnaceptar;
    }
}

