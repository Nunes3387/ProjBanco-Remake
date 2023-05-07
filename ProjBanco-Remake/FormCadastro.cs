using ProjBanco_Remake.Controller;
using ProjBanco_Remake.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjBanco_Remake
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoContaPoupanca = txtDescricaoContaPoupanca.Text,
                QtdTempoContaPoupanca = txtQtdtempo.Text,
                TaxaJuros = Convert.ToDouble(txtJuros.Text),
                SaldoContaPoupanca = Convert.ToDouble(txtSaldoPoupanca)
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");
            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoContaCorrente = txtDescricaoContaCorrente.Text,
                LimiteContaCorrente = Convert.ToInt16(txtLimiteContaCorrente.Text),
                SaldoContaCorrente = Convert.ToDouble(txtSaldoContaCorrente.Text),
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoBonus = txtBonusDescricao.Text,
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaodoSegmento = txtDescricaodoSegmento.Text,
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                Bairro = txtBairro.Text,
                Rua = txtRua.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Numero = txtNumero.Text,
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoMoeda = txtDescricaoMoeda.Text,
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");

            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }
    }
}
