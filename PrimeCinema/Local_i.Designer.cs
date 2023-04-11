namespace PrimeCinema
{
    partial class Local_i
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
            this.Local = new System.Windows.Forms.Label();
            this.Salas = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Gerente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local.Location = new System.Drawing.Point(82, 54);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(249, 22);
            this.Local.TabIndex = 0;
            this.Local.Text = "PrimeCinema Plaza Merliot";
            // 
            // Salas
            // 
            this.Salas.AutoSize = true;
            this.Salas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salas.Location = new System.Drawing.Point(82, 204);
            this.Salas.Name = "Salas";
            this.Salas.Size = new System.Drawing.Size(72, 22);
            this.Salas.TabIndex = 2;
            this.Salas.Text = "Salas: ";
            // 
            // Direction
            // 
            this.Direction.AutoSize = true;
            this.Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direction.Location = new System.Drawing.Point(82, 280);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(106, 22);
            this.Direction.TabIndex = 3;
            this.Direction.Text = "Direccion: ";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(82, 356);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(101, 22);
            this.Telefono.TabIndex = 4;
            this.Telefono.Text = "Telefono: ";
            // 
            // Gerente
            // 
            this.Gerente.AutoSize = true;
            this.Gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerente.Location = new System.Drawing.Point(82, 132);
            this.Gerente.Name = "Gerente";
            this.Gerente.Size = new System.Drawing.Size(94, 22);
            this.Gerente.TabIndex = 5;
            this.Gerente.Text = "Gerente: ";
            // 
            // Local_i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gerente);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.Salas);
            this.Controls.Add(this.Local);
            this.Name = "Local_i";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.Local_i_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.Label Salas;
        private System.Windows.Forms.Label Direction;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Gerente;
    }
}