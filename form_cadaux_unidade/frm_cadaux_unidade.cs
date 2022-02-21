using System;
using EstoqueApp.Repository;
using System.Windows.Forms;
using EstoqueApp.form_cad_pesquisa;

namespace EstoqueApp.form_cadaux_unidade
{
    public partial class frm_cadaux_unidade : Form
    {
        internal UnidadeRepository _repository;
        public frm_cadaux_unidade()
        {
            _repository = new UnidadeRepository();

            InitializeComponent();
        }

        private void btn_cadaux_unidade_salvar_Click(object sender, EventArgs e)
        {
            if (txtbox_cadaux_unidade_desc.Text == String.Empty || txtbox_cadaux_unidade_nome.Text == String.Empty)
            {
                MessageBox.Show("Por favor, preencha os campos corretamente!", "Aviso");
                return;
            }

            MessageBox.Show(_repository.Salvar(txtbox_cadaux_unidade_nome.Text.ToString(), txtbox_cadaux_unidade_desc.Text.ToString()));

            limparTxtBox();
        }

        private void btn_cadaux_unidade_incluir_Click(object sender, EventArgs e)
        {
            limparTxtBox();
        }

        private void limparTxtBox()
        {
            txtbox_cadaux_unidade_desc.Text = String.Empty;
            txtbox_cadaux_unidade_nome.Text = String.Empty;
            txtbox_cadaux_unidade_desc.Enabled = true;
            txtbox_cadaux_unidade_nome.Enabled = true;
        }

        private void btn_cadaux_unidade_pesquisar_Click(object sender, EventArgs e)
        {
            var frm_pesquisa = new frm_cad_pesquisa();
            frm_pesquisa.Show();
        }

        internal void abrirFormParaEditarUnidade(DataGridViewCellCollection unidade)
        {
            btn_cadaux_unidade_incluir.Visible = false;
            btn_cadaux_unidade_pesquisar.Visible = false;

            lbl_cadaux_unidade_pesquisar.Visible = false;
            lbl_cadaux_unidade_incluir.Visible = false;

            btn_cadaux_unidade_salvar.Location = btn_cadaux_unidade_incluir.Location;
            lbl_cadaux_unidade_salvar.Location = lbl_cadaux_unidade_incluir.Location;

            txtbox_cadaux_unidade_nome.Enabled = true;
            txtbox_cadaux_unidade_desc.Enabled = true;

            txtbox_cadaux_unidade_nome.Text = unidade["Sigla"].Value.ToString();
            txtbox_cadaux_unidade_desc.Text = unidade["Descricao"].Value.ToString();
            this.Show();
        }
    }
}
