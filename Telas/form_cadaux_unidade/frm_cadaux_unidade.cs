using System;
using EstoqueApp.Repositories;
using System.Windows.Forms;
using EstoqueApp.form_cad_pesquisa;
using EstoqueApp.Enums;
using System.Collections.Generic;
using EstoqueApp.Modelos;

namespace EstoqueApp.form_cadaux_unidade
{
    public partial class frm_cadaux_unidade : Form
    {
        internal Repository<UnidadeMedida> _repository;

        public frm_cadaux_unidade()
        {
            _repository = new Repository<UnidadeMedida>();

            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_sigla.Text == String.Empty || txt_descabrev.Text == String.Empty || cb_status.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha os campos corretamente!", "Aviso");
                return;
            }

            var unidade = new UnidadeMedida()
            {
                Sigla = txt_sigla.Text,
                DescAbrev = txt_descabrev.Text,
                DescCompleta = txt_desccomp.Text,
                FatorConversao = txt_fatorconv.Text == "" || txt_fatorconv != null ? 0 : int.Parse(txt_fatorconv.Text),  
                Status = cb_status.SelectedItem.ToString()
            };

            MessageBox.Show(_repository.Salvar(unidade));

            limparTxtBox();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limparTxtBox();
        }

        private void limparTxtBox()
        {
            txt_desccomp.Text = String.Empty;
            txt_sigla.Text = String.Empty;
            txt_descabrev.Text = String.Empty;
            txt_fatorconv.Text = String.Empty;

            txt_desccomp.Enabled = true;
            txt_sigla.Enabled = true;
            txt_descabrev.Enabled = true;
            txt_fatorconv.Enabled = true;
            cb_status.Enabled = true;
        }

        private void btn_cadaux_unidade_pesquisar_Click(object sender, EventArgs e)
        {
            var frm_pesquisa = new frm_cad_pesquisa();
            frm_pesquisa.Show();
        }

        internal void abrirFormParaEditarUnidade(DataGridViewCellCollection unidade)
        {
            btn_novo.Visible = false;
            btn_pesquisar.Visible = false;

            txt_sigla.Enabled = true;
            txt_desccomp.Enabled = true;

            txt_sigla.Text = unidade["Sigla"].Value.ToString();
            txt_desccomp.Text = unidade["Descricao"].Value.ToString();
            this.Show();
        }

        private void frm_cadaux_unidade_Load(object sender, EventArgs e)
        {
            //populando o combobox status com as informação do enum StatusItem
            var listaOpcoes = new List<EStatusItem> { EStatusItem.ATIVO, EStatusItem.INATIVO};
            cb_status.DataSource = listaOpcoes;
        }
}
}
