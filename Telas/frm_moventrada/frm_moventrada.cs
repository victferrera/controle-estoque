using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using EstoqueApp.Modelos.DTO;

namespace EstoqueApp.Telas
{
    public partial class frm_moventrada : Form
    {
        private List<ProdutoDTO> listaProduto = new List<ProdutoDTO>();
        private List<ProdutoSaldo> listaProdutoSaldoAnterior = new List<ProdutoSaldo>();

        public frm_moventrada()
        {
            InitializeComponent();
            PopularInformacoesBasicas();
        }

        private void salvarToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var unidadeRepository = Program.Container.Resolve<IUnidadeRepository>();
            var localEstoqueRepository = Program.Container.Resolve<ILocalEstoqueRepository>();
            var produtoSaldoRepository = Program.Container.Resolve<IProdutoSaldoRepository>();

            var novoMovtoEntrada = new MovtoEntrada
            {
                MovtoNumero = int.Parse(nm_movtoNumero.Value.ToString()),
                DataEmissao = dt_emissao.Value,
                CodigoParticipante = int.Parse(txt_codigoParticipante.Text)
            };

            var novoMovtoEntradaItem = new MovtoEntradaItem
            {
                CodigoProduto = null,
                LocalEstoque = localEstoqueRepository.ProcurarLocalPorCodigo(int.Parse(txt_LocalEstoque.Text)).Id,
                QtdEntrada = int.Parse(txt_qtdEntrada.Text),
                CodigoUnidade = unidadeRepository.GetCodigoUnidadePorSigla(txt_unidadeProduto.Text),
                MovtoNumero = int.Parse(nm_movtoNumero.Value.ToString())
            };

            listaProdutoSaldoAnterior = new List<ProdutoSaldo>();
            novoMovtoEntradaItem.CodigoProduto = new List<int>();

            foreach (var produtoId in listaProduto)
            {
                novoMovtoEntradaItem.CodigoProduto.Add(produtoId.CodigoProduto);

                var saldoAux = produtoSaldoRepository.BuscarSaldoAnterior(produtoId.CodigoProduto, novoMovtoEntradaItem.LocalEstoque);

                listaProdutoSaldoAnterior.Add(new ProdutoSaldo
                    {
                        SaldoAnterior = saldoAux,
                        SaldoAtual = saldoAux + decimal.Parse(txt_qtdEntrada.Text),
                        CodigoProduto = produtoId.CodigoProduto,
                        DataAtualizacao = DateTime.Now,
                        LocalEstoque = novoMovtoEntradaItem.LocalEstoque
                    }
                );

            }

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var movtoEntradaRepository = scope.Resolve<IMovtoEntradaRepository>();
                var movtoEntradaItemRepository = scope.Resolve<IMovtoEntradaItemRepository>();
                var pdSaldoRepository = scope.Resolve<IProdutoSaldoRepository>();

                try
                {
                    movtoEntradaRepository.Save(novoMovtoEntrada);
                    movtoEntradaItemRepository.Save(novoMovtoEntradaItem);
                    foreach (var saldo in listaProdutoSaldoAnterior)
                    {
                        pdSaldoRepository.Save(saldo);
                    }
                    MessageBox.Show("Documento salvo!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PopularInformacoesBasicas()
        {
            IMovtoEntradaRepository movtoEntradaRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                movtoEntradaRepository = scope.Resolve<IMovtoEntradaRepository>();
                nm_movtoNumero.Value = 1 + movtoEntradaRepository.GetLastId();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ICadastroRepository cadastroRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {

                cadastroRepository = scope.Resolve<ICadastroRepository>();
                var retornoCadastro = cadastroRepository.GetCadastro(int.Parse(txt_codigoParticipante.Text.ToString()));

                txt_codigoParticipante.Text = retornoCadastro.Codigo.ToString();
                txt_nomeParticipante.Text = retornoCadastro.RazaoSocial.ToString();
            }
        }

        private void btn_procurarLocal_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var localRepository = scope.Resolve<ILocalEstoqueRepository>();

                var localRetorno = localRepository.ProcurarLocalPorCodigo(int.Parse(txt_LocalEstoque.Text));

                txt_LocalEstoque.Text = localRetorno.Codigo.ToString();
                txt_localDescricao.Text = localRetorno.Descricao;
            }
        }

        private void btn_procurarProduto_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var produtoRepository = scope.Resolve<IProdutoRepository>();

                var produto = produtoRepository.ProcurarPorCodigoComUn(int.Parse(txt_codigoProduto.Text));

                if (produto == null)
                {
                    LimparCamposAbaItem();
                    MessageBox.Show("Produto não encontrado");
                    return;
                }

                txt_codigoProduto.Text = produto.CodigoProduto.ToString();
                txt_nomeProduto.Text = produto.Nome;
                txt_unidadeProduto.Text = produto.Unidade.Sigla.ToString();
            }
        }

        private void LimparCamposAbaItem()
        {
            txt_codigoProduto.Text = String.Empty;
            txt_nomeProduto.Text = String.Empty;
            txt_unidadeProduto.Text = String.Empty;
            txt_unidadeProduto.Text = String.Empty;
        }

        private void btn_adicionarItem_Click(object sender, EventArgs e)
        {
            listaProduto.Add(new ProdutoDTO
            {
                CodigoProduto = int.Parse(txt_codigoProduto.Text),
                Nome = txt_nomeProduto.Text,
                UnidadeMedida = txt_unidadeProduto.Text,
                QtdEntrada = double.Parse(txt_qtdEntrada.Text)
            });

            AtualizarGridProduto();
        }

        private void AtualizarGridProduto()
        {
            if (dt_itemMovto.Visible == false)
                dt_itemMovto.Visible = true;

            var colunasProduto = from colunas in listaProduto select new { colunas.CodigoProduto, colunas.Nome, colunas.UnidadeMedida, colunas.QtdEntrada };
            dt_itemMovto.DataSource = colunasProduto.ToList();
        }

        private void dt_itemMovto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoProduto.Text = dt_itemMovto.CurrentRow.Cells["CodigoProduto"].Value.ToString();
            txt_nomeProduto.Text = dt_itemMovto.CurrentRow.Cells["Nome"].Value.ToString();
            txt_unidadeProduto.Text = dt_itemMovto.CurrentRow.Cells["UnidadeMedida"].Value.ToString();
            txt_qtdEntrada.Text = dt_itemMovto.CurrentRow.Cells["QtdEntrada"].Value.ToString();
        }

        private void btn_removerProduto_Click(object sender, EventArgs e)
        {
            listaProduto.RemoveAll(x => x.CodigoProduto == int.Parse(txt_codigoProduto.Text));
            LimparCamposAbaItem();
            AtualizarGridProduto();
        }
    }
}
