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
    public partial class TelaLogin : Form
    {
        string tipo_conta;
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-T25I77U\\SQLEXPRESS;Initial Catalog=VUBER;Integrated Security=True");
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //string strcon = ;
            //string teste_cpf, teste_senha, teste_tipo_conta;


            
            try
            {
                conexao.Open();
                string cmd = "SELECT CPF, SENHA, TIPO_CONTA FROM DADOS WHERE CPF = '" + txt_Cpf.Text + "' AND SENHA = '" + txt_Senha.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(cmd, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand verifica = new SqlCommand("SELECT TIPO_CONTA FROM DADOS WHERE CPF = '" + txt_Cpf.Text + "'",conexao);
                    verifica.Parameters.Clear();
                    verifica.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_Cpf.Text;
                    verifica.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = verifica.ExecuteReader();
                    dr.Read();
                    tipo_conta = dr.GetString(0);

                    if (tipo_conta == "aluno")
                    {
                        this.Hide();
                        TelaAluno ta = new TelaAluno();
                        ta.Closed += (s, args) => this.Close();
                        ta.Show();
                    }else if (tipo_conta == "motorista")
                    {
                        this.Hide();
                        TelaMotorista tm = new TelaMotorista();
                        tm.Closed += (s, args) => this.Close();
                        tm.Show();
                    }else if (tipo_conta == "dono")
                    {
                        this.Hide();
                        TelaDono td = new TelaDono();
                        td.Closed += (s, args) => this.Close();
                        td.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            finally
            {
                conexao.Close();
            }
        }

        private void lbl_Cpf_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela_inicial = new TelaInicial();
            tela_inicial.Closed += (s, args) => this.Close();
            tela_inicial.Show();
        }

        private void lbl_Esqueci_minha_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RecuperaSenha1 rs1 = new RecuperaSenha1();
            rs1.Closed += (s, args) => this.Close();
            rs1.Show();
        }
    }
}
