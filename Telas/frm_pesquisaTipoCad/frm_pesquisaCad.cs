using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstoqueApp.Telas
{
    public partial class frm_pesquisaCad : Form
    {
        public frm_pesquisaCad()
        {
            InitializeComponent();
        }
        private void btn_pesquisar_Click(object sender, System.EventArgs e)
        {
            var filtro = txt_filtro.Text;
            var listaTipoCadastro = new List<TipoCadastro>();

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ITipoCadastroRepository>();

                listaTipoCadastro = repository.ProcurarPorFiltro(filtro);
            }
            dt_tiposcadastro.DataSource = listaTipoCadastro;

            dt_tiposcadastro.Visible = true;
        }

        private void dt_tiposcadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            var formCadTipoCadastro = (frm_cadtipocadastro)Application.OpenForms["frm_cadtipocadastro"];

            formCadTipoCadastro.tipoCadastro = new TipoCadastro
            {
                Id = int.Parse(dt_tiposcadastro.SelectedCells[0].Value.ToString()),
                Sigla = dt_tiposcadastro.SelectedCells[1].Value.ToString(),
                Descricao = dt_tiposcadastro.SelectedCells[2].Value.ToString()
            };

            formCadTipoCadastro.OpenFormToEdit();
        }

        internal void AtualizaGrid()
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ITipoCadastroRepository>();

                var tiposCadastro = repository.ProcurarPorFiltro("");

                dt_tiposcadastro.DataSource = tiposCadastro;
            }
        }

    }
}
