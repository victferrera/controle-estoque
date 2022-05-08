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
        private List<ProdutoDTO> listaProdutoPreview = new List<ProdutoDTO>();
        private List<ProdutoSaldo> listaProdutoSaldoAnterior = null;
        private List<MovtoEntradaItem> movtoItems = null;

        public frm_moventrada()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var unidadeRepository = Program.Container.Resolve<IUnidadeRepository>();
            var produtoSaldoRepository = Program.Container.Resolve<IProdutoSaldoRepository>();

            var novoMovtoEntrada = new MovtoEntrada
            {
                MovtoNumero = int.Parse(nm_movtoNumero.Value.ToString()),
                DataEmissao = dt_emissao.Value,
                CodigoParticipante = int.Parse(txt_codigoParticipante.Text)
            };

            //adiciona o produto na lista de produtos a ser salva com algumas informações de listaProdutoPreview
            movtoItems = new List<MovtoEntradaItem>();

            foreach(var produto in listaProdutoPreview)
            {
                movtoItems.Add(new MovtoEntradaItem
                    {
                        CodigoProduto = produto.CodigoProduto,
                        LocalEstoque = int.Parse(txt_LocalEstoque.Text),
                        QtdItem = produto.Qtd,
                        CodigoUnidade = unidadeRepository.GetCodigoUnidadePorSigla(txt_unidadeProduto.Text),
                        MovtoNumero = int.Parse(nm_movtoNumero.Value.ToString())
                    }
                );
            }

            listaProdutoSaldoAnterior = new List<ProdutoSaldo>();

            //percorre os itens que foram adicionados na aba item
            //busca as informações de saldo para atualizar o saldo do produto
            foreach (var produto in movtoItems)
            {
                var saldoAux = produtoSaldoRepository.BuscarSaldoAnterior(produto.CodigoProduto, produto.LocalEstoque);

                listaProdutoSaldoAnterior.Add(new ProdutoSaldo
                    {
                        SaldoAnterior = saldoAux,
                        SaldoAtual = saldoAux + decimal.Parse(produto.QtdItem.ToString()),
                        CodigoProduto = produto.CodigoProduto,
                        DataAtualizacao = DateTime.Now,
                        LocalEstoque = produto.LocalEstoque
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
                    foreach (var movto in movtoItems)
                        movtoEntradaItemRepository.Save(movto);
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
            listaProdutoPreview.Add(new ProdutoDTO
            {
                CodigoProduto = int.Parse(txt_codigoProduto.Text),
                Nome = txt_nomeProduto.Text,
                UnidadeMedida = txt_unidadeProduto.Text,
                Qtd = decimal.Parse(txt_qtdEntrada.Text)
            });

            AtualizarGridProduto();
        }

        private void AtualizarGridProduto()
        {
            if (dt_itemMovto.Visible == false)
                dt_itemMovto.Visible = true;

            var colunasProduto = from colunas in listaProdutoPreview select new { colunas.CodigoProduto, colunas.Nome, colunas.UnidadeMedida, colunas.Qtd };
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
            listaProdutoPreview.RemoveAll(x => x.CodigoProduto == int.Parse(txt_codigoProduto.Text));
            LimparCamposAbaItem();
            AtualizarGridProduto();
        }

        private void frm_moventrada_Load(object sender, EventArgs e)
        {
            PopularInformacoesBasicas();
        }
    }
}
