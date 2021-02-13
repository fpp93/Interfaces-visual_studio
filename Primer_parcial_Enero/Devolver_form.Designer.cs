
namespace Primer_parcial_Enero
{
    partial class Devolver_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_devolver = new System.Windows.Forms.Button();
            this.videojuegos_cliente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(305, 322);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(180, 72);
            this.btn_devolver.TabIndex = 0;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // videojuegos_cliente
            // 
            this.videojuegos_cliente.FormattingEnabled = true;
            this.videojuegos_cliente.ItemHeight = 20;
            this.videojuegos_cliente.Location = new System.Drawing.Point(52, 87);
            this.videojuegos_cliente.Name = "videojuegos_cliente";
            this.videojuegos_cliente.Size = new System.Drawing.Size(678, 164);
            this.videojuegos_cliente.TabIndex = 1;
            // 
            // Devolver_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videojuegos_cliente);
            this.Controls.Add(this.btn_devolver);
            this.Name = "Devolver_form";
            this.Text = "Devolver_form";
            this.Load += new System.EventHandler(this.Devolver_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.ListBox videojuegos_cliente;
    }
}