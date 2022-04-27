using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;

namespace EstoqueApp.Telas
{
    public partial class frm_moventrada : Form
    {
        public frm_moventrada()
        {
            InitializeComponent();
            PopularInformacoesBasicas();
        }

        private void salvarToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(dt_emissao.Value.ToString());
        }

        private void PopularInformacoesBasicas()
        {
            IMovtoEntradaRepository movtoEntradaRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                movtoEntradaRepository = scope.Resolve<IMovtoEntradaRepository>();
                nm_movtoNumero.Value = movtoEntradaRepository.GetLastId();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ICadastroRepository cadastroRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                
                cadastroRepository = scope.Resolve<ICadastroRepository>();
                var retornoCadastro = cadastroRepository.GetCadastro(int.Parse(txt_codigoParticipante.Text.ToString()));

                txt_codigoParticipante.Text = retornoCadastro.Codigo.ToString();
                txt_nomeParticipante.Text = retornoCadastro.RazaoSocial.ToString();
            }
        }
    }
}
