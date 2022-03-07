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

                LimparCampos();
            }
            else
            {
                unidadeMedida.Sigla = txt_sigla.Text.ToUpper();
                unidadeMedida.Descricao = txt_descricao.Text;
                _repository.Update(unidadeMedida);
                MessageBox.Show("Unidade alterada com sucesso!","Alerta!");
                AtualizarGridView();
                var frmPesUnidade = (frm_cad_pesquisa)Application.OpenForms["frm_cad_pesquisa"];
                frmPesUnidade.BringToFront();
            }
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
        private void AtualizarGridView()
        {
            var frmPesquisa = (frm_cad_pesquisa)Application.OpenForms["frm_cad_pesquisa"];
            frmPesquisa.grid_cad_pesquisa_cadastros.DataSource = _repository.GetByFilter("");
        }

        private void frm_cadaux_unidade_Load(object sender, EventArgs e)
        {
            cb_status.DataSource = new List<EStatus>() { EStatus.ATIVO, EStatus.INATIVO };
        }

        public void OpenFormToEdit(DataGridViewCellCollection unidade)
        {
            unidadeMedida = new Unidade()
            {
                CodigoUnidade = int.Parse(unidade["CodigoUnidade"].Value.ToString()),
                Sigla = unidade["Sigla"].Value.ToString(),
                Descricao = unidade["Descricao"].Value.ToString(),
                Status = (EStatus)unidade["Status"].Value
            };

            txt_sigla.Enabled = true;
            txt_descricao.Enabled = true;
            cb_status.Enabled = false;
            btn_novo.Enabled = false;
            btn_pesquisar.Enabled = false;
            btn_remover.Enabled = true;
            btn_alteraStatus.Enabled = true;

            txt_sigla.Text = unidadeMedida.Sigla;
            txt_descricao.Text = unidadeMedida.Descricao;
            cb_status.Text = unidade["Status"].Value.ToString();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            _repository.Remove(unidadeMedida);
            MessageBox.Show("Unidade Removida!", "Alerta!");
            AtualizarGridView();
            var frmPesUnidade = (frm_cad_pesquisa)Application.OpenForms["frm_cad_pesquisa"];
            frmPesUnidade.BringToFront();
        }
    }
}
