namespace ContadorCeros
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.txtF3 = new System.Windows.Forms.TextBox();
            this.txtF4 = new System.Windows.Forms.TextBox();
            this.txtF5 = new System.Windows.Forms.TextBox();
            this.rtcArreglo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(246, 182);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Arreglo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(246, 211);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(100, 23);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar Ceros";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(246, 77);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(100, 20);
            this.txtF2.TabIndex = 3;
            this.txtF2.TextChanged += new System.EventHandler(this.txtCeros_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ceros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arreglo";
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(246, 51);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(100, 20);
            this.txtF1.TabIndex = 6;
            // 
            // txtF3
            // 
            this.txtF3.Location = new System.Drawing.Point(246, 103);
            this.txtF3.Name = "txtF3";
            this.txtF3.Size = new System.Drawing.Size(100, 20);
            this.txtF3.TabIndex = 7;
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(246, 129);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(100, 20);
            this.txtF4.TabIndex = 8;
            // 
            // txtF5
            // 
            this.txtF5.Location = new System.Drawing.Point(246, 155);
            this.txtF5.Name = "txtF5";
            this.txtF5.Size = new System.Drawing.Size(100, 20);
            this.txtF5.TabIndex = 9;
            // 
            // rtcArreglo
            // 
            this.rtcArreglo.Location = new System.Drawing.Point(28, 52);
            this.rtcArreglo.Name = "rtcArreglo";
            this.rtcArreglo.Size = new System.Drawing.Size(194, 182);
            this.rtcArreglo.TabIndex = 10;
            this.rtcArreglo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 268);
            this.Controls.Add(this.rtcArreglo);
            this.Controls.Add(this.txtF5);
            this.Controls.Add(this.txtF4);
            this.Controls.Add(this.txtF3);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.TextBox txtF4;
        private System.Windows.Forms.TextBox txtF5;
        private System.Windows.Forms.RichTextBox rtcArreglo;
    }
}

