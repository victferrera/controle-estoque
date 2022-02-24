using System;
using System.Windows.Forms;
using EstoqueApp.form_cadaux_unidade;
using EstoqueApp.Repositories;
using EstoqueApp.Modelos;

namespace EstoqueApp.form_cad_pesquisa
{
    public partial class frm_cad_pesquisa : Form
    {
        internal Repository<UnidadeMedida> _repository;
        public frm_cad_pesquisa()
        {
            _repository = new Repository<UnidadeMedida>();

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
