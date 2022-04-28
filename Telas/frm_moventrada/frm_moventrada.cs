﻿using System;
using System.Windows.Forms;
using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;

namespace EstoqueApp.Telas
{
    public partial class frm_moventrada : Form
    {
        public frm_moventrada()
        {
            InitializeComponent();
            PopularInformacoesBasicas();
        }

        private void salvarToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var novoMovtoEntrada = new MovtoEntrada
            {
                MovtoNumero = int.Parse(nm_movtoNumero.Value.ToString()),
                DataEmissao = dt_emissao.Value,
                CodigoParticipante = int.Parse(txt_codigoParticipante.Text)  
            };

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var movtoEntradaRepository = scope.Resolve<IMovtoEntradaRepository>();

                try
                {
                    movtoEntradaRepository.Save(novoMovtoEntrada);
                    MessageBox.Show("Documento salvo!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PopularInformacoesBasicas()
        {
            IMovtoEntradaRepository movtoEntradaRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                movtoEntradaRepository = scope.Resolve<IMovtoEntradaRepository>();
                nm_movtoNumero.Value = 1 + movtoEntradaRepository.GetLastId();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ICadastroRepository cadastroRepository = null;

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                
                cadastroRepository = scope.Resolve<ICadastroRepository>();
                var retornoCadastro = cadastroRepository.GetCadastro(int.Parse(txt_codigoParticipante.Text.ToString()));

                txt_codigoParticipante.Text = retornoCadastro.Codigo.ToString();
                txt_nomeParticipante.Text = retornoCadastro.RazaoSocial.ToString();
            }
        }

        private void btn_procurarLocal_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var localRepository = scope.Resolve<ILocalEstoqueRepository>();

                var localRetorno = localRepository.ProcurarLocalPorCodigo(int.Parse(txt_LocalEstoque.Text));

                txt_LocalEstoque.Text = localRetorno.Codigo.ToString();
                txt_localDescricao.Text = localRetorno.Descricao;
            }
        }
    }
}
