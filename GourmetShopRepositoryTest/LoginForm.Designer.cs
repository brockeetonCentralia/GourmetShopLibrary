﻿namespace GourmetShopRepositoryTest
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
            loginBtn = new Button();
            label1 = new Label();
            userNameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(270, 198);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(82, 22);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(213, 49);
            label1.Name = "label1";
            label1.Size = new Size(179, 51);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.ForeColor = SystemColors.MenuText;
            userNameTxtBox.Location = new Point(228, 127);
            userNameTxtBox.Margin = new Padding(3, 2, 3, 2);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(167, 23);
            userNameTxtBox.TabIndex = 2;
            userNameTxtBox.Enter += userNameTxtBox_Enter;
            userNameTxtBox.Leave += userNameTxtBox_Leave;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.ForeColor = SystemColors.MenuText;
            passwordTxtBox.Location = new Point(228, 164);
            passwordTxtBox.Margin = new Padding(3, 2, 3, 2);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(167, 23);
            passwordTxtBox.TabIndex = 3;
            passwordTxtBox.Enter += passwordTxtBox_Enter;
            passwordTxtBox.Leave += passwordTxtBox_Leave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 347);
            Controls.Add(passwordTxtBox);
            Controls.Add(userNameTxtBox);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label1;
        private TextBox userNameTxtBox;
        private TextBox passwordTxtBox;
    }
}