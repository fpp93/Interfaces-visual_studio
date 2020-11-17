namespace practica_0
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
            this.Boton = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton
            // 
            this.Boton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Boton.Location = new System.Drawing.Point(272, 385);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(173, 72);
            this.Boton.TabIndex = 0;
            this.Boton.Text = "Enviar";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(182, 89);
            this.DNI.Multiline = true;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(100, 26);
            this.DNI.TabIndex = 1;
            this.DNI.TextChanged += new System.EventHandler(this.DNI_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(480, 86);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 26);
            this.Nombre.TabIndex = 2;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(182, 233);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(100, 26);
            this.Fecha.TabIndex = 3;
            this.Fecha.TextChanged += new System.EventHandler(this.Fecha_TextChanged);
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(480, 232);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(100, 26);
            this.Peso.TabIndex = 4;
            this.Peso.TextChanged += new System.EventHandler(this.Peso_TextChanged);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(776, 231);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 26);
            this.Altura.TabIndex = 5;
            this.Altura.TextChanged += new System.EventHandler(this.Altura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(124, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(381, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(102, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(391, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Peso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(694, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(666, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apellidos:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(778, 83);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(100, 26);
            this.Apellidos.TabIndex = 12;
            // 
            // Consulta
            // 
            this.Consulta.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Consulta.Location = new System.Drawing.Point(679, 385);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(145, 77);
            this.Consulta.TabIndex = 13;
            this.Consulta.Text = "Consultar";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Boton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.Button Consulta;
    }
}

