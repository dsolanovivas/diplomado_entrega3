namespace RaadioButtonCal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.rbtsuma = new System.Windows.Forms.RadioButton();
            this.rbtmul = new System.Windows.Forms.RadioButton();
            this.rbtresta = new System.Windows.Forms.RadioButton();
            this.rbtdiv = new System.Windows.Forms.RadioButton();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite Primer Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite Segundo Numero";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.rbtdiv);
            this.grb1.Controls.Add(this.rbtresta);
            this.grb1.Controls.Add(this.rbtmul);
            this.grb1.Controls.Add(this.rbtsuma);
            this.grb1.Location = new System.Drawing.Point(24, 67);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(200, 100);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            this.grb1.Text = "Opciones";
            // 
            // rbtsuma
            // 
            this.rbtsuma.AutoSize = true;
            this.rbtsuma.Location = new System.Drawing.Point(7, 20);
            this.rbtsuma.Name = "rbtsuma";
            this.rbtsuma.Size = new System.Drawing.Size(52, 17);
            this.rbtsuma.TabIndex = 0;
            this.rbtsuma.TabStop = true;
            this.rbtsuma.Text = "Suma";
            this.rbtsuma.UseVisualStyleBackColor = true;
            this.rbtsuma.CheckedChanged += new System.EventHandler(this.rbtsuma_CheckedChanged);
            this.rbtsuma.Click += new System.EventHandler(this.rbtsuma_Click);
            // 
            // rbtmul
            // 
            this.rbtmul.AutoSize = true;
            this.rbtmul.Location = new System.Drawing.Point(7, 58);
            this.rbtmul.Name = "rbtmul";
            this.rbtmul.Size = new System.Drawing.Size(89, 17);
            this.rbtmul.TabIndex = 1;
            this.rbtmul.TabStop = true;
            this.rbtmul.Text = "Multiplicación";
            this.rbtmul.UseVisualStyleBackColor = true;
            this.rbtmul.Click += new System.EventHandler(this.rbtmul_Click);
            // 
            // rbtresta
            // 
            this.rbtresta.AutoSize = true;
            this.rbtresta.Location = new System.Drawing.Point(100, 20);
            this.rbtresta.Name = "rbtresta";
            this.rbtresta.Size = new System.Drawing.Size(53, 17);
            this.rbtresta.TabIndex = 2;
            this.rbtresta.TabStop = true;
            this.rbtresta.Text = "Resta";
            this.rbtresta.UseVisualStyleBackColor = true;
            this.rbtresta.Click += new System.EventHandler(this.rbtresta_Click);
            // 
            // rbtdiv
            // 
            this.rbtdiv.AutoSize = true;
            this.rbtdiv.Location = new System.Drawing.Point(99, 58);
            this.rbtdiv.Name = "rbtdiv";
            this.rbtdiv.Size = new System.Drawing.Size(62, 17);
            this.rbtdiv.TabIndex = 3;
            this.rbtdiv.TabStop = true;
            this.rbtdiv.Text = "División";
            this.rbtdiv.UseVisualStyleBackColor = true;
            this.rbtdiv.Click += new System.EventHandler(this.rbtdiv_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(242, 177);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpopciones;
        private System.Windows.Forms.RadioButton rbndivision;
        private System.Windows.Forms.RadioButton rbnresta;
        private System.Windows.Forms.RadioButton rbnmultiplicacion;
        private System.Windows.Forms.RadioButton rbnsuma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton rbtdiv;
        private System.Windows.Forms.RadioButton rbtresta;
        private System.Windows.Forms.RadioButton rbtmul;
        private System.Windows.Forms.RadioButton rbtsuma;
    }
}

