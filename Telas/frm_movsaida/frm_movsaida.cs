using System;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;

namespace EstoqueApp.Telas.frm_movsaida
{
    public partial class frm_movsaida : Form
    {
        public frm_movsaida()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unidadeRepository = Program.Container.Resolve<IUnidadeRepository>();
            var localEstoqueRepository = Program.Container.Resolve<ILocalEstoqueRepository>();
            var produtoSaldoRepository = Program.Container.Resolve<IProdutoSaldoRepository>();

            var novoMovtoSaida = new MovtoSaida
            {
                MovtoNumero = int.Parse(txt_numero.Text),
                DataEmissao = dt_dataEmissao.Value,
                CodigoParticipante = int.Parse(txt_participante.Text)
            };

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var movtoSaidaRepository = scope.Resolve<IMovtoSaidaRepository>();
                try
                {
                    movtoSaidaRepository.Save(novoMovtoSaida);
                    MessageBox.Show("Documento salvo");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_procuraCliente_Click(object sender, EventArgs e)
        {
            var cadastroRepository = Program.Container.Resolve<ICadastroRepository>();
            try
            {
                var retorno = cadastroRepository.GetCadastro(int.Parse(txt_participante.Text.ToString()));
                txt_razaoSocial.Text = retorno.RazaoSocial.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_procuraLocal_Click(object sender, EventArgs e)
        {
            var localRepository = Program.Container.Resolve<ILocalEstoqueRepository>();

            try
            {
                var retorno = localRepository.ProcurarLocalPorId(int.Parse(txt_localestoque.Text));
                txt_descriacaoLocal.Text = retorno.Descricao;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_movsaida_Load(object sender, EventArgs e)
        {
            var movtoSaidaRepository = Program.Container.Resolve<IMovtoSaidaRepository>();
            txt_numero.Text = (movtoSaidaRepository.GetLastId() +1 ).ToString();
        }
    }
}
