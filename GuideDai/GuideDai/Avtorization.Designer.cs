﻿namespace GuideDai
{
    partial class Avtorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginUserBox = new System.Windows.Forms.TextBox();
            this.PasswordUserBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизація";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(121, 127);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(131, 46);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Увійти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // RegistrButton
            // 
            this.RegistrButton.Location = new System.Drawing.Point(131, 179);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(103, 20);
            this.RegistrButton.TabIndex = 2;
            this.RegistrButton.Text = "Зареєструватися";
            this.RegistrButton.UseVisualStyleBackColor = true;
            this.RegistrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ПІП";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль";
            // 
            // LoginUserBox
            // 
            this.LoginUserBox.Location = new System.Drawing.Point(95, 44);
            this.LoginUserBox.Name = "LoginUserBox";
            this.LoginUserBox.Size = new System.Drawing.Size(219, 20);
            this.LoginUserBox.TabIndex = 7;
            // 
            // PasswordUserBox
            // 
            this.PasswordUserBox.Location = new System.Drawing.Point(95, 82);
            this.PasswordUserBox.Name = "PasswordUserBox";
            this.PasswordUserBox.Size = new System.Drawing.Size(219, 20);
            this.PasswordUserBox.TabIndex = 10;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 206);
            this.Controls.Add(this.PasswordUserBox);
            this.Controls.Add(this.LoginUserBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistrButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label1);
            this.Name = "Avtorization";
            this.Text = "Avtorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button RegistrButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginUserBox;
        private System.Windows.Forms.TextBox PasswordUserBox;
    }
}