using System;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using EstoqueApp.Telas.frm_pesquisalocalestoque;

namespace EstoqueApp.Telas.frm_cadlocalEstoque
{
    public partial class frm_cadLocalEstoque : Form
    {
        private LocalEstoque LocalParaEditar;
        public frm_cadLocalEstoque()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                LocalEstoque local = repository.ProcurarLocalPorCodigo(int.Parse(num_codigo.Value.ToString()));

                if (local != null)
                {
                    MessageBox.Show("Já existe um local de estoque com esse código!", "Alerta");
                    return;
                }

                var novoLocal = new LocalEstoque
                {
                    Codigo = int.Parse(num_codigo.Value.ToString()),
                    Nome = txt_nome.Text,
                    Descricao = rt_descricao.Text
                };

                try
                {
                    repository.Save(novoLocal);
                    MessageBox.Show("Local de estoque salvo com sucesso!", "Alerta");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    LimparCampos();
                    throw new(ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            num_codigo.Value = 0;
            txt_nome.Text = String.Empty;
            rt_descricao.Text = String.Empty;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            var formPesquisa = (frm_pesquisaLocalEstoque)Application.OpenForms["frm_pesquisaLocalEstoque"];

            if (formPesquisa == null)
                formPesquisa = new frm_pesquisaLocalEstoque();

            formPesquisa.Show();
        }

        internal void OpenFormToEdit(int codigo)
        {
            LimparCampos();

            btn_cadastrar.Visible = false;
            btn_remover.Visible = true;

            btn_editar.Visible = true;
            btn_editar.Location = btn_cadastrar.Location;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                LocalParaEditar = repository.ProcurarLocalPorCodigo(codigo);
            }

            num_codigo.Value = LocalParaEditar.Codigo;
            txt_nome.Text = LocalParaEditar.Nome;
            rt_descricao.Text = LocalParaEditar.Descricao;

            this.BringToFront();
        }

        private void frm_cadLocalEstoque_Load(object sender, EventArgs e)
        {
            btn_remover.Visible = false;
            btn_editar.Visible = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            LocalParaEditar.Codigo = int.Parse(num_codigo.Value.ToString());
            LocalParaEditar.Nome = txt_nome.Text;
            LocalParaEditar.Descricao = rt_descricao.Text;


            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                repository.EditaLocal(LocalParaEditar);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                repository.DeletaLocal(LocalParaEditar.Id);
            }
        }
    }
}
