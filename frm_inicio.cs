using System.Windows.Forms;
using EstoqueApp.form_cad_produto;
using EstoqueApp.form_cadaux_unidade;
using EstoqueApp.Telas.frm_cadlocalEstoque;
using EstoqueApp.Telas;
using EstoqueApp.Telas.frm_movsaida;

namespace EstoqueApp
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel.LinkLabel_Actions.OpenLinkOnBrowser();
            }catch
            {
                MessageBox.Show("Não foi possível abrir o Link!");
            }
        }

        private void menu_produto_cadastro_Click(object sender, System.EventArgs e)
        {
            var novaTela = new frm_cad_produto();
            novaTela.Show();
        }

        private void menu_cadaux_unidade_Click(object sender, System.EventArgs e)
        {
            var novaTela = new frm_cadaux_unidade();
            novaTela.Show();
        }

        private void localToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var novaTela = new frm_cadLocalEstoque();
            novaTela.Show();
        }
        private void novoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var novaTela = new frm_cadastros();
            novaTela.Show();
        }

        private void tiposDeCadastroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var formTipoCadastro = new frm_cadtipocadastro();
            formTipoCadastro.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var formMovimentacaoEntrada = new frm_moventrada();
            formMovimentacaoEntrada.Show();
        }

        private void relat_movtoEntrada_Click(object sender, System.EventArgs e)
        {
            
        }

        private void saídaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frm_movsaida frm = new frm_movsaida();
            frm.Show();
        }
    }
}
