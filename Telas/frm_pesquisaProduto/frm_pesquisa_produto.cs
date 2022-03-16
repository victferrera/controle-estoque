using System;
using System.Windows.Forms;
using EstoqueApp.Repositories;
using EstoqueApp.form_cad_produto;
using System.Linq;
using EstoqueApp.Modelos;
using System.Collections.Generic;
using Autofac;
using EstoqueApp.Interfaces;

namespace EstoqueApp.Telas.frm_pesquisaProduto
{
    public partial class frm_pesquisa_produto : Form
    {
        public frm_pesquisa_produto()
        {
            InitializeComponent();
        }
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            PreencherGrid(txt_filtro.Text);

            grid_produtos.Visible = true;
        }

        private void grid_produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            var produto = grid_produtos.CurrentRow.Cells;

            
            var frmCadProd = (frm_cad_produto)Application.OpenForms["frm_cad_produto"];
            if (frmCadProd == null)
                frmCadProd = new frm_cad_produto();

            frmCadProd.OpenFormToEdit(produto);

        }

        public void PreencherGrid(string filtro = "")
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var produtoRepository = scope.Resolve<IProdutoRepository>();

                var consulta = produtoRepository.GetByFilter(filtro);

                var customColumns = from col in consulta select new { Codigo = col.CodigoProduto, Nome = col.Nome, Descricao = col.Descricao, Status = col.Status, Compra = col.PrecoCompra, Venda = col.PrecoVenda, Unidade = col.unidade.Sigla };

                // IEnumerable<> não funciona como fonte para o DataGrid, necessário converter para List<>;
                grid_produtos.DataSource = customColumns.ToList();

                BringToFront();
            }
        }
    }
}
