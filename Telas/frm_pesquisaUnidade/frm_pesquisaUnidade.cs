using System;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.form_cadaux_unidade;
using EstoqueApp.Interfaces;
using EstoqueApp.Repositories;

namespace EstoqueApp.form_cad_pesquisa
{
    public partial class frm_cad_pesquisa : Form
    {
        public frm_cad_pesquisa()
        {
            InitializeComponent();
        }

        private void btn_cad_pesquisa_pesquisar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<IUnidadeRepository>();
                grid_cad_pesquisa_cadastros.DataSource = repository.GetByFilter(txt_cad_pesquisa_filtro.Text);
            }
        }

        private void grid_cad_pesquisa_cadastros_KeyPress(object sender, KeyPressEventArgs e)
        {
            var unidade = grid_cad_pesquisa_cadastros.CurrentRow.Cells;
            var frm = (frm_cadaux_unidade)Application.OpenForms["frm_cadaux_unidade"];
            frm.OpenFormToEdit(unidade);
            frm.BringToFront();
        }

        protected override void OnClosed(EventArgs e)
        {
            var frmCadUnidade = (frm_cadaux_unidade)Application.OpenForms["frm_cadaux_unidade"];

            if(frmCadUnidade != null)
            {
                frmCadUnidade.Close();
                var newFrmCadUnidade = new frm_cadaux_unidade();
                newFrmCadUnidade.Show();
            }
        }
    }
}
