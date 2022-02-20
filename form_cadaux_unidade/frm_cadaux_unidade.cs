﻿using System;
using EstoqueApp.Banco;
using System.Windows.Forms;
using Dapper;
using EstoqueApp.form_cad_pesquisa;

namespace EstoqueApp.form_cadaux_unidade
{
    public partial class frm_cadaux_unidade : Form
    {
        public frm_cadaux_unidade()
        {
            InitializeComponent();
        }

        private void btn_cadaux_unidade_salvar_Click(object sender, EventArgs e)
        {
            if (txtbox_cadaux_unidade_desc.Text == String.Empty || txtbox_cadaux_unidade_nome.Text == String.Empty)
            {
                MessageBox.Show("Por favor, preencha os campos corretamente!");
                return;
            }

            using (var conexao = new Conexao().GetConexao())
            {
                var insertSql = @"
                INSERT INTO [tbUnidade] VALUES(
                @nome,
                @descricao
                )";

                var linhasAfetadas = conexao.Execute(insertSql, new
                {
                    nome = txtbox_cadaux_unidade_nome.Text.ToUpper(),
                    descricao = txtbox_cadaux_unidade_desc.Text
                });

                // 1 = linhas retornadas do insert
                if (linhasAfetadas == 1)
                    MessageBox.Show("Unidade cadastrada com sucesso!");
                else
                    MessageBox.Show("Ocorreu um erro ao cadastrar a unidade, contate o Administrador do Sistema!");
            }

            limparTxtBox();
        }

        private void btn_cadaux_unidade_incluir_Click(object sender, EventArgs e)
        {
            limparTxtBox();
        }

        private void limparTxtBox()
        {
            txtbox_cadaux_unidade_desc.Text = String.Empty;
            txtbox_cadaux_unidade_nome.Text = String.Empty;
            txtbox_cadaux_unidade_desc.Enabled = true;
            txtbox_cadaux_unidade_nome.Enabled = true;
        }

        private void btn_cadaux_unidade_pesquisar_Click(object sender, EventArgs e)
        {
            var frm_pesquisa = new frm_cad_pesquisa();
            frm_pesquisa.Show();
        }
    }
}
