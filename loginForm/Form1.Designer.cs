namespace loginForm
{
    partial class Form1
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
            this.lblUsrN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsrN = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblDontAcc = new System.Windows.Forms.Label();
            this.lnklblCrtAcc = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cBShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsrN
            // 
            this.lblUsrN.AutoSize = true;
            this.lblUsrN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrN.ForeColor = System.Drawing.Color.Black;
            this.lblUsrN.Location = new System.Drawing.Point(52, 86);
            this.lblUsrN.Name = "lblUsrN";
            this.lblUsrN.Size = new System.Drawing.Size(73, 26);
            this.lblUsrN.TabIndex = 0;
            this.lblUsrN.Text = "Email";
            this.lblUsrN.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(52, 180);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(116, 26);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            this.lblPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsrN
            // 
            this.txtUsrN.BackColor = System.Drawing.Color.Lavender;
            this.txtUsrN.Location = new System.Drawing.Point(56, 115);
            this.txtUsrN.Multiline = true;
            this.txtUsrN.Name = "txtUsrN";
            this.txtUsrN.Size = new System.Drawing.Size(198, 36);
            this.txtUsrN.TabIndex = 1;
            this.txtUsrN.TextChanged += new System.EventHandler(this.txtUsrN_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Lavender;
            this.txtPass.Location = new System.Drawing.Point(56, 209);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 38);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblDontAcc
            // 
            this.lblDontAcc.AutoSize = true;
            this.lblDontAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDontAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontAcc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDontAcc.Location = new System.Drawing.Point(62, 365);
            this.lblDontAcc.Name = "lblDontAcc";
            this.lblDontAcc.Size = new System.Drawing.Size(175, 20);
            this.lblDontAcc.TabIndex = 0;
            this.lblDontAcc.Text = "Don\'t Have An Account";
            this.lblDontAcc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnklblCrtAcc
            // 
            this.lnklblCrtAcc.AutoSize = true;
            this.lnklblCrtAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblCrtAcc.Location = new System.Drawing.Point(87, 397);
            this.lnklblCrtAcc.Name = "lnklblCrtAcc";
            this.lnklblCrtAcc.Size = new System.Drawing.Size(120, 20);
            this.lnklblCrtAcc.TabIndex = 2;
            this.lnklblCrtAcc.TabStop = true;
            this.lnklblCrtAcc.Text = "Create Account";
            this.lnklblCrtAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCrtAcc_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.BlueViolet;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(84, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 53);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cBShowPass
            // 
            this.cBShowPass.AutoSize = true;
            this.cBShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBShowPass.Location = new System.Drawing.Point(79, 264);
            this.cBShowPass.Name = "cBShowPass";
            this.cBShowPass.Size = new System.Drawing.Size(148, 24);
            this.cBShowPass.TabIndex = 13;
            this.cBShowPass.Text = "Show Password";
            this.cBShowPass.UseVisualStyleBackColor = true;
            this.cBShowPass.CheckedChanged += new System.EventHandler(this.cBShowPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 506);
            this.Controls.Add(this.cBShowPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnklblCrtAcc);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsrN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDontAcc);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsrN);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsrN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblDontAcc;
        private System.Windows.Forms.LinkLabel lnklblCrtAcc;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cBShowPass;
    }
}

