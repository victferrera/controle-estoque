using System;
using System.Windows.Forms;
using EstoqueApp.Enums;
using EstoqueApp.Repositories;
using EstoqueApp.Modelos;
using System.Collections.Generic;

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
            txtbox_cad_produto_nome.Text = String.Empty;
            txtbox_cad_produto_nome.Enabled = true;

            txtbox_cad_produto_descricao.Text = String.Empty;
            txtbox_cad_produto_descricao.Enabled = true;


            cbox_cad_produto_status.Enabled = true;
            cbox_cad_produto_status.DataSource = new List<EStatus>{ EStatus.ATIVO, EStatus.INATIVO };

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
                CodigoUnidade = int.Parse(cbox_cad_produto_unidade.SelectedValue.ToString()),
                Status = (EStatus)cbox_cad_produto_status.SelectedItem,
                PrecoCompra = double.Parse(txtbox_cad_produto_compra.Text),
                PrecoVenda = double.Parse(txtbox_cad_produto_venda.Text)
            };

            _produtoRepository.Save(produto);
            MessageBox.Show("Produto salvo com sucesso!","Alerta!");
            InicializacaoLimpezaCampos();
        }
    }
}
