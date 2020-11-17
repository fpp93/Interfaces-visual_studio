namespace Practica1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Crear = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Crear.ForeColor = System.Drawing.SystemColors.Control;
            this.Crear.Location = new System.Drawing.Point(249, 191);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(157, 55);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear Persona";
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Consultar.ForeColor = System.Drawing.SystemColors.Control;
            this.Consultar.Location = new System.Drawing.Point(249, 55);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(161, 55);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar Personas";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.Location = new System.Drawing.Point(249, 317);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(157, 52);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Practica1.Persona);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Practica1.Properties.Resources.fesac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Crear);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulario ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.BindingSource personaBindingSource;
    }
}

