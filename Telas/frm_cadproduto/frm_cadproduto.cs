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
        internal Repository<UnidadeMedida> _repository;
        public frm_cad_produto()
        {
            _repository = new Repository<UnidadeMedida>();
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

            txtbox_cad_produto_codigo.Text = String.Empty;
            txtbox_cad_produto_codigo.Enabled = true;

            cbox_cad_produto_status.Enabled = true;
            cbox_cad_produto_status.DataSource = new List<EStatus>{ EStatus.ATIVO, EStatus.INATIVO };

            cbox_cad_produto_unidade.DataSource = _repository.Pesquisar();
            cbox_cad_produto_unidade.DisplayMember = "Sigla".Trim();
            cbox_cad_produto_unidade.ValueMember = "Id";
            cbox_cad_produto_unidade.Enabled = true;

            txtbox_cad_produto_barras.Text = String.Empty;
            txtbox_cad_produto_barras.Enabled = true;

            txtbox_cad_produto_venda.Text = String.Empty;
            txtbox_cad_produto_venda.Enabled = true;

            txtbox_cad_produto_compra.Text = String.Empty;
            txtbox_cad_produto_compra.Enabled = true;
        }
    }
}
