namespace loginForm
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.btnReg = new System.Windows.Forms.Button();
            this.lnklblCrtAcc = new System.Windows.Forms.LinkLabel();
            this.txtCnfrmPass = new System.Windows.Forms.TextBox();
            this.txtUsrN = new System.Windows.Forms.TextBox();
            this.lblGetStrt = new System.Windows.Forms.Label();
            this.lblHaveAcc = new System.Windows.Forms.Label();
            this.lblCnfrmPass = new System.Windows.Forms.Label();
            this.lblUsrN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cBShowPass = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.text_add = new System.Windows.Forms.TextBox();
            this.txt_cntct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.BlueViolet;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(246, 418);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(197, 72);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lnklblCrtAcc
            // 
            this.lnklblCrtAcc.AutoSize = true;
            this.lnklblCrtAcc.Location = new System.Drawing.Point(436, 371);
            this.lnklblCrtAcc.Name = "lnklblCrtAcc";
            this.lnklblCrtAcc.Size = new System.Drawing.Size(129, 20);
            this.lnklblCrtAcc.TabIndex = 10;
            this.lnklblCrtAcc.TabStop = true;
            this.lnklblCrtAcc.Text = "Login to Account";
            this.lnklblCrtAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCrtAcc_LinkClicked);
            // 
            // txtCnfrmPass
            // 
            this.txtCnfrmPass.BackColor = System.Drawing.Color.Lavender;
            this.txtCnfrmPass.Location = new System.Drawing.Point(16, 325);
            this.txtCnfrmPass.Multiline = true;
            this.txtCnfrmPass.Name = "txtCnfrmPass";
            this.txtCnfrmPass.PasswordChar = '*';
            this.txtCnfrmPass.Size = new System.Drawing.Size(250, 39);
            this.txtCnfrmPass.TabIndex = 8;
            this.txtCnfrmPass.TextChanged += new System.EventHandler(this.txtCnfrmPass_TextChanged);
            // 
            // txtUsrN
            // 
            this.txtUsrN.BackColor = System.Drawing.Color.Lavender;
            this.txtUsrN.Location = new System.Drawing.Point(16, 132);
            this.txtUsrN.Multiline = true;
            this.txtUsrN.Name = "txtUsrN";
            this.txtUsrN.Size = new System.Drawing.Size(250, 39);
            this.txtUsrN.TabIndex = 9;
            this.txtUsrN.TextChanged += new System.EventHandler(this.txtUsrN_TextChanged);
            // 
            // lblGetStrt
            // 
            this.lblGetStrt.AutoSize = true;
            this.lblGetStrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGetStrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStrt.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblGetStrt.Location = new System.Drawing.Point(70, 32);
            this.lblGetStrt.Name = "lblGetStrt";
            this.lblGetStrt.Size = new System.Drawing.Size(154, 37);
            this.lblGetStrt.TabIndex = 4;
            this.lblGetStrt.Text = "Get Start";
            this.lblGetStrt.Click += new System.EventHandler(this.lblGetStrt_Click);
            // 
            // lblHaveAcc
            // 
            this.lblHaveAcc.AutoSize = true;
            this.lblHaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveAcc.ForeColor = System.Drawing.Color.DimGray;
            this.lblHaveAcc.Location = new System.Drawing.Point(396, 342);
            this.lblHaveAcc.Name = "lblHaveAcc";
            this.lblHaveAcc.Size = new System.Drawing.Size(215, 22);
            this.lblHaveAcc.TabIndex = 5;
            this.lblHaveAcc.Text = "Already Have An Account";
            // 
            // lblCnfrmPass
            // 
            this.lblCnfrmPass.AutoSize = true;
            this.lblCnfrmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCnfrmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnfrmPass.ForeColor = System.Drawing.Color.Black;
            this.lblCnfrmPass.Location = new System.Drawing.Point(12, 292);
            this.lblCnfrmPass.Name = "lblCnfrmPass";
            this.lblCnfrmPass.Size = new System.Drawing.Size(226, 29);
            this.lblCnfrmPass.TabIndex = 6;
            this.lblCnfrmPass.Text = "Confirm Password";
            // 
            // lblUsrN
            // 
            this.lblUsrN.AutoSize = true;
            this.lblUsrN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrN.ForeColor = System.Drawing.Color.Black;
            this.lblUsrN.Location = new System.Drawing.Point(12, 100);
            this.lblUsrN.Name = "lblUsrN";
            this.lblUsrN.Size = new System.Drawing.Size(79, 29);
            this.lblUsrN.TabIndex = 7;
            this.lblUsrN.Text = "Email";
            this.lblUsrN.Click += new System.EventHandler(this.lblUsrN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(383, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Lavender;
            this.txtPass.Location = new System.Drawing.Point(16, 231);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(250, 39);
            this.txtPass.TabIndex = 8;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnClear.Location = new System.Drawing.Point(246, 527);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 72);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cBShowPass
            // 
            this.cBShowPass.AutoSize = true;
            this.cBShowPass.Location = new System.Drawing.Point(118, 371);
            this.cBShowPass.Name = "cBShowPass";
            this.cBShowPass.Size = new System.Drawing.Size(148, 24);
            this.cBShowPass.TabIndex = 12;
            this.cBShowPass.Text = "Show Password";
            this.cBShowPass.UseVisualStyleBackColor = true;
            this.cBShowPass.CheckedChanged += new System.EventHandler(this.cBShowPass_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // text_add
            // 
            this.text_add.BackColor = System.Drawing.Color.Lavender;
            this.text_add.Location = new System.Drawing.Point(379, 141);
            this.text_add.Multiline = true;
            this.text_add.Name = "text_add";
            this.text_add.Size = new System.Drawing.Size(250, 39);
            this.text_add.TabIndex = 8;
            this.text_add.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txt_cntct
            // 
            this.txt_cntct.BackColor = System.Drawing.Color.Lavender;
            this.txt_cntct.Location = new System.Drawing.Point(379, 262);
            this.txt_cntct.Multiline = true;
            this.txt_cntct.Name = "txt_cntct";
            this.txt_cntct.Size = new System.Drawing.Size(250, 39);
            this.txt_cntct.TabIndex = 8;
            this.txt_cntct.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(383, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(694, 646);
            this.Controls.Add(this.cBShowPass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lnklblCrtAcc);
            this.Controls.Add(this.txt_cntct);
            this.Controls.Add(this.text_add);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCnfrmPass);
            this.Controls.Add(this.txtUsrN);
            this.Controls.Add(this.lblGetStrt);
            this.Controls.Add(this.lblHaveAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCnfrmPass);
            this.Controls.Add(this.lblUsrN);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.LinkLabel lnklblCrtAcc;
        private System.Windows.Forms.TextBox txtCnfrmPass;
        private System.Windows.Forms.TextBox txtUsrN;
        private System.Windows.Forms.Label lblGetStrt;
        private System.Windows.Forms.Label lblHaveAcc;
        private System.Windows.Forms.Label lblCnfrmPass;
        private System.Windows.Forms.Label lblUsrN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cBShowPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txt_cntct;
        private System.Windows.Forms.TextBox text_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}