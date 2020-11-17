namespace Exameninterfaces
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
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(491, 75);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(134, 47);
            this.btn_baja.TabIndex = 0;
            this.btn_baja.Text = "Dar de Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(136, 75);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(146, 47);
            this.btn_alta.TabIndex = 1;
            this.btn_alta.Text = "Dar de Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(479, 271);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(146, 47);
            this.btn_devolver.TabIndex = 2;
            this.btn_devolver.Text = "Devolver lbro";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // btn_sacar
            // 
            this.btn_sacar.Location = new System.Drawing.Point(136, 271);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(146, 47);
            this.btn_sacar.TabIndex = 3;
            this.btn_sacar.Text = "Sacar libro";
            this.btn_sacar.UseVisualStyleBackColor = true;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.btn_baja);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.Button btn_sacar;
    }
}

