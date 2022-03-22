using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using System;
using System.Windows.Forms;

namespace EstoqueApp.Telas
{
    public partial class frm_cadtipocadastro : Form
    {
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
    }
}
