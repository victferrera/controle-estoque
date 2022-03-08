using System;
using System.Windows.Forms;
using EstoqueApp.Repositories;
using EstoqueApp.form_cad_produto;

namespace EstoqueApp.Telas.frm_pesquisaProduto
{
    public partial class frm_pesquisa_produto : Form
    {
        internal ProdutoRepository _produtoRepository;
        public frm_pesquisa_produto()
        {
            _produtoRepository = new ProdutoRepository();
            InitializeComponent();
        }

        private void frm_pesquisa_produto_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            grid_produtos.Visible = true;
            grid_produtos.DataSource = _produtoRepository.GetByFilter(txt_filtro.Text);
        }

        private void grid_produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            var produto = grid_produtos.CurrentRow.Cells;

            var frmCadProd = (frm_cad_produto)Application.OpenForms["frm_cad_produto"];

            frmCadProd.OpenFormToEdit(produto);

        }

        public void AtualizarGrid()
        {
            var consulta = _produtoRepository.GetByFilter("");
            grid_produtos.DataSource = consulta;
            BringToFront();
        }
    }
}
