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
        internal UnidadeRepository _repository;
        internal Unidade unidadeMedida = null;

        public frm_cadaux_unidade()
        {
            _repository = new UnidadeRepository();

            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_sigla.Text == String.Empty || cb_status.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha os campos corretamente!", "Aviso");
                return;
            }

            if(unidadeMedida == null)
            {
                var unidade = new Unidade()
                {
                    Sigla = txt_sigla.Text,
                    Descricao = txt_descricao.Text,
                    Status = (EStatus)cb_status.SelectedItem
                };

                _repository.Save(unidade);

                MessageBox.Show("Unidade salva com sucesso!","Alerta!");

                unidade = null;
            }
            LimparCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        private void LimparCampos()
        {
            txt_descricao.Text = String.Empty;
            txt_sigla.Text = String.Empty;
            txt_descricao.Text = String.Empty;
        }

        private void HabilitarCampos()
        {
            txt_descricao.Enabled = true;
            txt_sigla.Enabled = true;
            txt_descricao.Enabled = true;
            cb_status.Enabled = true;
        }

        private void btn_cadaux_unidade_pesquisar_Click(object sender, EventArgs e)
        {
            var frm_pesquisa = new frm_cad_pesquisa();
            frm_pesquisa.Show();
        }
        private frm_cad_pesquisa AtualizarDadosGridPesquisaUnidade()
        {
            var formAntigo = (frm_cad_pesquisa)Application.OpenForms["frm_cad_pesquisa"];
            return formAntigo;
        }

        private void frm_cadaux_unidade_Load(object sender, EventArgs e)
        {
            cb_status.DataSource = new List<EStatus>() { EStatus.ATIVO, EStatus.INATIVO };
        }
    }
}
