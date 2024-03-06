using MySql.Data.MySqlClient;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace ProjetoGestao2
{
    public partial class fmCadastrarLancamentos : Form
    {
        Lancamento lancamento = new Lancamento();

        public fmCadastrarLancamentos()
        {
            InitializeComponent();
        }

        // executa o metodo gravar da classe Lancamento, e valida os campos atraves dos metodos da classe ValidarForm.
        private void btGravar_Click(object sender, EventArgs e)
        {
            lancamento.ValidarCPF(txtCpfLancamento.Text);

            if (!ValidarFormulario.ValidarCPF(txtCpfLancamento.Text))
            {
                MessageBox.Show("Por favor, preencha o campo CPF", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarFormulario.ValidarBanco(txtBanco.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Banco", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarFormulario.ValidarValor(txtValor.Text))
            {
                MessageBox.Show("Informe um valor válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarFormulario.ValidarData(txtDataCompra.Text, txtDataEntrada.Text))
            {
                return;
            }

            if (!ValidarFormulario.ValidarHistorico(txtHistorico.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Histórico", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lancamento.cpfLancamento = txtCpfLancamento.Text;
            lancamento.banco = txtBanco.Text;
            lancamento.valor = double.Parse(txtValor.Text);
            lancamento.dataCompra = DateTime.Parse(txtDataCompra.Text);
            lancamento.dataEntrada = DateTime.Parse(txtDataEntrada.Text);
            lancamento.historico = txtHistorico.Text;

            lancamento.GravarLancamento();
            dtGrid.DataSource = lancamento.ExibirDataGrid();
        }

        // exibe o formulario lançamento após ser chamado no form principal
        private void fmCadastrarLancamentos_Load(object sender, EventArgs e)
        {
            dtGrid.DataSource = lancamento.ExibirDataGrid();
            dtGrid.ClearSelection();
        }

        // executa o metodo alterar da classe Lancamento, e valida os campos atraves dos metodos da classe ValidarForm.
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma linha para alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lancamento.ValidarCPF(txtCpfLancamento.Text);

                if (!ValidarFormulario.ValidarCPF(txtCpfLancamento.Text))
                {
                    MessageBox.Show("Por favor, preencha o campo CPF", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarFormulario.ValidarBanco(txtBanco.Text))
                {
                    MessageBox.Show("Por favor, preencha o campo Banco", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarFormulario.ValidarHistorico(txtHistorico.Text))
                {
                    MessageBox.Show("Por favor, preencha o campo Histórico", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarFormulario.ValidarValor(txtValor.Text))
                {
                    MessageBox.Show("Informe um valor válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarFormulario.ValidarData(txtDataCompra.Text, txtDataEntrada.Text))
                {
                    return;
                }

                lancamento.id = int.Parse(txtID.Text);
                lancamento.banco = txtBanco.Text;
                lancamento.valor = double.Parse(txtValor.Text);
                lancamento.dataCompra = DateTime.Parse(txtDataCompra.Text);
                lancamento.dataEntrada = DateTime.Parse(txtDataEntrada.Text);
                lancamento.historico = txtHistorico.Text;
                lancamento.cpfLancamento = txtCpfLancamento.Text;

                lancamento.AlterarLancamento();
                dtGrid.DataSource = lancamento.ExibirDataGrid();
            }

        }

        // quando o usuario der 2 cliques em alguma linha do grid, os dados serão preenchido em seus respectivos txtbox
        private void dtGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dtGrid.Rows[e.RowIndex];

                txtID.Text = linha.Cells[0].Value.ToString();
                txtBanco.Text = linha.Cells[1].Value.ToString();
                txtDataCompra.Text = linha.Cells[2].Value.ToString();
                txtDataEntrada.Text = linha.Cells[3].Value.ToString();
                txtValor.Text = linha.Cells[4].Value.ToString();
                txtHistorico.Text = linha.Cells[5].Value.ToString();
                txtCpfLancamento.Text = linha.Cells[6].Value.ToString();
            }
        }

        // executa o metodo excluir da classe Lancamento
        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma linha para excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lancamento.id = int.Parse(txtID.Text);
            lancamento.ExcluirLancamento();
            dtGrid.DataSource = lancamento.ExibirDataGrid();
        }

        // quando o usuario inserir um cpf e apertar ENTER ele executa o metodo ValidarCPF da classe Lancamento
        private void txtCpfLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cpf = txtCpfLancamento.Text;
                string nome = lancamento.ValidarCPF(cpf);
                txtNome.Text = nome;
            }
        }

        // faz a pesquisa atraves do metodo ValidarPesquisa da classe Lancamento
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario.ValidarPesquisa(cbFiltro.Text))
            {
                string filtro = txtFiltro.Text;
                string campo = cbFiltro.SelectedItem.ToString();
                dtGrid.DataSource = lancamento.PesquisarLancamento(campo, filtro);
            }
            else
            {
                MessageBox.Show("Por favor, verifique se o campo filtro foi preenchidos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // limpa todos os campos
        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCpfLancamento.Text = "";
            txtNome.Text = "";
            txtID.Text = "";
            txtBanco.Text = "";
            txtValor.Text = "";
            txtDataEntrada.Text = "";
            txtDataCompra.Text = "";
            txtHistorico.Text = "";
            cbFiltro.Text = "";
            txtFiltro.Text = "";
            dtGrid.DataSource = lancamento.ExibirDataGrid();
        }
    }
}

