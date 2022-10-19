using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vuber
{
    public partial class TelaCadastro : Form
    {
        string txt_tipo_conta ="";
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void txt_Cadastrar_Cpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Data_nasc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rb_Dono_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_conta="dono";
        }

        private void rb_Motorista_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_conta = "motorista";
        }

        private void rb_Aluno_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_conta = "aluno";
        }

        private void btn_Confirmar_cadastro_Click(object sender, EventArgs e)
        {
            if (txt_Cadastrar_senha.Text == txt_Confirmar_senha.Text)
            {
                string strcon = "Data Source=DESKTOP-T25I77U\\SQLEXPRESS;Initial Catalog=VUBER;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO DADOS (CPF, DATA_NASC, SENHA, TELEFONE, ENDERECO, TIPO_CONTA) VALUES ('" + txt_Cadastrar_Cpf.Text + "', '" + txt_Cadastrar_data_nasc.Text + "', '" + txt_Cadastrar_senha.Text + "', '" + txt_Cadastrar_telefone.Text + "', '" + txt_Cadastrar_endereco.Text + "', '" + txt_tipo_conta + "')", conexao);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
                MessageBox.Show("Usuario cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                TelaInicial tela_inicial = new TelaInicial();
                tela_inicial.Closed += (s, args) => this.Close();
                tela_inicial.Show();
            }
            else
            {
                MessageBox.Show("Senha incorreta, confira e tente novamente", "Senhas não coincidem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Voltar_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela_inicial = new TelaInicial();
            tela_inicial.Closed += (s, args) => this.Close();
            tela_inicial.Show();
        }
    }
}
