using Autofac;
using EstoqueApp.Interfaces;
using System.Windows.Forms;
using Dapper;
using EstoqueApp.Modelos;
using System.Linq;
using System;
using System.Collections.Generic;
using EstoqueApp.Enums;

namespace EstoqueApp.Telas
{
    public partial class frm_cadastros : Form
    {
        public frm_cadastros()
        {
            InitializeComponent();
        }

        private void frm_cadastros_Load(object sender, System.EventArgs e)
        {
            cb_tipoCadastro.DataSource = GeraListaParaPreencherTiposCadastro();
            cb_tipoCadastro.DisplayMember = "Sigla";
            cb_tipoCadastro.ValueMember = "Id";

            cb_statusCadastro.DataSource = GeraListaParaPreencherStatus();
            cb_statusCadastro.DisplayMember = "Nome";
            cb_statusCadastro.ValueMember = "Id";


        }

        private List<TipoCadastro> GeraListaParaPreencherTiposCadastro()
        {
            var listTipoCadastro = new List<TipoCadastro>();

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                try
                {
                    var connection = scope.Resolve<IConnectionService>().CreateConnection();

                    var query = "SELECT Id, Sigla FROM TipoCadastro";

                    listTipoCadastro = connection.Query<TipoCadastro>(query).ToList();

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return listTipoCadastro;
                }
            }
            return listTipoCadastro;
        }

        private List<Status> GeraListaParaPreencherStatus()
        {
            var lista = new List<Status>();

            var ativo = new Status
            {
                Id = (int)EStatus.ATIVO,
                Nome = EStatus.ATIVO.ToString()
            };

            var inativo = new Status
            {
                Id = (int)EStatus.INATIVO,
                Nome = EStatus.INATIVO.ToString()
            };

            lista.Add(ativo);
            lista.Add(inativo);

            return lista;
        }
    }
}
