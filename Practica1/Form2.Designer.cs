namespace Practica1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enviar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Enviar.Location = new System.Drawing.Point(376, 352);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(164, 49);
            this.btn_Enviar.TabIndex = 0;
            this.btn_Enviar.Text = "Enviar";
            this.toolTip1.SetToolTip(this.btn_Enviar, "Se guardarán los datos de la persona rellena");
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(94, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(364, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(670, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(76, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(376, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(674, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Altura:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(147, 79);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(111, 29);
            this.DNI.TabIndex = 7;
            this.DNI.TextChanged += new System.EventHandler(this.DNI_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(448, 76);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(111, 29);
            this.Nombre.TabIndex = 8;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(762, 79);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(111, 29);
            this.Apellidos.TabIndex = 9;
            this.Apellidos.TextChanged += new System.EventHandler(this.Apellidos_TextChanged);
            // 
            // Peso
            // 
            this.Peso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Peso.Location = new System.Drawing.Point(437, 225);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(122, 29);
            this.Peso.TabIndex = 11;
            this.Peso.TextChanged += new System.EventHandler(this.Peso_TextChanged);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(742, 228);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(131, 29);
            this.Altura.TabIndex = 12;
            this.Altura.TextChanged += new System.EventHandler(this.Altura_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(147, 228);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(100, 29);
            this.Fecha.TabIndex = 13;
            this.Fecha.TextChanged += new System.EventHandler(this.Fecha_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Practica1.Properties.Resources.fesac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Enviar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}