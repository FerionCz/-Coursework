
namespace TeacherSchoolApp
{
    partial class FormAuth
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
            this.TBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnAuth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // TBoxLogin
            // 
            this.TBoxLogin.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxLogin.Location = new System.Drawing.Point(266, 191);
            this.TBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBoxLogin.Name = "TBoxLogin";
            this.TBoxLogin.Size = new System.Drawing.Size(144, 26);
            this.TBoxLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // PBoxPassword
            // 
            this.PBoxPassword.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PBoxPassword.Location = new System.Drawing.Point(266, 229);
            this.PBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBoxPassword.Name = "PBoxPassword";
            this.PBoxPassword.Size = new System.Drawing.Size(144, 26);
            this.PBoxPassword.TabIndex = 5;
            // 
            // BtnAuth
            // 
            this.BtnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAuth.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAuth.ForeColor = System.Drawing.Color.White;
            this.BtnAuth.Location = new System.Drawing.Point(180, 271);
            this.BtnAuth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAuth.Name = "BtnAuth";
            this.BtnAuth.Size = new System.Drawing.Size(122, 35);
            this.BtnAuth.TabIndex = 6;
            this.BtnAuth.Text = "Войти";
            this.BtnAuth.UseVisualStyleBackColor = false;
            this.BtnAuth.Click += new System.EventHandler(this.BtnAuth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(249, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Авторизация";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(317, 271);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(122, 35);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Очистить";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAuth);
            this.Controls.Add(this.PBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxLogin, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.PBoxPassword, 0);
            this.Controls.SetChildIndex(this.BtnAuth, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BtnClear, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PBoxPassword;
        private System.Windows.Forms.Button BtnAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClear;
    }
}