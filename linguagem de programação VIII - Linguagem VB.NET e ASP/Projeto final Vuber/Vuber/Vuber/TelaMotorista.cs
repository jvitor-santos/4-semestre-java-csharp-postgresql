using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuber
{
    public partial class TelaMotorista : Form
    {
        public TelaMotorista()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Closed += (s, args) => this.Close();
            tl.Show();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area em desenvolvimento", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area em desenvolvimento", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area em desenvolvimento", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
