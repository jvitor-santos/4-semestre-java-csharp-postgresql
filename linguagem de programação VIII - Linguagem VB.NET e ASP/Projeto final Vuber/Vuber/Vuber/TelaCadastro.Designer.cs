namespace Vuber
{
    partial class TelaCadastro
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
            System.Windows.Forms.GroupBox gb_Tipo_conta;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.rb_Aluno = new System.Windows.Forms.RadioButton();
            this.rb_Motorista = new System.Windows.Forms.RadioButton();
            this.rb_Dono = new System.Windows.Forms.RadioButton();
            this.txt_Cadastrar_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Cadastrar_data_nasc = new System.Windows.Forms.TextBox();
            this.txt_Cadastrar_senha = new System.Windows.Forms.TextBox();
            this.txt_Confirmar_senha = new System.Windows.Forms.TextBox();
            this.txt_Cadastrar_telefone = new System.Windows.Forms.TextBox();
            this.txt_Cadastrar_endereco = new System.Windows.Forms.TextBox();
            this.btn_Confirmar_cadastro = new System.Windows.Forms.Button();
            this.btn_Voltar_cadastro = new System.Windows.Forms.Button();
            this.pbox_Logo_cadastro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            gb_Tipo_conta = new System.Windows.Forms.GroupBox();
            gb_Tipo_conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Tipo_conta
            // 
            gb_Tipo_conta.Controls.Add(this.rb_Aluno);
            gb_Tipo_conta.Controls.Add(this.rb_Motorista);
            gb_Tipo_conta.Controls.Add(this.rb_Dono);
            gb_Tipo_conta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gb_Tipo_conta.Location = new System.Drawing.Point(46, 540);
            gb_Tipo_conta.Margin = new System.Windows.Forms.Padding(0);
            gb_Tipo_conta.Name = "gb_Tipo_conta";
            gb_Tipo_conta.Padding = new System.Windows.Forms.Padding(0);
            gb_Tipo_conta.Size = new System.Drawing.Size(272, 113);
            gb_Tipo_conta.TabIndex = 22;
            gb_Tipo_conta.TabStop = false;
            gb_Tipo_conta.Text = "         Tipo de conta";
            // 
            // rb_Aluno
            // 
            this.rb_Aluno.AutoSize = true;
            this.rb_Aluno.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_Aluno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Aluno.Image = ((System.Drawing.Image)(resources.GetObject("rb_Aluno.Image")));
            this.rb_Aluno.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Aluno.Location = new System.Drawing.Point(3, 39);
            this.rb_Aluno.Name = "rb_Aluno";
            this.rb_Aluno.Size = new System.Drawing.Size(60, 71);
            this.rb_Aluno.TabIndex = 19;
            this.rb_Aluno.TabStop = true;
            this.rb_Aluno.Text = "Aluno";
            this.rb_Aluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Aluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_Aluno.UseVisualStyleBackColor = true;
            this.rb_Aluno.CheckedChanged += new System.EventHandler(this.rb_Aluno_CheckedChanged);
            // 
            // rb_Motorista
            // 
            this.rb_Motorista.AutoSize = true;
            this.rb_Motorista.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_Motorista.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Motorista.Image = ((System.Drawing.Image)(resources.GetObject("rb_Motorista.Image")));
            this.rb_Motorista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Motorista.Location = new System.Drawing.Point(178, 39);
            this.rb_Motorista.Name = "rb_Motorista";
            this.rb_Motorista.Size = new System.Drawing.Size(91, 71);
            this.rb_Motorista.TabIndex = 21;
            this.rb_Motorista.TabStop = true;
            this.rb_Motorista.Text = "Motorista";
            this.rb_Motorista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Motorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_Motorista.UseVisualStyleBackColor = true;
            this.rb_Motorista.CheckedChanged += new System.EventHandler(this.rb_Motorista_CheckedChanged);
            // 
            // rb_Dono
            // 
            this.rb_Dono.AutoSize = true;
            this.rb_Dono.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_Dono.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Dono.Image = ((System.Drawing.Image)(resources.GetObject("rb_Dono.Image")));
            this.rb_Dono.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Dono.Location = new System.Drawing.Point(96, 39);
            this.rb_Dono.Name = "rb_Dono";
            this.rb_Dono.Size = new System.Drawing.Size(55, 71);
            this.rb_Dono.TabIndex = 20;
            this.rb_Dono.TabStop = true;
            this.rb_Dono.Text = "Dono";
            this.rb_Dono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_Dono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_Dono.UseVisualStyleBackColor = true;
            this.rb_Dono.CheckedChanged += new System.EventHandler(this.rb_Dono_CheckedChanged);
            // 
            // txt_Cadastrar_Cpf
            // 
            this.txt_Cadastrar_Cpf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cadastrar_Cpf.Location = new System.Drawing.Point(74, 154);
            this.txt_Cadastrar_Cpf.Name = "txt_Cadastrar_Cpf";
            this.txt_Cadastrar_Cpf.Size = new System.Drawing.Size(200, 27);
            this.txt_Cadastrar_Cpf.TabIndex = 0;
            this.txt_Cadastrar_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cadastrar_Cpf.TextChanged += new System.EventHandler(this.txt_Cadastrar_Cpf_TextChanged);
            // 
            // txt_Cadastrar_data_nasc
            // 
            this.txt_Cadastrar_data_nasc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cadastrar_data_nasc.Location = new System.Drawing.Point(74, 221);
            this.txt_Cadastrar_data_nasc.Name = "txt_Cadastrar_data_nasc";
            this.txt_Cadastrar_data_nasc.Size = new System.Drawing.Size(200, 27);
            this.txt_Cadastrar_data_nasc.TabIndex = 1;
            this.txt_Cadastrar_data_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cadastrar_data_nasc.TextChanged += new System.EventHandler(this.txt_Data_nasc_TextChanged);
            // 
            // txt_Cadastrar_senha
            // 
            this.txt_Cadastrar_senha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cadastrar_senha.Location = new System.Drawing.Point(74, 289);
            this.txt_Cadastrar_senha.Name = "txt_Cadastrar_senha";
            this.txt_Cadastrar_senha.Size = new System.Drawing.Size(200, 27);
            this.txt_Cadastrar_senha.TabIndex = 2;
            this.txt_Cadastrar_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cadastrar_senha.UseSystemPasswordChar = true;
            // 
            // txt_Confirmar_senha
            // 
            this.txt_Confirmar_senha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirmar_senha.Location = new System.Drawing.Point(74, 359);
            this.txt_Confirmar_senha.Name = "txt_Confirmar_senha";
            this.txt_Confirmar_senha.Size = new System.Drawing.Size(200, 27);
            this.txt_Confirmar_senha.TabIndex = 3;
            this.txt_Confirmar_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Confirmar_senha.UseSystemPasswordChar = true;
            // 
            // txt_Cadastrar_telefone
            // 
            this.txt_Cadastrar_telefone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cadastrar_telefone.Location = new System.Drawing.Point(74, 430);
            this.txt_Cadastrar_telefone.Name = "txt_Cadastrar_telefone";
            this.txt_Cadastrar_telefone.Size = new System.Drawing.Size(200, 27);
            this.txt_Cadastrar_telefone.TabIndex = 4;
            this.txt_Cadastrar_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Cadastrar_endereco
            // 
            this.txt_Cadastrar_endereco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cadastrar_endereco.Location = new System.Drawing.Point(74, 502);
            this.txt_Cadastrar_endereco.Name = "txt_Cadastrar_endereco";
            this.txt_Cadastrar_endereco.Size = new System.Drawing.Size(200, 27);
            this.txt_Cadastrar_endereco.TabIndex = 5;
            this.txt_Cadastrar_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Confirmar_cadastro
            // 
            this.btn_Confirmar_cadastro.BackColor = System.Drawing.Color.Navy;
            this.btn_Confirmar_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar_cadastro.Location = new System.Drawing.Point(113, 678);
            this.btn_Confirmar_cadastro.Name = "btn_Confirmar_cadastro";
            this.btn_Confirmar_cadastro.Size = new System.Drawing.Size(119, 33);
            this.btn_Confirmar_cadastro.TabIndex = 10;
            this.btn_Confirmar_cadastro.Text = "Confirmar";
            this.btn_Confirmar_cadastro.UseVisualStyleBackColor = false;
            this.btn_Confirmar_cadastro.Click += new System.EventHandler(this.btn_Confirmar_cadastro_Click);
            // 
            // btn_Voltar_cadastro
            // 
            this.btn_Voltar_cadastro.BackColor = System.Drawing.Color.Red;
            this.btn_Voltar_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar_cadastro.Location = new System.Drawing.Point(113, 717);
            this.btn_Voltar_cadastro.Name = "btn_Voltar_cadastro";
            this.btn_Voltar_cadastro.Size = new System.Drawing.Size(119, 32);
            this.btn_Voltar_cadastro.TabIndex = 11;
            this.btn_Voltar_cadastro.Text = "Voltar";
            this.btn_Voltar_cadastro.UseVisualStyleBackColor = false;
            this.btn_Voltar_cadastro.Click += new System.EventHandler(this.btn_Voltar_cadastro_Click);
            // 
            // pbox_Logo_cadastro
            // 
            this.pbox_Logo_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Logo_cadastro.Image")));
            this.pbox_Logo_cadastro.Location = new System.Drawing.Point(12, 12);
            this.pbox_Logo_cadastro.Name = "pbox_Logo_cadastro";
            this.pbox_Logo_cadastro.Size = new System.Drawing.Size(315, 101);
            this.pbox_Logo_cadastro.TabIndex = 12;
            this.pbox_Logo_cadastro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirme sua senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Endereço";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(gb_Tipo_conta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbox_Logo_cadastro);
            this.Controls.Add(this.btn_Voltar_cadastro);
            this.Controls.Add(this.btn_Confirmar_cadastro);
            this.Controls.Add(this.txt_Cadastrar_endereco);
            this.Controls.Add(this.txt_Cadastrar_telefone);
            this.Controls.Add(this.txt_Confirmar_senha);
            this.Controls.Add(this.txt_Cadastrar_senha);
            this.Controls.Add(this.txt_Cadastrar_data_nasc);
            this.Controls.Add(this.txt_Cadastrar_Cpf);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            gb_Tipo_conta.ResumeLayout(false);
            gb_Tipo_conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo_cadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cadastrar_Cpf;
        private System.Windows.Forms.TextBox txt_Cadastrar_data_nasc;
        private System.Windows.Forms.TextBox txt_Cadastrar_senha;
        private System.Windows.Forms.TextBox txt_Confirmar_senha;
        private System.Windows.Forms.TextBox txt_Cadastrar_telefone;
        private System.Windows.Forms.TextBox txt_Cadastrar_endereco;
        private System.Windows.Forms.Button btn_Confirmar_cadastro;
        private System.Windows.Forms.Button btn_Voltar_cadastro;
        private System.Windows.Forms.PictureBox pbox_Logo_cadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_Aluno;
        private System.Windows.Forms.RadioButton rb_Dono;
        private System.Windows.Forms.RadioButton rb_Motorista;
    }
}