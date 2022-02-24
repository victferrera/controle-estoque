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
        internal UnidadeRepository _uRepository;

        public frm_cadaux_unidade()
        {
            _repository = new Repository<UnidadeMedida>();
            _uRepository = new UnidadeRepository();

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
            //populando os textbox e variáveis auxiliares
            aux_id = unidade["Id"].Value.ToString();
            txt_sigla.Text = unidade["Sigla"].Value.ToString();
            txt_descabrev.Text = unidade["DescAbrev"].Value.ToString();
            txt_desccomp.Text = unidade["DescCompleta"].Value.ToString();
            txt_fatorconv.Text = unidade["FatorConversao"].Value.ToString();
            aux_status = unidade["Status"].Value.ToString();


            //alterando o layout dos btn e dos txtbox
            btn_novo.Visible = false;
            btn_pesquisar.Visible = false;
            btn_salvar.Location = btn_novo.Location;
            txt_sigla.Enabled = true;
            txt_descabrev.Enabled = true;
            txt_desccomp.Enabled = true;
            txt_fatorconv.Enabled = true;
            btn_alteraStatus.Enabled = true;
            btn_remover.Enabled = true;

            if (aux_status == EStatusItem.INATIVO.ToString())
                btn_alteraStatus.Text = "Ativar";
            else
                btn_alteraStatus.Text = "Inativar";

            this.Show();
        }

        private void frm_cadaux_unidade_Load(object sender, EventArgs e)
        {
            if (aux_status == EStatusItem.ATIVO.ToString())
            {
                cb_status.DataSource = new List<EStatusItem>() { EStatusItem.ATIVO, EStatusItem.INATIVO };
            }
            else if (aux_status == EStatusItem.INATIVO.ToString())
            {
                cb_status.DataSource = new List<EStatusItem>() { EStatusItem.INATIVO, EStatusItem.ATIVO };
            }
            else
            {
                cb_status.DataSource = new List<EStatusItem>() { EStatusItem.ATIVO, EStatusItem.INATIVO };
            }
        }

        private void btn_alteraStatus_Click(object sender, EventArgs e)
        {
            var unidade = new UnidadeMedida()
            {
                Id = int.Parse(aux_id),
                Sigla = txt_sigla.Text,
                DescAbrev = txt_descabrev.Text,
                DescCompleta = txt_desccomp.Text,
                FatorConversao = int.Parse(txt_fatorconv.Text),
                Status =  aux_status
            };

            _uRepository.AlterarStatus(unidade);

            MessageBox.Show($"Status da unidade {txt_sigla.Text} alterado com sucesso!");

            this.Close();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            _repository.Remover(int.Parse(aux_id));

            MessageBox.Show($"Unidade {txt_sigla.Text} removida!");

            this.Close();
        }
    }
}
