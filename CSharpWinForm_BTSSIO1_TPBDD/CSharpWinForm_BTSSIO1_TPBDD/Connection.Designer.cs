namespace CSharpWinForm_BTSSIO1_TPBDD
{
    partial class Connection
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
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.txtBox_mdp = new System.Windows.Forms.TextBox();
            this.txtBox_service = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_lesLbls = new System.Windows.Forms.Label();
            this.lbl_motDePasse = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_login
            // 
            this.txtBox_login.Location = new System.Drawing.Point(131, 68);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.Size = new System.Drawing.Size(230, 20);
            this.txtBox_login.TabIndex = 0;
            // 
            // txtBox_mdp
            // 
            this.txtBox_mdp.Location = new System.Drawing.Point(131, 111);
            this.txtBox_mdp.Name = "txtBox_mdp";
            this.txtBox_mdp.PasswordChar = '*';
            this.txtBox_mdp.Size = new System.Drawing.Size(230, 20);
            this.txtBox_mdp.TabIndex = 1;
            // 
            // txtBox_service
            // 
            this.txtBox_service.Location = new System.Drawing.Point(131, 155);
            this.txtBox_service.Name = "txtBox_service";
            this.txtBox_service.ReadOnly = true;
            this.txtBox_service.Size = new System.Drawing.Size(230, 20);
            this.txtBox_service.TabIndex = 2;
            this.txtBox_service.Text = "XE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connexion à a base Oracle ";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(53, 71);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(33, 13);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "Login";
            // 
            // lbl_lesLbls
            // 
            this.lbl_lesLbls.AutoSize = true;
            this.lbl_lesLbls.Location = new System.Drawing.Point(53, 114);
            this.lbl_lesLbls.Name = "lbl_lesLbls";
            this.lbl_lesLbls.Size = new System.Drawing.Size(72, 13);
            this.lbl_lesLbls.TabIndex = 5;
            this.lbl_lesLbls.Text = "Mot de Passe";
            // 
            // lbl_motDePasse
            // 
            this.lbl_motDePasse.AutoSize = true;
            this.lbl_motDePasse.Location = new System.Drawing.Point(53, 158);
            this.lbl_motDePasse.Name = "lbl_motDePasse";
            this.lbl_motDePasse.Size = new System.Drawing.Size(43, 13);
            this.lbl_motDePasse.TabIndex = 6;
            this.lbl_motDePasse.Text = "Service";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(203, 205);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_motDePasse);
            this.Controls.Add(this.lbl_lesLbls);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_service);
            this.Controls.Add(this.txtBox_mdp);
            this.Controls.Add(this.txtBox_login);
            this.Name = "Connection";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_login;
        private System.Windows.Forms.TextBox txtBox_mdp;
        private System.Windows.Forms.TextBox txtBox_service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_lesLbls;
        private System.Windows.Forms.Label lbl_motDePasse;
        private System.Windows.Forms.Button btn_Ok;
    }
}