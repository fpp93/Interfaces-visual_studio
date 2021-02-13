
namespace InterfacesRefuerzo
{
    partial class Form2
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
            this.btn_conmutar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_conmutar
            // 
            this.btn_conmutar.Location = new System.Drawing.Point(490, 313);
            this.btn_conmutar.Name = "btn_conmutar";
            this.btn_conmutar.Size = new System.Drawing.Size(155, 62);
            this.btn_conmutar.TabIndex = 0;
            this.btn_conmutar.Text = "conmutar";
            this.btn_conmutar.UseVisualStyleBackColor = true;
            this.btn_conmutar.Click += new System.EventHandler(this.btn_conmutar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(105, 313);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(149, 62);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(465, 78);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 28);
            this.combobox.TabIndex = 2;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(66, 68);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(326, 164);
            this.listbox.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(544, 181);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 26);
            this.textBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_conmutar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conmutar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TextBox textBox;
    }
}