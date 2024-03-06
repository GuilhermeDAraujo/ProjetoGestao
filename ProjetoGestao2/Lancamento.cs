using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjetoGestao2
{
    public class Lancamento
    {
        public string cpfLancamento { get; set; }
        public int id { get; set; }
        public string banco { get; set; }
        public double valor { get; set; }
        public DateTime dataCompra { get; set; }
        public DateTime dataEntrada { get; set; }
        public string historico { get; set; }
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexao = new MySqlConnection();


        // metodo para gravar os dados no banco de dados
        public void GravarLancamento()
        {
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para inserir os dados
                    comando.Connection = conexao;
                    comando.CommandText = "insert into lancamentos (banco, compra_data, entrada_data, valor, historico, cpf_lancamentos)" + " values "
                        + "(@banco, @dataCompra, @dataEntrada, @valor, @historico, @cpf_lancamentos)";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@banco", this.banco);
                    comando.Parameters.AddWithValue("@valor", this.valor);
                    comando.Parameters.AddWithValue("@dataCompra", this.dataCompra);
                    comando.Parameters.AddWithValue("@dataEntrada", this.dataEntrada);
                    comando.Parameters.AddWithValue("@historico", this.historico);
                    comando.Parameters.AddWithValue("@cpf_lancamentos", this.cpfLancamento);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Ocorreu um erro: " + obj.Message, " ERRO: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //altera o lancamento selecionado
        public void AlterarLancamento()
        {
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para alterar os dados
                    comando.Connection = conexao;
                    comando.CommandText = "update lancamentos set banco = @banco , compra_data = @dataCompra, entrada_data = @dataEntrada, valor = @valor, historico = @historico, cpf_lancamentos = @cpf_lancamentos  where id = @id";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@banco", banco);
                    comando.Parameters.AddWithValue("@dataCompra", dataCompra);
                    comando.Parameters.AddWithValue("@dataEntrada", dataEntrada);
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters.AddWithValue("@historico", historico);
                    comando.Parameters.AddWithValue("@cpf_lancamentos", cpfLancamento);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Ocorreu um erro: " + obj.Message, " ERRO: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // atualizar o grid após alguma modificação no banco de dados
        public DataTable ExibirDataGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para selecionar todas colunas do banco de dados
                    string sql = "select * from lancamentos";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter temp = new MySqlDataAdapter(comando);
                    temp.Fill(dt);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Erro ao exibir dados: ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // exclui o lancamento selecionado do banco de dados
        public void ExcluirLancamento()
        {
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para excluir os dados
                    comando.Connection = conexao;
                    comando.CommandText = "delete from lancamentos where id = @id";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@id", id);

                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este lançamento?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Erro ao deletar! " + obj.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // verifica se o CPF informado está cadastrado no banco de dados
        public string ValidarCPF(string cpf)
        {
            string nome = null;
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para procurar se o cpf informado pelo usuario já está cadastrado na coluna CPF do banco de dados.
                    comando.Connection = conexao;
                    comando.CommandText = "select nome from pessoas where cpf = @cpf";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@CPF", cpf);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        nome = resultado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("CPF não cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Erro ao consultar banco de dados: " + obj.Message);
            }
            return nome;
        }

        // utilizado para filtar os lançamentos por categoria, de acordo com o selecionado
        public DataTable PesquisarLancamento(string campo, string filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para pesquisar no banco de dados. O usuario vai selecionar o campo e o codigo vai procurar o valor inserido pelo usuario no filtro no campo selecionado.
                    comando.Connection = conexao;

                    comando.CommandText = $"Select * from lancamentos where {campo} = @filtro";

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@filtro", filtro);

                    MySqlDataAdapter tempo = new MySqlDataAdapter(comando);
                    tempo.Fill(dt);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Erro ao pesquisar!" + obj.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
