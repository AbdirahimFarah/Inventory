﻿namespace Inventory
{
    partial class Form3
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
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.Firstnametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnametxtbox = new System.Windows.Forms.TextBox();
            this.Usernametxtbox = new System.Windows.Forms.TextBox();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(361, 338);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(98, 52);
            this.createAccountBtn.TabIndex = 1;
            this.createAccountBtn.Text = "create account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // Firstnametxtbox
            // 
            this.Firstnametxtbox.Location = new System.Drawing.Point(347, 152);
            this.Firstnametxtbox.Name = "Firstnametxtbox";
            this.Firstnametxtbox.Size = new System.Drawing.Size(159, 20);
            this.Firstnametxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // lastnametxtbox
            // 
            this.lastnametxtbox.Location = new System.Drawing.Point(347, 191);
            this.lastnametxtbox.Name = "lastnametxtbox";
            this.lastnametxtbox.Size = new System.Drawing.Size(159, 20);
            this.lastnametxtbox.TabIndex = 7;
            // 
            // Usernametxtbox
            // 
            this.Usernametxtbox.Location = new System.Drawing.Point(347, 236);
            this.Usernametxtbox.Name = "Usernametxtbox";
            this.Usernametxtbox.Size = new System.Drawing.Size(159, 20);
            this.Usernametxtbox.TabIndex = 8;
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Location = new System.Drawing.Point(347, 272);
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.Size = new System.Drawing.Size(159, 20);
            this.Passwordtxtbox.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Passwordtxtbox);
            this.Controls.Add(this.Usernametxtbox);
            this.Controls.Add(this.lastnametxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Firstnametxtbox);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.TextBox Firstnametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnametxtbox;
        private System.Windows.Forms.TextBox Usernametxtbox;
        private System.Windows.Forms.TextBox Passwordtxtbox;
    }
}