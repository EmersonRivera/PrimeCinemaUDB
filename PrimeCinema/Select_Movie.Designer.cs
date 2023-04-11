namespace PrimeCinema
{
    partial class Selec_Movie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameI = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Views = new System.Windows.Forms.Label();
            this.Locals = new System.Windows.Forms.ComboBox();
            this.Hall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameI
            // 
            this.NameI.AutoSize = true;
            this.NameI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameI.Location = new System.Drawing.Point(232, 68);
            this.NameI.Name = "NameI";
            this.NameI.Size = new System.Drawing.Size(82, 26);
            this.NameI.TabIndex = 20;
            this.NameI.Text = "Name:";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(232, 140);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(82, 26);
            this.Category.TabIndex = 21;
            this.Category.Text = "Name:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(232, 220);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(82, 26);
            this.Time.TabIndex = 22;
            this.Time.Text = "Name:";
            // 
            // Views
            // 
            this.Views.AutoSize = true;
            this.Views.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Views.Location = new System.Drawing.Point(232, 294);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(82, 26);
            this.Views.TabIndex = 23;
            this.Views.Text = "Name:";
            // 
            // Locals
            // 
            this.Locals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Locals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locals.FormattingEnabled = true;
            this.Locals.Location = new System.Drawing.Point(446, 212);
            this.Locals.Name = "Locals";
            this.Locals.Size = new System.Drawing.Size(342, 34);
            this.Locals.TabIndex = 25;
            this.Locals.SelectedIndexChanged += new System.EventHandler(this.Locals_SelectedIndexChanged);
            // 
            // Hall
            // 
            this.Hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall.FormattingEnabled = true;
            this.Hall.Location = new System.Drawing.Point(446, 329);
            this.Hall.Name = "Hall";
            this.Hall.Size = new System.Drawing.Size(342, 34);
            this.Hall.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hall";
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Blue;
            this.Next.Location = new System.Drawing.Point(719, 369);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(45, 20);
            this.Next.TabIndex = 29;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Selec_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hall);
            this.Controls.Add(this.Locals);
            this.Controls.Add(this.Views);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.NameI);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Selec_Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Selec_Movie_FormClosed);
            this.Load += new System.EventHandler(this.Selec_Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameI;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Views;
        private System.Windows.Forms.ComboBox Locals;
        private System.Windows.Forms.ComboBox Hall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Next;
    }
}