namespace Exameninterfaces
{
    partial class Sacar
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
            this.lst_libros = new System.Windows.Forms.ListBox();
            this.lst_socios1 = new System.Windows.Forms.ListBox();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFiltrarlibros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_libros
            // 
            this.lst_libros.FormattingEnabled = true;
            this.lst_libros.ItemHeight = 20;
            this.lst_libros.Location = new System.Drawing.Point(637, 73);
            this.lst_libros.Name = "lst_libros";
            this.lst_libros.Size = new System.Drawing.Size(576, 264);
            this.lst_libros.TabIndex = 0;
            this.lst_libros.SelectedIndexChanged += new System.EventHandler(this.lst_libros_SelectedIndexChanged);
            // 
            // lst_socios1
            // 
            this.lst_socios1.FormattingEnabled = true;
            this.lst_socios1.ItemHeight = 20;
            this.lst_socios1.Location = new System.Drawing.Point(12, 73);
            this.lst_socios1.Name = "lst_socios1";
            this.lst_socios1.Size = new System.Drawing.Size(576, 264);
            this.lst_socios1.TabIndex = 1;
            this.lst_socios1.SelectedIndexChanged += new System.EventHandler(this.lst_socios1_SelectedIndexChanged);
            // 
            // btn_sacar
            // 
            this.btn_sacar.Location = new System.Drawing.Point(537, 367);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(161, 56);
            this.btn_sacar.TabIndex = 2;
            this.btn_sacar.Text = "Sacar libro";
            this.btn_sacar.UseVisualStyleBackColor = true;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFiltrarlibros
            // 
            this.txtFiltrarlibros.Location = new System.Drawing.Point(637, 28);
            this.txtFiltrarlibros.Name = "txtFiltrarlibros";
            this.txtFiltrarlibros.Size = new System.Drawing.Size(100, 26);
            this.txtFiltrarlibros.TabIndex = 4;
            this.txtFiltrarlibros.TextChanged += new System.EventHandler(this.txtFiltrarlibros_TextChanged);
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 450);
            this.Controls.Add(this.txtFiltrarlibros);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.lst_socios1);
            this.Controls.Add(this.lst_libros);
            this.Name = "Sacar";
            this.Text = "Sacar";
            this.Load += new System.EventHandler(this.Sacar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_libros;
        private System.Windows.Forms.ListBox lst_socios1;
        private System.Windows.Forms.Button btn_sacar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFiltrarlibros;
    }
}