namespace PrimeCinema
{
    partial class Accept
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
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(189, 9);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 30);
            this.Done.TabIndex = 0;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Successfully purchase!";
            // 
            // Accept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accept";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accept";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accept_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Accept_FormClosed);
            this.Load += new System.EventHandler(this.Accept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
    }
}