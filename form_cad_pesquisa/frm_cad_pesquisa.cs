using System;
using System.Windows.Forms;
using EstoqueApp.Banco;
using Dapper;
using EstoqueApp.Modelos;
using EstoqueApp.form_cadaux_unidade;

namespace EstoqueApp.form_cad_pesquisa
{
    public partial class frm_cad_pesquisa : Form
    {
        public frm_cad_pesquisa()
        {
            InitializeComponent();
        }

        private void btn_cad_pesquisa_pesquisar_Click(object sender, EventArgs e)
        {        
            var prm = new { filtro = "%"+txt_cad_pesquisa_filtro.Text+"%"};

            var consultaSql = @"
            SELECT * FROM [tbUnidade]
            WHERE Sigla LIKE @filtro OR Descricao LIKE @filtro OR Id LIKE @filtro
            ";

            using (var conexao = new Conexao().GetConexao())
            {
                var retornoConsulta = conexao.Query<Unidade>(consultaSql, prm);
                grid_cad_pesquisa_cadastros.DataSource = retornoConsulta;
            }
        }

        private void grid_cad_pesquisa_cadastros_KeyPress(object sender, KeyPressEventArgs e)
        {
            var unidade = grid_cad_pesquisa_cadastros.CurrentRow.Cells;

            var frm = new frm_cadaux_unidade();
            frm.abrirFormParaEditarUnidade(unidade);
        }
    }
}
