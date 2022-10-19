namespace Vuber
{
    partial class RecuperaSenha1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperaSenha1));
            this.pbox_Logo_login = new System.Windows.Forms.PictureBox();
            this.txt_Recupera_cpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Recuperar_enviar = new System.Windows.Forms.Button();
            this.btn_Recuperar_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Logo_login
            // 
            this.pbox_Logo_login.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Logo_login.Image")));
            this.pbox_Logo_login.Location = new System.Drawing.Point(16, 12);
            this.pbox_Logo_login.Name = "pbox_Logo_login";
            this.pbox_Logo_login.Size = new System.Drawing.Size(316, 101);
            this.pbox_Logo_login.TabIndex = 6;
            this.pbox_Logo_login.TabStop = false;
            // 
            // txt_Recupera_cpf
            // 
            this.txt_Recupera_cpf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recupera_cpf.Location = new System.Drawing.Point(98, 185);
            this.txt_Recupera_cpf.Name = "txt_Recupera_cpf";
            this.txt_Recupera_cpf.Size = new System.Drawing.Size(160, 27);
            this.txt_Recupera_cpf.TabIndex = 7;
            this.txt_Recupera_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 197);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira o CPF para estar alterando a            senha";
            // 
            // btn_Recuperar_enviar
            // 
            this.btn_Recuperar_enviar.BackColor = System.Drawing.Color.Navy;
            this.btn_Recuperar_enviar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recuperar_enviar.Location = new System.Drawing.Point(131, 513);
            this.btn_Recuperar_enviar.Name = "btn_Recuperar_enviar";
            this.btn_Recuperar_enviar.Size = new System.Drawing.Size(87, 34);
            this.btn_Recuperar_enviar.TabIndex = 9;
            this.btn_Recuperar_enviar.Text = "Enviar";
            this.btn_Recuperar_enviar.UseVisualStyleBackColor = false;
            this.btn_Recuperar_enviar.Click += new System.EventHandler(this.btn_Recuperar_enviar_Click);
            // 
            // btn_Recuperar_voltar
            // 
            this.btn_Recuperar_voltar.BackColor = System.Drawing.Color.Red;
            this.btn_Recuperar_voltar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recuperar_voltar.Location = new System.Drawing.Point(131, 586);
            this.btn_Recuperar_voltar.Name = "btn_Recuperar_voltar";
            this.btn_Recuperar_voltar.Size = new System.Drawing.Size(87, 34);
            this.btn_Recuperar_voltar.TabIndex = 10;
            this.btn_Recuperar_voltar.Text = "Voltar";
            this.btn_Recuperar_voltar.UseVisualStyleBackColor = false;
            this.btn_Recuperar_voltar.Click += new System.EventHandler(this.btn_Recuperar_voltar_Click);
            // 
            // RecuperaSenha1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(this.btn_Recuperar_voltar);
            this.Controls.Add(this.btn_Recuperar_enviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Recupera_cpf);
            this.Controls.Add(this.pbox_Logo_login);
            this.Name = "RecuperaSenha1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperaSenha1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Logo_login;
        private System.Windows.Forms.TextBox txt_Recupera_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Recuperar_enviar;
        private System.Windows.Forms.Button btn_Recuperar_voltar;
    }
}