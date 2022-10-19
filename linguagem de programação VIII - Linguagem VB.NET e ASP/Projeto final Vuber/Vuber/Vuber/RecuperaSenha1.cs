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
    public partial class RecuperaSenha1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-T25I77U\\SQLEXPRESS;Initial Catalog=VUBER;Integrated Security=True");
        public RecuperaSenha1()
        {
            InitializeComponent();
            
        }

        private void btn_Recuperar_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Closed += (s, args) => this.Close();
            tl.Show();
        }

        private void btn_Recuperar_enviar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
                string cmd = "SELECT CPF FROM DADOS WHERE CPF = '" + txt_Recupera_cpf.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(cmd, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    RecuperaSenha2 rs2 = new RecuperaSenha2(txt_Recupera_cpf.Text);
                    rs2.Closed += (s, args) => this.Close();
                    rs2.Show();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
