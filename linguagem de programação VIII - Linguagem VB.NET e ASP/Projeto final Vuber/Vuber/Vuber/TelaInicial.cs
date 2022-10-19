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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tela_login = new TelaLogin();
            tela_login.Closed += (s, args) => this.Close();
            tela_login.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastro tela_cadastro = new TelaCadastro();
            tela_cadastro.Closed += (s, args) => this.Close();
            tela_cadastro.Show();
        }
    }
}
