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
            if (produto is null)
            {
                produto = new Produto()
                {
                    Nome = txtbox_cad_produto_nome.Text,
                    Descricao = txtbox_cad_produto_descricao.Text,
                    unidade = new Unidade() { CodigoUnidade = int.Parse(cbox_cad_produto_unidade.SelectedValue.ToString()) },
                    Status = (EStatus)cbox_cad_produto_status.SelectedItem,
                    PrecoCompra = double.Parse(txtbox_cad_produto_compra.Text),
                    PrecoVenda = double.Parse(txtbox_cad_produto_venda.Text)
                };

                _produtoRepository.Save(produto);
                MessageBox.Show("Produto salvo com sucesso!", "Alerta!");

                var frmPesquisa = (frm_pesquisa_produto)Application.OpenForms["frm_pesquisa_produto"];
                if (frmPesquisa == null)
                {
                    frmPesquisa = new frm_pesquisa_produto(); 
                    frmPesquisa.PreencherGrid();
                }
                else
                {
                    frmPesquisa.PreencherGrid();
                }

                this.Close();
                InicializacaoLimpezaCampos();

            }
            else
            {
                produto.Nome = txtbox_cad_produto_nome.Text;
                produto.Descricao = txtbox_cad_produto_descricao.Text;
                produto.unidade = new Unidade() { CodigoUnidade = int.Parse(cbox_cad_produto_unidade.SelectedValue.ToString()) };
                produto.Status = (EStatus)cbox_cad_produto_status.SelectedItem;
                produto.PrecoCompra = double.Parse(txtbox_cad_produto_compra.Text);
                produto.PrecoVenda = double.Parse(txtbox_cad_produto_venda.Text);

                _produtoRepository.Update(produto);
                MessageBox.Show("Produto alterado com sucesso!", "Alerta!");

                var frmPesquisa = (frm_pesquisa_produto)Application.OpenForms["frm_pesquisa_produto"];
                if (frmPesquisa == null)
                {
                    frmPesquisa = new frm_pesquisa_produto();
                    frmPesquisa.PreencherGrid();
                }
                else
                {
                    frmPesquisa.PreencherGrid();
                }

                this.Close();
                InicializacaoLimpezaCampos();
            }
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
                CodigoProduto = int.Parse(produtoGrid["Codigo"].Value.ToString()),
                Nome = produtoGrid["Nome"].Value.ToString(),
                Descricao = produtoGrid["Descricao"].Value.ToString(),
                Status = (EStatus)produtoGrid["Status"].Value,
                unidade = new Unidade() { Sigla = produtoGrid["Unidade"].Value.ToString() },
                PrecoCompra = double.Parse(produtoGrid["Compra"].Value.ToString()),
                PrecoVenda = double.Parse(produtoGrid["Venda"].Value.ToString())
            };


            var frmCadProduto = (frm_cad_produto)Application.OpenForms["frm_cad_produto"];

            if (frmCadProduto == null)
            {
                frmCadProduto = new frm_cad_produto();
                frmCadProduto.produto = produto;
                frmCadProduto.InicializacaoLimpezaCampos();
                frmCadProduto.txtbox_cad_produto_nome.Text = produto.Nome;
                frmCadProduto.txtbox_cad_produto_descricao.Text = produto.Descricao;
                frmCadProduto.txtbox_cad_produto_venda.Text = produto.PrecoVenda.ToString();
                frmCadProduto.txtbox_cad_produto_compra.Text = produto.PrecoCompra.ToString();
                frmCadProduto.cbox_cad_produto_status.Text = produto.Status.ToString();
                frmCadProduto.cbox_cad_produto_unidade.Text = produto.unidade.Sigla;

                frmCadProduto.btn_novo.Enabled = false;
                frmCadProduto.btn_pesquisar.Enabled = false;

                frmCadProduto.Show();
            }
            else
            {
                frmCadProduto.txtbox_cad_produto_nome.Text = produto.Nome;
                frmCadProduto.txtbox_cad_produto_descricao.Text = produto.Descricao;
                frmCadProduto.txtbox_cad_produto_venda.Text = produto.PrecoVenda.ToString();
                frmCadProduto.txtbox_cad_produto_compra.Text = produto.PrecoCompra.ToString();
                frmCadProduto.cbox_cad_produto_status.Text = produto.Status.ToString();
                frmCadProduto.cbox_cad_produto_unidade.Text = produto.unidade.Sigla;
                frmCadProduto.BringToFront();
            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            var frmPesquisa = (frm_pesquisa_produto)Application.OpenForms["frm_pesquisa_produto"];
            _produtoRepository.Remove(produto);
            frmPesquisa.PreencherGrid();
            MessageBox.Show("Produto removido com sucesso!", "Alerta!");
            this.Close();
        }
    }
}
