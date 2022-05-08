using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using EstoqueApp.Modelos.DTO;

namespace EstoqueApp.Telas.frm_movsaida
{
    public partial class frm_movsaida : Form
    {
        List<ProdutoDTO> items = new List<ProdutoDTO>();
        List<MovtoSaidaItem> movtoSaidaItems = new List<MovtoSaidaItem>();
        List<ProdutoSaldo> listaProdutoSaldoAnterior = new List<ProdutoSaldo>();

        public frm_movsaida()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unidadeRepository = Program.Container.Resolve<IUnidadeRepository>();
            var produtoSaldoRepository = Program.Container.Resolve<IProdutoSaldoRepository>();

            var novoMovtoSaida = new MovtoSaida
            {
                MovtoNumero = int.Parse(txt_numero.Text),
                DataEmissao = dt_dataEmissao.Value,
                CodigoParticipante = int.Parse(txt_participante.Text)
            };

            foreach (var produto in items)
            {
                movtoSaidaItems.Add(new MovtoSaidaItem
                    {
                        CodigoProduto = produto.CodigoProduto,
                        LocalEstoque = int.Parse(txt_localestoque.Text),
                        QtdItem = produto.Qtd,
                        CodigoUnidade = unidadeRepository.GetCodigoUnidadePorSigla(txt_unidadeProduto.Text),
                        MovtoNumero = int.Parse(txt_numero.Text)
                    }
                );
            }

            foreach (var produto in movtoSaidaItems)
            {
                var saldoAux = produtoSaldoRepository.BuscarSaldoAnterior(produto.CodigoProduto, produto.LocalEstoque);

                listaProdutoSaldoAnterior.Add(new ProdutoSaldo
                    {
                        SaldoAnterior = saldoAux,
                        SaldoAtual = (saldoAux - decimal.Parse(produto.QtdItem.ToString())),
                        CodigoProduto = produto.CodigoProduto,
                        DataAtualizacao = DateTime.Now,
                        LocalEstoque = produto.LocalEstoque
                    }
                );
            }


            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var movtoSaidaRepository = scope.Resolve<IMovtoSaidaRepository>();
                var movtoSaidaItemRepository = scope.Resolve<IMovtoSaidaItemRepository>();
                try
                {
                    movtoSaidaRepository.Save(novoMovtoSaida);
                    foreach(var movtoItem in movtoSaidaItems)
                    {
                        movtoSaidaItemRepository.Save(movtoItem);
                    }
                    foreach(var pdSaldo in listaProdutoSaldoAnterior)
                    {
                        produtoSaldoRepository.Save(pdSaldo);
                    }
                    MessageBox.Show("Documento salvo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_procuraCliente_Click(object sender, EventArgs e)
        {
            var cadastroRepository = Program.Container.Resolve<ICadastroRepository>();
            try
            {
                var retorno = cadastroRepository.GetCadastro(int.Parse(txt_participante.Text.ToString()));
                txt_razaoSocial.Text = retorno.RazaoSocial.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_procuraLocal_Click(object sender, EventArgs e)
        {
            var localRepository = Program.Container.Resolve<ILocalEstoqueRepository>();

            try
            {
                var retorno = localRepository.ProcurarLocalPorCodigo(int.Parse(txt_localestoque.Text));
                txt_descriacaoLocal.Text = retorno.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_movsaida_Load(object sender, EventArgs e)
        {
            var movtoSaidaRepository = Program.Container.Resolve<IMovtoSaidaRepository>();
            txt_numero.Text = (movtoSaidaRepository.GetLastId() + 1).ToString();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            items.Add(new ProdutoDTO
            {
                CodigoProduto = int.Parse(txt_codigoProduto.Text),
                Nome = txt_nomeProduto.Text,
                UnidadeMedida = txt_unidadeProduto.Text,
                Qtd = int.Parse(txt_qtdProduto.Text)
            }
            );
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            if (dt_items.Visible == false)
                dt_items.Visible = true;

            var produtosPreview = from colunas in items select new { colunas.CodigoProduto, colunas.Nome, colunas.UnidadeMedida, colunas.Qtd };

            dt_items.DataSource = produtosPreview.ToList();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            items.RemoveAll(x => x.CodigoProduto == int.Parse(txt_codigoProduto.Text));
            AtualizarGrid();
        }

        private void dt_items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoProduto.Text = dt_items.CurrentRow.Cells["CodigoProduto"].Value.ToString();
            txt_nomeProduto.Text = dt_items.CurrentRow.Cells["Nome"].Value.ToString();
            txt_qtdProduto.Text = dt_items.CurrentRow.Cells["QtdEntrada"].Value.ToString();
            txt_unidadeProduto.Text = dt_items.CurrentRow.Cells["UnidadeMedida"].Value.ToString();
        }

        private void btn_procurarProduto_Click(object sender, EventArgs e)
        {
            var produtoRepository = Program.Container.Resolve<IProdutoRepository>();

            var produto = produtoRepository.ProcurarPorCodigoComUn(int.Parse(txt_codigoProduto.Text));

            txt_nomeProduto.Text = produto.Nome;
            txt_unidadeProduto.Text = produto.Unidade.Sigla;
        }
    }
}
