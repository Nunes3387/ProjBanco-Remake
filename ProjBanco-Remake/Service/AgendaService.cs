using ProjBanco_Remake.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBanco_Remake.Service
{
    internal class AgendaService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\NuNes\OneDrive\Área de Trabalho\ProjProvaCSharp_Atualizado\ProjProvaCSharp_Atualizado\bancoProj.mdf;";


        SqlConnection conn;

        public AgendaService()
        {
            //Abertua da conexao
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        public bool Inserir(Agenda agenda)
        {
            string strInsertCliente = "insert into cliente (Nome, Telefone) values (@Nome, @Telefone);";
            SqlCommand commandInsertCliente = new SqlCommand(strInsertCliente, conn);
            commandInsertCliente.Parameters.Add(new SqlParameter("@Nome", agenda.Nome));
            commandInsertCliente.Parameters.Add(new SqlParameter("@Telefone", agenda.Telefone));
            commandInsertCliente.ExecuteNonQuery();

            string strInsertEndereco = "insert into endereco (Estado, Cidade, Bairro, Numero, Rua) values (@Estado, @Cidade, @Bairro, @Numero, @Rua);";
            SqlCommand commandInsertEndereco = new SqlCommand(strInsertEndereco, conn);
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Estado", agenda.Estado));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Cidade", agenda.Cidade));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Bairro", agenda.Bairro));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Numero", agenda.Numero));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Rua", agenda.Rua));
            commandInsertEndereco.ExecuteNonQuery();

            string strInsertContaPoupanca = "insert into contapoupanca (DescricaoContaPoupanca, QtdTempoContaPoupanca, TaxaJuros, Saldo) values (@DescricaoContaPoupanca, @QtdTempoContaPoupanca, @TaxaJuros, @SaldoContaPoupanca);";
            SqlCommand commandInsertContaPoupanca = new SqlCommand(strInsertContaPoupanca, conn);
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@DescricaoContaPoupanca", agenda.DescricaoContaPoupanca));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@QtdTempoContaPoupanca", agenda.QtdTempoContaPoupanca));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@TaxaJuros", agenda.TaxaJuros));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@SaldoContaPoupanca", agenda.SaldoContaPoupanca));
            commandInsertContaPoupanca.ExecuteNonQuery();

            string strInsertContaCorrente = "insert into contacorrente (DescricaoContaCorrente, LimiteContaCorrente, SaldoContaCorrente) values (@DescricaoContaCorrente, @LimiteContaCorrente, @SaldoContaCorrente);";
            SqlCommand commandInsertContaCorrente = new SqlCommand(strInsertContaCorrente, conn);
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@DescricaoContaCorrente", agenda.DescricaoContaCorrente));
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@LimiteContaCorrente", agenda.LimiteContaCorrente));
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@saldoContaCorrente", agenda.SaldoContaCorrente));
            commandInsertContaCorrente.ExecuteNonQuery();

            string strInsertSegmento = "insert into segmento (DescricaodoSegmento) values (@DescricaodoSegmento);";
            SqlCommand commandInsertSegmento = new SqlCommand(strInsertSegmento, conn);
            commandInsertSegmento.Parameters.Add(new SqlParameter("@DescricaoSegmento", agenda.DescricaodoSegmento));
            commandInsertSegmento.ExecuteNonQuery();

            string strInsertMoeda = "insert into moeda (Descricao) values (@DescricaoMoeda);";
            SqlCommand commandInsertMoeda = new SqlCommand(strInsertMoeda, conn);
            commandInsertMoeda.Parameters.Add(new SqlParameter("@DescricaoMoeda", agenda.DescricaoMoeda));
            commandInsertMoeda.ExecuteNonQuery();

            string strInsertBonus = "insert into bonus (DescricaoBonus) values (@DescricaoBonus);";
            SqlCommand commandInsertBonus = new SqlCommand(strInsertBonus, conn);
            commandInsertBonus.Parameters.Add(new SqlParameter("@DescricaoBonus", agenda.DescricaoBonus));
            commandInsertBonus.ExecuteNonQuery();

            conn.Close();
            return true;
        }

        public List<Agenda> TodosOsRegistros()
        {
            List<Agenda> agendas = new List<Agenda>();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT 'cliente' AS tabela, * FROM cliente");
            sb.Append("       UNION ALL");
            sb.Append("       SELECT 'endereco' AS tabela, * FROM endereco ");
            sb.Append("       UNION ALL   ");
            sb.Append("       SELECT 'contapoupanca' AS tabela, * FROM contapoupanca   ");
            sb.Append("       UNION ALL   ");
            sb.Append("       SELECT 'contacorrente' AS tabela, * FROM contacorrente   ");
            sb.Append("       UNION ALL      ");
            sb.Append("       SELECT 'segmento' AS tabela, * FROM segmento");
            sb.Append("       UNION ALL");
            sb.Append("       SELECT 'moeda' AS tabela, * FROM moeda");
            sb.Append("       UNION ALL");
            sb.Append("       SELECT 'bonus' AS tabela, * FROM bonus;");


            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Agenda agenda = new Agenda();

                agenda.Id = Convert.ToInt32(dr["Id"]);
                agenda.Nome = dr["Nome"].ToString();
                agenda.Telefone = dr["Telefone"].ToString();
                agenda.Estado = dr["Estado"].ToString();
                agenda.Cidade = dr["Cidade"].ToString();
                agenda.Bairro = dr["Bairro"].ToString();
                agenda.Numero = dr["Numero"].ToString();
                agenda.Rua = dr["Rua"].ToString();
                agenda.DescricaoContaPoupanca = dr["Descricao da Conta Poupanca"].ToString();
                agenda.QtdTempoContaPoupanca = dr["Quantidade de Tempo da Conta Poupanca"].ToString();
                agenda.TaxaJuros = Convert.ToDouble(dr["Taxa Juros"]);
                agenda.SaldoContaPoupanca = Convert.ToDouble(dr["Saldo Poupanca"]);
                agenda.DescricaoContaCorrente = dr["Descricao da Conta Corrente"].ToString();
                agenda.LimiteContaCorrente = Convert.ToDouble(dr["Limite da Conta Corrente"]);
                agenda.SaldoContaCorrente = Convert.ToDouble(dr["Saldo da Conta Corrente"]);
                agenda.DescricaodoSegmento = dr["Descricao do Segmento"].ToString();
                agenda.DescricaoMoeda = dr["Descricao da Moeda"].ToString();
                agenda.DescricaoBonus = dr["Descricao do Bonus"].ToString();


                agendas.Add(agenda);
            }
            return agendas;
        }
    }
}
