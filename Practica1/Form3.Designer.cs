namespace Practica1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.LabelDNI = new System.Windows.Forms.Label();
            this.Label_Largo = new System.Windows.Forms.Label();
            this.Label_todas = new System.Windows.Forms.Label();
            this.Label_Vacio = new System.Windows.Forms.Label();
            this.btn_DNI = new System.Windows.Forms.Button();
            this.btn_largo = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btn_vacio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDNI.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelDNI.Location = new System.Drawing.Point(135, 82);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(148, 23);
            this.LabelDNI.TabIndex = 0;
            this.LabelDNI.Text = "Consultar Por DNI";
            // 
            // Label_Largo
            // 
            this.Label_Largo.AutoSize = true;
            this.Label_Largo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Largo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Largo.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Largo.Location = new System.Drawing.Point(579, 82);
            this.Label_Largo.Name = "Label_Largo";
            this.Label_Largo.Size = new System.Drawing.Size(171, 23);
            this.Label_Largo.TabIndex = 1;
            this.Label_Largo.Text = "Nombres Mas Largos";
            this.Label_Largo.Click += new System.EventHandler(this.Label_Largo_Click);
            // 
            // Label_todas
            // 
            this.Label_todas.AutoSize = true;
            this.Label_todas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Label_todas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_todas.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_todas.Location = new System.Drawing.Point(94, 285);
            this.Label_todas.Name = "Label_todas";
            this.Label_todas.Size = new System.Drawing.Size(214, 23);
            this.Label_todas.TabIndex = 2;
            this.Label_todas.Text = "Mostrar todas las personas";
            this.Label_todas.Click += new System.EventHandler(this.Label_todas_Click);
            // 
            // Label_Vacio
            // 
            this.Label_Vacio.AutoSize = true;
            this.Label_Vacio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Vacio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Vacio.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Vacio.Location = new System.Drawing.Point(613, 285);
            this.Label_Vacio.Name = "Label_Vacio";
            this.Label_Vacio.Size = new System.Drawing.Size(109, 23);
            this.Label_Vacio.TabIndex = 3;
            this.Label_Vacio.Text = "Datos Vacios";
            this.Label_Vacio.Click += new System.EventHandler(this.Label_Vacio_Click);
            // 
            // btn_DNI
            // 
            this.btn_DNI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DNI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DNI.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DNI.Location = new System.Drawing.Point(159, 137);
            this.btn_DNI.Name = "btn_DNI";
            this.btn_DNI.Size = new System.Drawing.Size(101, 66);
            this.btn_DNI.TabIndex = 4;
            this.btn_DNI.Text = "Consultar";
            this.btn_DNI.UseVisualStyleBackColor = false;
            this.btn_DNI.Click += new System.EventHandler(this.btn_DNI_Click);
            // 
            // btn_largo
            // 
            this.btn_largo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_largo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_largo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_largo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_largo.Location = new System.Drawing.Point(617, 137);
            this.btn_largo.Name = "btn_largo";
            this.btn_largo.Size = new System.Drawing.Size(107, 66);
            this.btn_largo.TabIndex = 5;
            this.btn_largo.Text = "Consultar";
            this.btn_largo.UseVisualStyleBackColor = false;
            this.btn_largo.Click += new System.EventHandler(this.btn_largo_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_todos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_todos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_todos.Location = new System.Drawing.Point(159, 339);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(101, 70);
            this.btn_todos.TabIndex = 6;
            this.btn_todos.Text = "Consultar";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_vacio
            // 
            this.btn_vacio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_vacio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vacio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vacio.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_vacio.Location = new System.Drawing.Point(613, 339);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(107, 70);
            this.btn_vacio.TabIndex = 7;
            this.btn_vacio.Text = "Consultar";
            this.btn_vacio.UseVisualStyleBackColor = false;
            this.btn_vacio.Click += new System.EventHandler(this.btn_vacio_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica1.Properties.Resources.fesac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.btn_vacio);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_largo);
            this.Controls.Add(this.btn_DNI);
            this.Controls.Add(this.Label_Vacio);
            this.Controls.Add(this.Label_todas);
            this.Controls.Add(this.Label_Largo);
            this.Controls.Add(this.LabelDNI);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label Label_Largo;
        private System.Windows.Forms.Label Label_todas;
        private System.Windows.Forms.Label Label_Vacio;
        private System.Windows.Forms.Button btn_DNI;
        private System.Windows.Forms.Button btn_largo;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btn_vacio;
    }
}