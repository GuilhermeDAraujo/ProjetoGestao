using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestao2
{
    public class Pessoa
    {
        public string cpfCadastro { get; set; }
        public string nomeCadastro { get; set; }
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexao = new MySqlConnection();

        public Pessoa() { }

        // metodo para gravar os dados selecionado na tabela pessoa
        public void GravarPessoa()
        {
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para inserir os dados
                    comando.Connection = conexao;
                    comando.CommandText = "insert into pessoas (cpf, nome) " + "value" + "(@cpf, @nome)";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@cpf", cpfCadastro);
                    comando.Parameters.AddWithValue("@nome", nomeCadastro);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Gravado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception obj)
            {

                MessageBox.Show("CPF já cadastrado: " , "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // metodo para validar se o cpf já está cadastrado na coluna cpf na tabela pessoa
        public bool ValidarCPFPessoa(string cpf)
        {
            string nome = null;
            try
            {
                using (MySqlConnection conexao = BancoDeDados.AbrirConexao())
                {
                    //iniciando conexao e comando sql para validar se o cpf já está cadastrado na coluna cpf na tabela pessoa
                    comando.Connection = conexao;
                    comando.CommandText = "select cpf from pessoas where cpf = @cpf";

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@CPF", cpf);

                    object resultado = comando.ExecuteScalar();

                    if (resultado == null)
                    {
                        return true;
                    }
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show("Erro ao consultar banco de dados: " + obj.Message);
            }
            return false;
        }
    }
}

