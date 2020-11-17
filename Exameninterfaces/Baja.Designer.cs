namespace Exameninterfaces
{
    partial class Baja
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
            this.lst_socios = new System.Windows.Forms.ListBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txb_filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_socios
            // 
            this.lst_socios.FormattingEnabled = true;
            this.lst_socios.ItemHeight = 20;
            this.lst_socios.Location = new System.Drawing.Point(12, 47);
            this.lst_socios.Name = "lst_socios";
            this.lst_socios.Size = new System.Drawing.Size(555, 244);
            this.lst_socios.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(413, 331);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(154, 61);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.Text = "Dar de baja";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txb_filtro
            // 
            this.txb_filtro.Location = new System.Drawing.Point(635, 133);
            this.txb_filtro.Name = "txb_filtro";
            this.txb_filtro.Size = new System.Drawing.Size(100, 26);
            this.txb_filtro.TabIndex = 2;
            this.txb_filtro.TextChanged += new System.EventHandler(this.txb_filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar:";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_filtro);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lst_socios);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_socios;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txb_filtro;
        private System.Windows.Forms.Label label1;
    }
}