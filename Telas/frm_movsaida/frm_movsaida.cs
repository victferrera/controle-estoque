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

        public frm_movsaida()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unidadeRepository = Program.Container.Resolve<IUnidadeRepository>();
            var localEstoqueRepository = Program.Container.Resolve<ILocalEstoqueRepository>();
            var produtoSaldoRepository = Program.Container.Resolve<IProdutoSaldoRepository>();

            var novoMovtoSaida = new MovtoSaida
            {
                MovtoNumero = int.Parse(txt_numero.Text),
                DataEmissao = dt_dataEmissao.Value,
                CodigoParticipante = int.Parse(txt_participante.Text)
            };

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var movtoSaidaRepository = scope.Resolve<IMovtoSaidaRepository>();
                try
                {
                    movtoSaidaRepository.Save(novoMovtoSaida);
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
                var retorno = localRepository.ProcurarLocalPorId(int.Parse(txt_localestoque.Text));
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
                    QtdEntrada = double.Parse(txt_qtdProduto.Text)
                }
            );
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            if (dt_items.Visible == false)
                dt_items.Visible = true;

            var produtosPreview = from colunas in items select new { colunas.CodigoProduto, colunas.Nome, colunas.UnidadeMedida, colunas.QtdEntrada };

            dt_items.DataSource = produtosPreview.ToList();
        }
    }
}
