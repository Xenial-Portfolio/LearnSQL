namespace LearnSQL
{
    partial class LoginForm
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
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(13, 13);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(214, 20);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.Text = "Username";
            this.usernameTB.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameTB.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(13, 40);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(214, 20);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Text = "Password";
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(13, 67);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(214, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(13, 96);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(214, 23);
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 124);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Name = "LoginForm";
            this.Text = "Login/Signup";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
    }
}

