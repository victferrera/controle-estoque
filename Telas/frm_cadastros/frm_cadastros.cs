using Autofac;
using EstoqueApp.Interfaces;
using System.Windows.Forms;
using Dapper;
using EstoqueApp.Modelos;
using System.Linq;
using System;
using System.Collections.Generic;
using EstoqueApp.Enums;
using Newtonsoft.Json;
using System.Threading.Tasks;
using RestSharp;

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
            var listaTipoCadastro = new List<TipoCadastro>();

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ITipoCadastroRepository>();
                listaTipoCadastro = repository.GeraListaTipoCadastro();
            }
            return listaTipoCadastro;
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

        private async Task<RestResponse> PesquisarCep()
        {

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<ICepService>();

                var cepInfo = await repository.GetCepInformation(txt_cep.Text);

                return cepInfo;

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }

        private async void txt_cep_Leave(object sender, EventArgs e)
        {
            var cep = await PesquisarCep();

            if (cep.IsSuccessful)
            {
                var cepDeserialized = JsonConvert.DeserializeObject<Cep>(cep.Content);
                txt_logradouro.Text = cepDeserialized.logradouro;
                txt_numero.Text = String.Empty;
                txt_bairro.Text = cepDeserialized.bairro;
                txt_uf.Text = cepDeserialized.uf;
                txt_cidade.Text = cepDeserialized.localidade;
                rt_complemento.Text = cepDeserialized.complemento;
            }
        }
    }
}
