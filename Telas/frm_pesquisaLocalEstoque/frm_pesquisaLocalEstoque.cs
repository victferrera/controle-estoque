using Autofac;
using EstoqueApp.Interfaces;
using System.Windows.Forms;
using System.Linq;

namespace EstoqueApp.Telas.frm_pesquisalocalestoque
{
    public partial class frm_pesquisaLocalEstoque : Form
    {
        public frm_pesquisaLocalEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            PreencherGrid(txt_filtro.Text);
            grid_localestoque.Visible = true;
        }

        private void PreencherGrid(string filtro = "")
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                var localEstoqueList = repository.GetLocalByFilter(filtro);

                var customColumnsName = from local in localEstoqueList select new { Id = local.Id, Codigo = local.Codigo, Nome = local.Nome };

                grid_localestoque.DataSource = customColumnsName.ToList();
            }
        }
    }
}
