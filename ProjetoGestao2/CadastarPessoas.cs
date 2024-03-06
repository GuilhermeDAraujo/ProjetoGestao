using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestao2
{
    public partial class fmCadastrarPessoas : Form
    {
        Pessoa pessoa = new Pessoa();
        public fmCadastrarPessoas()
        {
            InitializeComponent();
        }

        // executa o metodo gravar da classe pessoa
        private void btGravarPessoa_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario.ValidarCPF(txtCpfCadastro.Text) && ValidarFormulario.ValidarNome(txtNomeCadastro.Text))
            {
                pessoa.cpfCadastro = txtCpfCadastro.Text;
                pessoa.nomeCadastro = txtNomeCadastro.Text;

                pessoa.GravarPessoa();
            }
            else
            {
                MessageBox.Show("Por favor, verifique se todos os campos foram preenchidos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
