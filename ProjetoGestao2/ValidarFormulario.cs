using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoGestao2
{
    public class ValidarFormulario
    {
        // metodo para validar o campo valor, não permitindo valores nulos e negativos e letras
        public static bool ValidarValor(string valor)
        {
            double converterValor;

            if (string.IsNullOrWhiteSpace(valor) || !double.TryParse(valor, out converterValor) || converterValor < 0.0)
            {
                return false;
            }
            return true;
        }

        // metodo para validar as datas, não permitindo valor nulos e que a data de compra seja maior que a data da entrada
        public static bool ValidarData(string dataCompra, string dataEntrada)
        {
            if (string.IsNullOrWhiteSpace(dataCompra) || string.IsNullOrWhiteSpace(dataEntrada))
            {
                return false;
            }

            DateTime converterDataCompra;
            DateTime converterDataEntrada;

            if (!DateTime.TryParse(dataCompra, out converterDataCompra) || !DateTime.TryParse(dataEntrada, out converterDataEntrada))
            {
                MessageBox.Show("Por favor, insira datas válidas.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (converterDataCompra > converterDataEntrada)
            {
                MessageBox.Show("A data de compra não pode ser maior que a data de entrada!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // metodo para validar o cpf, nao permitindo valor nulo
        public static bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return false;
            }
            return true;
        }
        
        // metodo para validar o banco, nao permitindo valor nulo
        public static bool ValidarBanco(string banco)
        {
            if (string.IsNullOrWhiteSpace(banco))
            {
                return false;
            }
            return true;
        }

        // metodo para validar o historico, nao permitindo valor nulo
        public static bool ValidarHistorico(string historico)
        {
            if (string.IsNullOrEmpty(historico))
            {
                return false;
            }
            return true;
        }

        // metodo para validar o nome no cadastro pessoa, nao permitindo valor nulo
        public static bool ValidarNome (string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) 
            {
                return false;
            }
            return true;
        }

        // metodo para validar a pesquisa, nao permitindo valor nulo
        public static bool ValidarPesquisa(string campo)
        {
            if (string.IsNullOrWhiteSpace(campo))
            {
                return false;
            }
            return true;
        }
    }
}

