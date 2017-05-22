namespace ColasFIFO
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
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.textBoxAtendidos = new System.Windows.Forms.TextBox();
            this.buttonAtendidos = new System.Windows.Forms.Button();
            this.buttonEspera = new System.Windows.Forms.Button();
            this.buttonFifo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.Enabled = false;
            this.buttonEmpezar.Location = new System.Drawing.Point(287, 261);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(91, 35);
            this.buttonEmpezar.TabIndex = 0;
            this.buttonEmpezar.Text = "Generar";
            this.buttonEmpezar.UseVisualStyleBackColor = true;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // textBoxAtendidos
            // 
            this.textBoxAtendidos.Location = new System.Drawing.Point(96, 118);
            this.textBoxAtendidos.Multiline = true;
            this.textBoxAtendidos.Name = "textBoxAtendidos";
            this.textBoxAtendidos.Size = new System.Drawing.Size(500, 112);
            this.textBoxAtendidos.TabIndex = 2;
            // 
            // buttonAtendidos
            // 
            this.buttonAtendidos.Enabled = false;
            this.buttonAtendidos.Location = new System.Drawing.Point(96, 261);
            this.buttonAtendidos.Name = "buttonAtendidos";
            this.buttonAtendidos.Size = new System.Drawing.Size(100, 33);
            this.buttonAtendidos.TabIndex = 4;
            this.buttonAtendidos.Text = "Atendidos";
            this.buttonAtendidos.UseVisualStyleBackColor = true;
            this.buttonAtendidos.Click += new System.EventHandler(this.buttonAtendidos_Click);
            // 
            // buttonEspera
            // 
            this.buttonEspera.Enabled = false;
            this.buttonEspera.Location = new System.Drawing.Point(463, 261);
            this.buttonEspera.Name = "buttonEspera";
            this.buttonEspera.Size = new System.Drawing.Size(103, 33);
            this.buttonEspera.TabIndex = 5;
            this.buttonEspera.Text = "En espera";
            this.buttonEspera.UseVisualStyleBackColor = true;
            this.buttonEspera.Click += new System.EventHandler(this.buttonEspera_Click);
            // 
            // buttonFifo
            // 
            this.buttonFifo.Location = new System.Drawing.Point(287, 311);
            this.buttonFifo.Name = "buttonFifo";
            this.buttonFifo.Size = new System.Drawing.Size(91, 35);
            this.buttonFifo.TabIndex = 6;
            this.buttonFifo.Text = "Generar";
            this.buttonFifo.UseVisualStyleBackColor = true;
            this.buttonFifo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFifo);
            this.Controls.Add(this.buttonEspera);
            this.Controls.Add(this.buttonAtendidos);
            this.Controls.Add(this.textBoxAtendidos);
            this.Controls.Add(this.buttonEmpezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEmpezar;
        private System.Windows.Forms.TextBox textBoxAtendidos;
        private System.Windows.Forms.Button buttonAtendidos;
        private System.Windows.Forms.Button buttonEspera;
        private System.Windows.Forms.Button buttonFifo;
        private System.Windows.Forms.Label label1;
    }
}

