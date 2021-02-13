
namespace InterfacesRefuerzo
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_conmutar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(133, 305);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(117, 57);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_conmutar
            // 
            this.btn_conmutar.Location = new System.Drawing.Point(536, 305);
            this.btn_conmutar.Name = "btn_conmutar";
            this.btn_conmutar.Size = new System.Drawing.Size(106, 57);
            this.btn_conmutar.TabIndex = 1;
            this.btn_conmutar.Text = "Conmutar";
            this.btn_conmutar.UseVisualStyleBackColor = true;
            this.btn_conmutar.Click += new System.EventHandler(this.btn_conmutar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(311, 59);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 84);
            this.listBox.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(76, 76);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 3;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(585, 88);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 26);
            this.textbox.TabIndex = 4;
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(325, 305);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(122, 57);
            this.btn_form2.TabIndex = 5;
            this.btn_form2.Text = "Formulario 2";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_conmutar);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_conmutar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button btn_form2;
    }
}

