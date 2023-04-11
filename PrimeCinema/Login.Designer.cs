namespace PrimeCinema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.UserL = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.GoToPassword = new System.Windows.Forms.Label();
            this.GoToRegister = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.Hide1 = new System.Windows.Forms.Button();
            this.incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // UserL
            // 
            this.UserL.BackColor = System.Drawing.Color.AliceBlue;
            this.UserL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserL.Location = new System.Drawing.Point(258, 222);
            this.UserL.MaxLength = 30;
            this.UserL.Multiline = true;
            this.UserL.Name = "UserL";
            this.UserL.Size = new System.Drawing.Size(310, 46);
            this.UserL.TabIndex = 1;
            this.UserL.Text = "User";
            this.UserL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserL.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.AliceBlue;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(258, 292);
            this.Password.MaxLength = 25;
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(310, 47);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // GoToPassword
            // 
            this.GoToPassword.AutoSize = true;
            this.GoToPassword.ForeColor = System.Drawing.Color.Black;
            this.GoToPassword.Location = new System.Drawing.Point(276, 358);
            this.GoToPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToPassword.Name = "GoToPassword";
            this.GoToPassword.Size = new System.Drawing.Size(267, 20);
            this.GoToPassword.TabIndex = 12;
            this.GoToPassword.Text = "Have You forgotten Your password?";
            this.GoToPassword.Click += new System.EventHandler(this.GoToPassword_Click);
            // 
            // GoToRegister
            // 
            this.GoToRegister.AutoSize = true;
            this.GoToRegister.ForeColor = System.Drawing.Color.Black;
            this.GoToRegister.Location = new System.Drawing.Point(342, 398);
            this.GoToRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToRegister.Name = "GoToRegister";
            this.GoToRegister.Size = new System.Drawing.Size(142, 20);
            this.GoToRegister.TabIndex = 13;
            this.GoToRegister.Text = "Create an Account";
            this.GoToRegister.Click += new System.EventHandler(this.GoToRegister_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassword.Image")));
            this.ShowPassword.Location = new System.Drawing.Point(572, 298);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(38, 38);
            this.ShowPassword.TabIndex = 14;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // Hide1
            // 
            this.Hide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide1.Image = ((System.Drawing.Image)(resources.GetObject("Hide1.Image")));
            this.Hide1.Location = new System.Drawing.Point(668, 303);
            this.Hide1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hide1.Name = "Hide1";
            this.Hide1.Size = new System.Drawing.Size(38, 38);
            this.Hide1.TabIndex = 15;
            this.Hide1.UseVisualStyleBackColor = true;
            this.Hide1.Visible = false;
            this.Hide1.Click += new System.EventHandler(this.Hide_Click);
            // 
            // incorrect
            // 
            this.incorrect.AutoSize = true;
            this.incorrect.ForeColor = System.Drawing.Color.Red;
            this.incorrect.Location = new System.Drawing.Point(304, 199);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(223, 20);
            this.incorrect.TabIndex = 16;
            this.incorrect.Text = "* User or password is incorrect";
            this.incorrect.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.incorrect);
            this.Controls.Add(this.Hide1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.GoToRegister);
            this.Controls.Add(this.GoToPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserL);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(822, 505);
            this.MinimumSize = new System.Drawing.Size(822, 505);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserL;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GoToPassword;
        private System.Windows.Forms.Label GoToRegister;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.Button Hide1;
        private System.Windows.Forms.Label incorrect;
    }
}