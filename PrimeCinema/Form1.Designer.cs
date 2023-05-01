namespace PrimeCinema
{
    partial class Form1
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Gerente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(206, 113);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 26);
            this.Nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salas";
            // 
            // Salas
            // 
            this.Salas.Location = new System.Drawing.Point(206, 184);
            this.Salas.Name = "Salas";
            this.Salas.Size = new System.Drawing.Size(100, 26);
            this.Salas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gerente";
            // 
            // Gerente
            // 
            this.Gerente.Location = new System.Drawing.Point(206, 260);
            this.Gerente.Name = "Gerente";
            this.Gerente.Size = new System.Drawing.Size(100, 26);
            this.Gerente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(470, 113);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 26);
            this.Direccion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "telefono";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(470, 190);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 26);
            this.Telefono.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Local agregado exitosamente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Salas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Gerente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}