namespace ProjetoGestao2
{
    public partial class fmGestao : Form
    {

        public fmGestao()
        {
            InitializeComponent();
        }

        private void cadastrarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCadastrarPessoas cadastrarPessoas = new fmCadastrarPessoas();
            cadastrarPessoas.ShowDialog();
        }

        private void cadastrarLancamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCadastrarLancamentos cadastrarLancamento = new fmCadastrarLancamentos();
            cadastrarLancamento.ShowDialog();
        }
    }
}
