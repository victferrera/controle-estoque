using System;
using System.Windows.Forms;
using EstoqueApp.form_cadaux_unidade;
using EstoqueApp.Repository;

namespace EstoqueApp.form_cad_pesquisa
{
    public partial class frm_cad_pesquisa : Form
    {
        internal UnidadeRepository _repository;
        public frm_cad_pesquisa()
        {
            _repository = new UnidadeRepository();

            InitializeComponent();
        }

        private void btn_cad_pesquisa_pesquisar_Click(object sender, EventArgs e)
        {
            var retornoPesquisa = _repository.Pesquisar(txt_cad_pesquisa_filtro.Text.ToString());

            grid_cad_pesquisa_cadastros.DataSource = retornoPesquisa;
        }

        private void grid_cad_pesquisa_cadastros_KeyPress(object sender, KeyPressEventArgs e)
        {
            var unidade = grid_cad_pesquisa_cadastros.CurrentRow.Cells;
            var frm = new frm_cadaux_unidade();
            frm.abrirFormParaEditarUnidade(unidade);
        }
    }
}
