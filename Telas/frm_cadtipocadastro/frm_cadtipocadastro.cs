using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using System;
using System.Windows.Forms;

namespace EstoqueApp.Telas
{
    public partial class frm_cadtipocadastro : Form
    {
        internal TipoCadastro tipoCadastro = null;
        public frm_cadtipocadastro()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            if(txt_sigla.Text == String.Empty)
            {
                MessageBox.Show("O Campo Sigla não pode ser vazio.","Alerta!");
                return;
            }

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ITipoCadastroRepository>();

                var novoTipo = new TipoCadastro
                {
                    Sigla = txt_sigla.Text,
                    Descricao = rt_descricao.Text
                };

                try
                {
                    repository.Save(novoTipo);
                    MessageBox.Show("Tipo de cadastro salvo com sucesso!","Alerta!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            txt_sigla.Text = string.Empty;
            rt_descricao.Text = string.Empty;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            var novaTela = new frm_pesquisaCad();
            novaTela.Show();
        }

        internal void OpenFormToEdit(DataGridViewCellCollection dados)
        {
            tipoCadastro = new TipoCadastro
            {
                Id = int.Parse(dados[0].Value.ToString()),
                Sigla = dados[1].Value.ToString(),
                Descricao = dados[2].Value.ToString()
            };

            txt_sigla.Text = tipoCadastro.Sigla;
            rt_descricao.Text = tipoCadastro.Descricao;

            btn_salvar.Visible = false;

            btn_editar.Visible = true;

            btn_remover.Visible = true;
            btn_remover.Location = btn_salvar.Location;

            this.BringToFront();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.Container.BeginLifetimeScope())
                {
                    var repository = scope.Resolve<ITipoCadastroRepository>();

                    repository.Remove(tipoCadastro);

                    MessageBox.Show("Registro deletado com sucesso!","Alerta!");
                    
                    var formPesquisa = (frm_pesquisaCad)Application.OpenForms["frm_pesquisaCad"];
                    if (formPesquisa == null)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                        formPesquisa.AtualizaGrid();
                        formPesquisa.BringToFront();

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao remover registro" + ex.Message);
                return;
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.Container.BeginLifetimeScope())
                {
                    var repository = scope.Resolve<ITipoCadastroRepository>();

                    tipoCadastro.Sigla = txt_sigla.Text;
                    tipoCadastro.Descricao = rt_descricao.Text;

                    repository.Update(tipoCadastro);
                }
                MessageBox.Show("Registro editado com sucesso!","Alerta!");
                var formPesquisa = (frm_pesquisaCad)Application.OpenForms["frm_pesquisaCad"];

                if(formPesquisa == null)
                {
                    this.Close();
                }else
                {
                    formPesquisa.AtualizaGrid();
                    formPesquisa.BringToFront();
                    this.Close();
                }
                  
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao editar o registro!" + ex.Message, "Alerta!");
                return;
            }
            
        }
    }
}
