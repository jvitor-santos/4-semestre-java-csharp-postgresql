using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_forms_28_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIgual_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double valor1, valor2, result;
            char oper;
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            oper = char.Parse(cmbOper.Text);

            switch (oper)
            {
                case '+':
                    result = valor1 + valor2;
                    lblResult.Text = Convert.ToString(result);
                    break;
                case '-':
                    result = valor1 - valor2;
                    lblResult.Text = Convert.ToString(result);
                    break;
                case 'x':
                    result = valor1 * valor2;
                    lblResult.Text = Convert.ToString(result);
                    break;
                case '÷':
                    if (valor2 != 0)
                    {
                        result = valor1 / valor2;
                        lblResult.Text = Convert.ToString(result);
                    }else
                    {
                        lblResult.Text = "ERRO!";
                    }
                        break;
                case '%':
                    result = valor1 % valor2;
                    lblResult.Text = Convert.ToString(result);
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResult.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Deseja realmente sair?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
            {
               MessageBox.Show("Obrigado por usar nosso sistema", "Sair", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Application.Exit();
            }
            
        }
    }
}
