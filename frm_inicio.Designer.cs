namespace EstoqueApp
{
    partial class frm_inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.frm_menu = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produto_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_link = new System.Windows.Forms.LinkLabel();
            this.lbl_criador1 = new System.Windows.Forms.Label();
            this.frm_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_menu
            // 
            this.frm_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
            this.frm_menu.Location = new System.Drawing.Point(0, 0);
            this.frm_menu.Name = "frm_menu";
            this.frm_menu.Size = new System.Drawing.Size(558, 24);
            this.frm_menu.TabIndex = 0;
            this.frm_menu.Text = "frm_menu";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_produto_cadastro});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtosToolStripMenuItem.Text = "Produto";
            // 
            // menu_produto_cadastro
            // 
            this.menu_produto_cadastro.Name = "menu_produto_cadastro";
            this.menu_produto_cadastro.Size = new System.Drawing.Size(180, 22);
            this.menu_produto_cadastro.Text = "Cadastro";
            this.menu_produto_cadastro.Click += new System.EventHandler(this.menu_produto_cadastro_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saídaToolStripMenuItem.Text = "Saída";
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(73, 310);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(66, 13);
            this.lbl_link.TabIndex = 1;
            this.lbl_link.TabStop = true;
            this.lbl_link.Text = "Vitor Ferreira";
            this.lbl_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link_LinkClicked);
            // 
            // lbl_criador1
            // 
            this.lbl_criador1.AutoSize = true;
            this.lbl_criador1.Location = new System.Drawing.Point(12, 310);
            this.lbl_criador1.Name = "lbl_criador1";
            this.lbl_criador1.Size = new System.Drawing.Size(55, 13);
            this.lbl_criador1.TabIndex = 2;
            this.lbl_criador1.Text = "Criado por";
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 332);
            this.Controls.Add(this.lbl_criador1);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.frm_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.frm_menu;
            this.MaximizeBox = false;
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.frm_menu.ResumeLayout(false);
            this.frm_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frm_menu;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_produto_cadastro;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lbl_link;
        private System.Windows.Forms.Label lbl_criador1;
    }
}

