namespace Menu
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
            this.btnContador = new System.Windows.Forms.Button();
            this.btnMagico = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnPromSal = new System.Windows.Forms.Button();
            this.btnDiagonal = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCalf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(72, 29);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(107, 36);
            this.btnContador.TabIndex = 0;
            this.btnContador.Text = "Contador de ceros";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // btnMagico
            // 
            this.btnMagico.Location = new System.Drawing.Point(185, 29);
            this.btnMagico.Name = "btnMagico";
            this.btnMagico.Size = new System.Drawing.Size(107, 36);
            this.btnMagico.TabIndex = 1;
            this.btnMagico.Text = "Cuadro Magico";
            this.btnMagico.UseVisualStyleBackColor = true;
            this.btnMagico.Click += new System.EventHandler(this.btnMagico_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(298, 29);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(107, 36);
            this.btnPar.TabIndex = 2;
            this.btnPar.Text = "Par de arreglos";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnPromSal
            // 
            this.btnPromSal.Location = new System.Drawing.Point(57, 71);
            this.btnPromSal.Name = "btnPromSal";
            this.btnPromSal.Size = new System.Drawing.Size(107, 36);
            this.btnPromSal.TabIndex = 3;
            this.btnPromSal.Text = "Suma y promedio";
            this.btnPromSal.UseVisualStyleBackColor = true;
            this.btnPromSal.Click += new System.EventHandler(this.btnPromSal_Click);
            // 
            // btnDiagonal
            // 
            this.btnDiagonal.Location = new System.Drawing.Point(170, 71);
            this.btnDiagonal.Name = "btnDiagonal";
            this.btnDiagonal.Size = new System.Drawing.Size(75, 36);
            this.btnDiagonal.TabIndex = 4;
            this.btnDiagonal.Text = "Diagonal";
            this.btnDiagonal.UseVisualStyleBackColor = true;
            this.btnDiagonal.Click += new System.EventHandler(this.btnDiagonal_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(251, 71);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 36);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = " Resumen ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCalf
            // 
            this.btnCalf.Location = new System.Drawing.Point(335, 71);
            this.btnCalf.Name = "btnCalf";
            this.btnCalf.Size = new System.Drawing.Size(85, 36);
            this.btnCalf.TabIndex = 6;
            this.btnCalf.Text = "Calificaciones";
            this.btnCalf.UseVisualStyleBackColor = true;
            this.btnCalf.Click += new System.EventHandler(this.btnCalf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 136);
            this.Controls.Add(this.btnCalf);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnDiagonal);
            this.Controls.Add(this.btnPromSal);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnMagico);
            this.Controls.Add(this.btnContador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.Button btnMagico;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnPromSal;
        private System.Windows.Forms.Button btnDiagonal;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCalf;
    }
}

