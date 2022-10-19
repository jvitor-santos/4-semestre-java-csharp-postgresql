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
    public partial class RecuperaSenha2 : Form
    {
        string telefone, result, cpf, senha_antiga;
        int z;

        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-T25I77U\\SQLEXPRESS;Initial Catalog=VUBER;Integrated Security=True");
        

        public RecuperaSenha2()
        {
            InitializeComponent();
            
        }

        public RecuperaSenha2(string valor)
        {
            cpf = valor;
            InitializeComponent();

            try
            {
                conexao.Open();
                SqlCommand verifica = new SqlCommand("SELECT TELEFONE, SENHA FROM DADOS WHERE CPF = '" + valor + "'", conexao);
                verifica.Parameters.Clear();
                verifica.Parameters.Add("@CPF", SqlDbType.VarChar).Value = valor;
                verifica.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = verifica.ExecuteReader();
                dr.Read();
                telefone = dr.GetString(0);
                senha_antiga = dr.GetString(1);
            }
            finally
            {
                conexao.Close();
            }

            z = telefone.Length;
            result = telefone.Substring(z - 4, 4);

            Label lblTeste = new Label();
            lblTeste.AutoSize = false;
            lblTeste.Text = "Confirme os quatros ultimos \r\n digitos do numero: " + telefone.Substring(0,z-4) + "****";
            lblTeste.TextAlign = ContentAlignment.TopCenter;
            lblTeste.Location = new System.Drawing.Point(50, 178);
            lblTeste.Font = new Font("Tahoma", 14);
            lblTeste.Width = 270;
            lblTeste.Height = 71;
            this.Controls.Add(lblTeste);
        }


        private void reversor(ref string telefone)
        {
            Array letras = telefone.ToArray();
            Array.Reverse(letras);
            telefone = string.Empty;
            foreach (char letra in letras)
                telefone += letra.ToString();
        }



        private void btn_Recupera_voltar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperaSenha1 rs1 = new RecuperaSenha1();
            rs1.Closed += (s, args) => this.Close();
            rs1.Show();
        }

        private void btn_Recupera_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_Telefone.Text == result)
            {
                if (txt_Recupera_senha.Text == txt_Recupera_confirma_senha.Text)
                {
                    if (txt_Recupera_senha.Text != senha_antiga)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE DADOS SET SENHA = '" + txt_Recupera_senha.Text + "' WHERE CPF = " + cpf, conexao);
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
                        MessageBox.Show("Senha alterada com sucesso!", "Alterado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        TelaLogin tl = new TelaLogin();
                        tl.Closed += (s, args) => this.Close();
                        tl.Show();
                    }else
                    {
                        MessageBox.Show("Senhas não pode ser igual que era antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Numero incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
