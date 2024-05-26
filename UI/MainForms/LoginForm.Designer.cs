namespace UI.MainForms
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordField = new System.Windows.Forms.TextBox();
            this.textBoxLoginField = new System.Windows.Forms.TextBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(133, 55);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(242, 37);
            this.labelLogin.TabIndex = 16;
            this.labelLogin.Text = "Войдите в аккаунт";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(184, 220);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(141, 23);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordField
            // 
            this.textBoxPasswordField.Location = new System.Drawing.Point(205, 177);
            this.textBoxPasswordField.Name = "textBoxPasswordField";
            this.textBoxPasswordField.Size = new System.Drawing.Size(100, 23);
            this.textBoxPasswordField.TabIndex = 10;
            // 
            // textBoxLoginField
            // 
            this.textBoxLoginField.Location = new System.Drawing.Point(205, 143);
            this.textBoxLoginField.Name = "textBoxLoginField";
            this.textBoxLoginField.Size = new System.Drawing.Size(100, 23);
            this.textBoxLoginField.TabIndex = 9;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(234, 112);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(0, 15);
            this.labelDebug.TabIndex = 17;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(214, 268);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(81, 15);
            this.labelRegister.TabIndex = 18;
            this.labelRegister.Text = "Нет аккаунта:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(184, 286);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(140, 23);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordField);
            this.Controls.Add(this.textBoxLoginField);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private Button buttonLogin;
        private TextBox textBoxPasswordField;
        private TextBox textBoxLoginField;
        private Label labelDebug;
        private Label labelRegister;
        private Button buttonRegister;
    }
}