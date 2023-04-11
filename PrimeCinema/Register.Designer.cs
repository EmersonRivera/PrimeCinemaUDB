namespace PrimeCinema
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Names = new System.Windows.Forms.TextBox();
            this.LastNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DUI = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.PasswordR1 = new System.Windows.Forms.TextBox();
            this.PasswordR2 = new System.Windows.Forms.TextBox();
            this.UserR = new System.Windows.Forms.TextBox();
            this.GoToLogin = new System.Windows.Forms.Label();
            this.Hide1 = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.BackColor = System.Drawing.Color.AliceBlue;
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Names.Location = new System.Drawing.Point(117, 165);
            this.Names.MaxLength = 30;
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(310, 46);
            this.Names.TabIndex = 2;
            this.Names.Text = "Names";
            this.Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Names.TextChanged += new System.EventHandler(this.User_TextChanged);
            this.Names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Names_KeyPress);
            // 
            // LastNames
            // 
            this.LastNames.BackColor = System.Drawing.Color.AliceBlue;
            this.LastNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNames.Location = new System.Drawing.Point(117, 282);
            this.LastNames.MaxLength = 30;
            this.LastNames.Multiline = true;
            this.LastNames.Name = "LastNames";
            this.LastNames.Size = new System.Drawing.Size(310, 46);
            this.LastNames.TabIndex = 3;
            this.LastNames.Text = "Last Names";
            this.LastNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNames.TextChanged += new System.EventHandler(this.User_TextChanged_1);
            this.LastNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNames_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DUI
            // 
            this.DUI.BackColor = System.Drawing.Color.AliceBlue;
            this.DUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUI.Location = new System.Drawing.Point(588, 165);
            this.DUI.MaxLength = 9;
            this.DUI.Multiline = true;
            this.DUI.Name = "DUI";
            this.DUI.Size = new System.Drawing.Size(310, 46);
            this.DUI.TabIndex = 5;
            this.DUI.Text = "DUI";
            this.DUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DUI.TextChanged += new System.EventHandler(this.DUI_TextChanged);
            this.DUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DUI_KeyPress);
            // 
            // Email
            // 
            this.Email.AcceptsReturn = true;
            this.Email.BackColor = System.Drawing.Color.AliceBlue;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(117, 400);
            this.Email.MaxLength = 30;
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(310, 46);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_KeyPress);
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.AliceBlue;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(588, 282);
            this.Phone.MaxLength = 11;
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(310, 46);
            this.Phone.TabIndex = 7;
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            // 
            // PasswordR1
            // 
            this.PasswordR1.BackColor = System.Drawing.Color.AliceBlue;
            this.PasswordR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordR1.Location = new System.Drawing.Point(588, 400);
            this.PasswordR1.MaxLength = 30;
            this.PasswordR1.Multiline = true;
            this.PasswordR1.Name = "PasswordR1";
            this.PasswordR1.Size = new System.Drawing.Size(310, 46);
            this.PasswordR1.TabIndex = 8;
            this.PasswordR1.Text = "Password";
            this.PasswordR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordR1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordR2
            // 
            this.PasswordR2.BackColor = System.Drawing.Color.AliceBlue;
            this.PasswordR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordR2.Location = new System.Drawing.Point(588, 522);
            this.PasswordR2.MaxLength = 30;
            this.PasswordR2.Multiline = true;
            this.PasswordR2.Name = "PasswordR2";
            this.PasswordR2.Size = new System.Drawing.Size(310, 46);
            this.PasswordR2.TabIndex = 9;
            this.PasswordR2.Text = "Password";
            this.PasswordR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordR2.TextChanged += new System.EventHandler(this.PasswordR2_TextChanged);
            // 
            // UserR
            // 
            this.UserR.BackColor = System.Drawing.Color.AliceBlue;
            this.UserR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserR.Location = new System.Drawing.Point(117, 522);
            this.UserR.MaxLength = 30;
            this.UserR.Multiline = true;
            this.UserR.Name = "UserR";
            this.UserR.Size = new System.Drawing.Size(310, 46);
            this.UserR.TabIndex = 10;
            this.UserR.Text = "User";
            this.UserR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.UserR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserR_KeyPress);
            // 
            // GoToLogin
            // 
            this.GoToLogin.AutoSize = true;
            this.GoToLogin.ForeColor = System.Drawing.Color.Black;
            this.GoToLogin.Location = new System.Drawing.Point(441, 612);
            this.GoToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToLogin.Name = "GoToLogin";
            this.GoToLogin.Size = new System.Drawing.Size(135, 20);
            this.GoToLogin.TabIndex = 11;
            this.GoToLogin.Text = "I have an account";
            this.GoToLogin.Click += new System.EventHandler(this.GoToLogin_Click);
            // 
            // Hide1
            // 
            this.Hide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide1.Image = ((System.Drawing.Image)(resources.GetObject("Hide1.Image")));
            this.Hide1.Location = new System.Drawing.Point(518, 466);
            this.Hide1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hide1.Name = "Hide1";
            this.Hide1.Size = new System.Drawing.Size(38, 38);
            this.Hide1.TabIndex = 17;
            this.Hide1.UseVisualStyleBackColor = true;
            this.Hide1.Visible = false;
            this.Hide1.Click += new System.EventHandler(this.Hide1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassword.Image")));
            this.ShowPassword.Location = new System.Drawing.Point(903, 406);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(38, 38);
            this.ShowPassword.TabIndex = 16;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(430, 128);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(151, 20);
            this.error.TabIndex = 18;
            this.error.Text = "* we have a problem";
            this.error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.error.Visible = false;
            this.error.Click += new System.EventHandler(this.error_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 692);
            this.Controls.Add(this.error);
            this.Controls.Add(this.Hide1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.GoToLogin);
            this.Controls.Add(this.UserR);
            this.Controls.Add(this.PasswordR2);
            this.Controls.Add(this.PasswordR1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DUI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNames);
            this.Controls.Add(this.Names);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.TextBox LastNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DUI;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox PasswordR1;
        private System.Windows.Forms.TextBox PasswordR2;
        private System.Windows.Forms.TextBox UserR;
        private System.Windows.Forms.Label GoToLogin;
        private System.Windows.Forms.Button Hide1;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.Label error;
    }
}