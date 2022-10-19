namespace Vuber
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.pbox_Logo_login = new System.Windows.Forms.PictureBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.vuberDataSet1 = new Vuber.VUBERDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Esqueci_minha_senha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuberDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cpf.Location = new System.Drawing.Point(97, 185);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(160, 27);
            this.txt_Cpf.TabIndex = 0;
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Senha
            // 
            this.txt_Senha.AccessibleDescription = "";
            this.txt_Senha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(97, 283);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(160, 27);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.Tag = "";
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Navy;
            this.btn_Entrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(134, 421);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(87, 34);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.Red;
            this.btn_Voltar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(134, 491);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(87, 34);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // pbox_Logo_login
            // 
            this.pbox_Logo_login.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Logo_login.Image")));
            this.pbox_Logo_login.Location = new System.Drawing.Point(12, 12);
            this.pbox_Logo_login.Name = "pbox_Logo_login";
            this.pbox_Logo_login.Size = new System.Drawing.Size(316, 101);
            this.pbox_Logo_login.TabIndex = 5;
            this.pbox_Logo_login.TabStop = false;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(145, 256);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(76, 24);
            this.lbl_Senha.TabIndex = 6;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpf.Location = new System.Drawing.Point(101, 158);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(152, 24);
            this.lbl_Cpf.TabIndex = 7;
            this.lbl_Cpf.Text = "Insira seu CPF:";
            this.lbl_Cpf.Click += new System.EventHandler(this.lbl_Cpf_Click);
            // 
            // vuberDataSet1
            // 
            this.vuberDataSet1.DataSetName = "VUBERDataSet";
            this.vuberDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Esqueci_minha_senha
            // 
            this.lbl_Esqueci_minha_senha.AutoSize = true;
            this.lbl_Esqueci_minha_senha.LinkColor = System.Drawing.Color.Black;
            this.lbl_Esqueci_minha_senha.Location = new System.Drawing.Point(122, 330);
            this.lbl_Esqueci_minha_senha.Name = "lbl_Esqueci_minha_senha";
            this.lbl_Esqueci_minha_senha.Size = new System.Drawing.Size(108, 13);
            this.lbl_Esqueci_minha_senha.TabIndex = 8;
            this.lbl_Esqueci_minha_senha.TabStop = true;
            this.lbl_Esqueci_minha_senha.Text = "Esqueci minha senha";
            this.lbl_Esqueci_minha_senha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Esqueci_minha_senha_LinkClicked);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(this.lbl_Esqueci_minha_senha);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.pbox_Logo_login);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Cpf);
            this.DoubleBuffered = true;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuberDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.PictureBox pbox_Logo_login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Cpf;
        private VUBERDataSet vuberDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.LinkLabel lbl_Esqueci_minha_senha;
    }
}