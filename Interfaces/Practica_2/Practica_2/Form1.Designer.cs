namespace Practica_2
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
            this.Crear_A = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crear_A
            // 
            this.Crear_A.BackColor = System.Drawing.SystemColors.Control;
            this.Crear_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crear_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Crear_A.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear_A.Location = new System.Drawing.Point(309, 118);
            this.Crear_A.Name = "Crear_A";
            this.Crear_A.Size = new System.Drawing.Size(173, 76);
            this.Crear_A.TabIndex = 0;
            this.Crear_A.Text = "Agendas";
            this.Crear_A.UseVisualStyleBackColor = false;
            this.Crear_A.Click += new System.EventHandler(this.Crear_A_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica_2.Properties.Resources.fondo_cuaderno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Crear_A);
            this.Name = "Form1";
            this.Text = "Agenda 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crear_A;
        private System.Windows.Forms.Button button1;
    }
}

