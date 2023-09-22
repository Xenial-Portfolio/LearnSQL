namespace LearnSQL
{
    partial class SignUp
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.confirmPassTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(13, 120);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(228, 23);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(13, 13);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(227, 20);
            this.emailTB.TabIndex = 1;
            this.emailTB.Text = "Email Adress";
            this.emailTB.Enter += new System.EventHandler(this.emailTB_Enter);
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(13, 40);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(227, 20);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.Text = "Username";
            this.usernameTB.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameTB.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(13, 67);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(227, 20);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.Text = "Password";
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Location = new System.Drawing.Point(13, 94);
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.Size = new System.Drawing.Size(227, 20);
            this.confirmPassTB.TabIndex = 4;
            this.confirmPassTB.Text = "Confirm Password";
            this.confirmPassTB.Enter += new System.EventHandler(this.confirmPassTB_Enter);
            this.confirmPassTB.Leave += new System.EventHandler(this.confirmPassTB_Leave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 155);
            this.Controls.Add(this.confirmPassTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.SignUpButton);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox confirmPassTB;
    }
}