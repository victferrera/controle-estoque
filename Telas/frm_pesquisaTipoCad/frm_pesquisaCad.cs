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
    }
}
