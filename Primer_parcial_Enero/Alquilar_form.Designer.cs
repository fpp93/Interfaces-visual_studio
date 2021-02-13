
namespace Primer_parcial_Enero
{
    partial class Alquilar_form
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
            this.btn_alquilar = new System.Windows.Forms.Button();
            this.lst_videojuegos = new System.Windows.Forms.ListBox();
            this.lst_clientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_alquilar
            // 
            this.btn_alquilar.Location = new System.Drawing.Point(303, 354);
            this.btn_alquilar.Name = "btn_alquilar";
            this.btn_alquilar.Size = new System.Drawing.Size(145, 58);
            this.btn_alquilar.TabIndex = 0;
            this.btn_alquilar.Text = "Alquilar";
            this.btn_alquilar.UseVisualStyleBackColor = true;
            this.btn_alquilar.Click += new System.EventHandler(this.btn_alquilar_Click);
            // 
            // lst_videojuegos
            // 
            this.lst_videojuegos.FormattingEnabled = true;
            this.lst_videojuegos.ItemHeight = 20;
            this.lst_videojuegos.Location = new System.Drawing.Point(56, 29);
            this.lst_videojuegos.Name = "lst_videojuegos";
            this.lst_videojuegos.Size = new System.Drawing.Size(244, 304);
            this.lst_videojuegos.TabIndex = 1;
            // 
            // lst_clientes
            // 
            this.lst_clientes.FormattingEnabled = true;
            this.lst_clientes.ItemHeight = 20;
            this.lst_clientes.Location = new System.Drawing.Point(498, 29);
            this.lst_clientes.Name = "lst_clientes";
            this.lst_clientes.Size = new System.Drawing.Size(244, 304);
            this.lst_clientes.TabIndex = 2;
            // 
            // Alquilar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_clientes);
            this.Controls.Add(this.lst_videojuegos);
            this.Controls.Add(this.btn_alquilar);
            this.Name = "Alquilar_form";
            this.Text = "Alquilar_form";
            this.Load += new System.EventHandler(this.Alquilar_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alquilar;
        private System.Windows.Forms.ListBox lst_videojuegos;
        private System.Windows.Forms.ListBox lst_clientes;
    }
}