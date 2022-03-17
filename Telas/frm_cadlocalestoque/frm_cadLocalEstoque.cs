using System;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;

namespace EstoqueApp.Telas.frm_cadlocalestoque
{
    public partial class frm_cadLocalEstoque : Form
    {
        public frm_cadLocalEstoque()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ILocalEstoqueRepository>();

                var local = repository.ProcurarLocalPorCodigo(int.Parse(num_codigo.Value.ToString()));

                if (local != null)
                {
                    MessageBox.Show("Já existe um local de estoque com esse código!", "Alerta");
                    return;
                }

                var novoLocal = new LocalEstoque
                {
                    Codigo = int.Parse(num_codigo.Value.ToString()),
                    Nome = txt_nome.Text,
                    Descricao = rt_descricao.Text
                };

                try
                {
                    repository.Save(novoLocal);
                    MessageBox.Show("Local de estoque salvo com sucesso!", "Alerta");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    LimparCampos();
                    throw new   (ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            num_codigo.Value = 0;
            txt_nome.Text = String.Empty;
            rt_descricao.Text = String.Empty;
        }
    }
}
