namespace UI
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAsArtist = new System.Windows.Forms.RadioButton();
            this.radioButtonAsUser = new System.Windows.Forms.RadioButton();
            this.labelRegister = new System.Windows.Forms.Label();
            this.textBoxLoginInput = new System.Windows.Forms.TextBox();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.textBoxFullNameInput = new System.Windows.Forms.TextBox();
            this.textBoxEmailInput = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonAsArtist);
            this.groupBox.Controls.Add(this.radioButtonAsUser);
            this.groupBox.Location = new System.Drawing.Point(450, 129);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(125, 81);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Кто вы?";
            // 
            // radioButtonAsArtist
            // 
            this.radioButtonAsArtist.AutoSize = true;
            this.radioButtonAsArtist.Location = new System.Drawing.Point(10, 49);
            this.radioButtonAsArtist.Name = "radioButtonAsArtist";
            this.radioButtonAsArtist.Size = new System.Drawing.Size(99, 19);
            this.radioButtonAsArtist.TabIndex = 1;
            this.radioButtonAsArtist.Text = "Исполнитель";
            this.radioButtonAsArtist.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsUser
            // 
            this.radioButtonAsUser.AutoSize = true;
            this.radioButtonAsUser.Checked = true;
            this.radioButtonAsUser.Location = new System.Drawing.Point(10, 24);
            this.radioButtonAsUser.Name = "radioButtonAsUser";
            this.radioButtonAsUser.Size = new System.Drawing.Size(87, 19);
            this.radioButtonAsUser.TabIndex = 0;
            this.radioButtonAsUser.TabStop = true;
            this.radioButtonAsUser.Text = "Слушатель";
            this.radioButtonAsUser.UseVisualStyleBackColor = true;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegister.Location = new System.Drawing.Point(255, 54);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(261, 37);
            this.labelRegister.TabIndex = 1;
            this.labelRegister.Text = "Зарегистрируйтесь!";
            this.labelRegister.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLoginInput
            // 
            this.textBoxLoginInput.Location = new System.Drawing.Point(328, 129);
            this.textBoxLoginInput.Name = "textBoxLoginInput";
            this.textBoxLoginInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxLoginInput.TabIndex = 2;
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Location = new System.Drawing.Point(328, 158);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxPasswordInput.TabIndex = 3;
            // 
            // textBoxFullNameInput
            // 
            this.textBoxFullNameInput.Location = new System.Drawing.Point(328, 187);
            this.textBoxFullNameInput.Name = "textBoxFullNameInput";
            this.textBoxFullNameInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxFullNameInput.TabIndex = 4;
            // 
            // textBoxEmailInput
            // 
            this.textBoxEmailInput.Location = new System.Drawing.Point(328, 216);
            this.textBoxEmailInput.Name = "textBoxEmailInput";
            this.textBoxEmailInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmailInput.TabIndex = 5;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(303, 256);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(151, 30);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(278, 132);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 15);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин:";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(270, 161);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(244, 190);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(78, 15);
            this.labelFullName.TabIndex = 9;
            this.labelFullName.Text = "Полное имя:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(278, 219);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 15);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Почта:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxEmailInput);
            this.Controls.Add(this.textBoxFullNameInput);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.textBoxLoginInput);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.groupBox);
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox;
        private RadioButton radioButtonAsArtist;
        private RadioButton radioButtonAsUser;
        private Label labelRegister;
        private TextBox textBoxLoginInput;
        private TextBox textBoxPasswordInput;
        private TextBox textBoxFullNameInput;
        private TextBox textBoxEmailInput;
        private Button buttonRegister;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelFullName;
        private Label labelEmail;
    }
}