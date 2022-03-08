using System;
using System.Windows.Forms;
using EstoqueApp.Enums;
using EstoqueApp.Repositories;
using EstoqueApp.Modelos;
using System.Collections.Generic;
using EstoqueApp.Telas.frm_pesquisaProduto;

namespace EstoqueApp.form_cad_produto
{
    public partial class frm_cad_produto : Form
    {
        internal UnidadeRepository _unidadeRepository;
        internal ProdutoRepository _produtoRepository;
        internal Produto produto = null;
        public frm_cad_produto()
        {
            _produtoRepository = new ProdutoRepository();
            _unidadeRepository = new UnidadeRepository();
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            InicializacaoLimpezaCampos();
        }

        public void InicializacaoLimpezaCampos()
        {
            btn_remover.Enabled = true;

            txtbox_cad_produto_nome.Text = String.Empty;
            txtbox_cad_produto_nome.Enabled = true;

            txtbox_cad_produto_descricao.Text = String.Empty;
            txtbox_cad_produto_descricao.Enabled = true;


            cbox_cad_produto_status.Enabled = true;
            cbox_cad_produto_status.DataSource = new List<EStatus> { EStatus.ATIVO, EStatus.INATIVO };

            cbox_cad_produto_unidade.DataSource = _unidadeRepository.GetByStatus(1);
            cbox_cad_produto_unidade.DisplayMember = "Sigla";
            cbox_cad_produto_unidade.ValueMember = "CodigoUnidade";
            cbox_cad_produto_unidade.Enabled = true;


            txtbox_cad_produto_venda.Text = String.Empty;
            txtbox_cad_produto_venda.Enabled = true;

            txtbox_cad_produto_compra.Text = String.Empty;
            txtbox_cad_produto_compra.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            produto = new Produto()
            {
                Nome = txtbox_cad_produto_nome.Text,
                Descricao = txtbox_cad_produto_descricao.Text,
                unidade = new Unidade() { CodigoUnidade = int.Parse(cbox_cad_produto_unidade.SelectedValue.ToString()) } ,
                Status = (EStatus)cbox_cad_produto_status.SelectedItem,
                PrecoCompra = double.Parse(txtbox_cad_produto_compra.Text),
                PrecoVenda = double.Parse(txtbox_cad_produto_venda.Text)
            };

            _produtoRepository.Save(produto);
            MessageBox.Show("Produto salvo com sucesso!", "Alerta!");
            InicializacaoLimpezaCampos();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            var frmPesquisa = new frm_pesquisa_produto();
            frmPesquisa.Show();
        }

        public void OpenFormToEdit(DataGridViewCellCollection produtoGrid)
        {
            InicializacaoLimpezaCampos();

            btn_novo.Enabled = false;
            btn_pesquisar.Enabled = false;

            produto = new Produto()
            {
                CodigoProduto = int.Parse(produtoGrid["CodigoProduto"].Value.ToString()),
                Nome = produtoGrid["Nome"].Value.ToString(),
                Descricao = produtoGrid["Descricao"].Value.ToString(),
                Status = (EStatus)produtoGrid["Status"].Value,
                unidade = (Unidade)produtoGrid["unidade"].Value,
                PrecoCompra = double.Parse(produtoGrid["PrecoCompra"].Value.ToString()),
                PrecoVenda = double.Parse(produtoGrid["PrecoVenda"].Value.ToString())
            };


            var frmCadProduto = (frm_cad_produto)Application.OpenForms["frm_cad_produto"];

            frmCadProduto.txtbox_cad_produto_nome.Text = produto.Nome;
            frmCadProduto.txtbox_cad_produto_descricao.Text = produto.Descricao;
            frmCadProduto.txtbox_cad_produto_venda.Text = produto.PrecoVenda.ToString();
            frmCadProduto.txtbox_cad_produto_compra.Text = produto.PrecoCompra.ToString();
            frmCadProduto.cbox_cad_produto_status.Text = produto.Status.ToString();
            frmCadProduto.cbox_cad_produto_unidade.Text = produto.unidade.Sigla;

            frmCadProduto.BringToFront();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            _produtoRepository.Remove(produto);
            AtualizarGrid();
            MessageBox.Show("Produto removido com sucesso!", "Alerta!");
            InicializacaoLimpezaCampos();
        }

        public void AtualizarGrid()
        {
            var consulta = _produtoRepository.GetByFilter("");
            var frmPesquisa = (frm_pesquisa_produto)Application.OpenForms["frm_pesquisa_produto"];
            frmPesquisa.grid_produtos.DataSource = consulta;
            frmPesquisa.BringToFront();
        }
    }
}
