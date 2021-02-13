
namespace Primer_parcial_Enero
{
    partial class Formulario1
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
            this.Alta_cliente = new System.Windows.Forms.Button();
            this.Alquilar_videojuego = new System.Windows.Forms.Button();
            this.Devolver_videojuego = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // Alta_cliente
            // 
            this.Alta_cliente.Location = new System.Drawing.Point(48, 91);
            this.Alta_cliente.Name = "Alta_cliente";
            this.Alta_cliente.Size = new System.Drawing.Size(221, 331);
            this.Alta_cliente.TabIndex = 0;
            this.Alta_cliente.Text = "Alta Cliente";
            this.Alta_cliente.UseVisualStyleBackColor = true;
            this.Alta_cliente.Click += new System.EventHandler(this.Alta_cliente_Click);
            // 
            // Alquilar_videojuego
            // 
            this.Alquilar_videojuego.Location = new System.Drawing.Point(308, 91);
            this.Alquilar_videojuego.Name = "Alquilar_videojuego";
            this.Alquilar_videojuego.Size = new System.Drawing.Size(221, 331);
            this.Alquilar_videojuego.TabIndex = 1;
            this.Alquilar_videojuego.Text = "Alquilar Videojuego";
            this.Alquilar_videojuego.UseVisualStyleBackColor = true;
            this.Alquilar_videojuego.Click += new System.EventHandler(this.Alquilar_videojuego_Click);
            // 
            // Devolver_videojuego
            // 
            this.Devolver_videojuego.Location = new System.Drawing.Point(588, 91);
            this.Devolver_videojuego.Name = "Devolver_videojuego";
            this.Devolver_videojuego.Size = new System.Drawing.Size(221, 331);
            this.Devolver_videojuego.TabIndex = 2;
            this.Devolver_videojuego.Text = "Devolver Videojuego";
            this.Devolver_videojuego.UseVisualStyleBackColor = true;
            this.Devolver_videojuego.Click += new System.EventHandler(this.Devolver_videojuego_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Francisco\\Documents\\HelpNDoc\\Output\\chm\\Manual de ayuda rapido para el p" +
    "rograma Primer Parcial Enero.chm";
            // 
            // Formulario1
            // 
            this.ClientSize = new System.Drawing.Size(867, 538);
            this.Controls.Add(this.Devolver_videojuego);
            this.Controls.Add(this.Alquilar_videojuego);
            this.Controls.Add(this.Alta_cliente);
            this.Name = "Formulario1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Formulario1";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Alta_cliente;
        private System.Windows.Forms.Button Alquilar_videojuego;
        private System.Windows.Forms.Button Devolver_videojuego;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

