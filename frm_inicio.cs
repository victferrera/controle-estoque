﻿using System.Windows.Forms;
using EstoqueApp.form_cad_produto;

namespace EstoqueApp
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel.LinkLabel_Actions.OpenLinkOnBrowser();
            }catch
            {
                MessageBox.Show("Não foi possível abrir o Link!");
            }
        }

        private void menu_produto_cadastro_Click(object sender, System.EventArgs e)
        {
            var novaTela = new frm_cad_produto();
            novaTela.Show();
        }
    }
}
