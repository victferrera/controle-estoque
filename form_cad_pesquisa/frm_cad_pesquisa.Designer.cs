namespace EstoqueApp.form_cad_pesquisa
{
    partial class frm_cad_pesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbox_cad_pesquisa_filtros = new System.Windows.Forms.GroupBox();
            this.grid_cad_pesquisa_cadastros = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cad_pesquisa_pesquisar = new System.Windows.Forms.Button();
            this.rbtn_cad_pesquisa_sigla = new System.Windows.Forms.RadioButton();
            this.rbtn_cad_pesquisa_descricao = new System.Windows.Forms.RadioButton();
            this.rbtn_cad_pesquisa_codigo = new System.Windows.Forms.RadioButton();
            this.grbox_cad_pesquisa_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_pesquisa_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox_cad_pesquisa_filtros
            // 
            this.grbox_cad_pesquisa_filtros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.rbtn_cad_pesquisa_codigo);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.rbtn_cad_pesquisa_descricao);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.rbtn_cad_pesquisa_sigla);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.btn_cad_pesquisa_pesquisar);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.textBox1);
            this.grbox_cad_pesquisa_filtros.Location = new System.Drawing.Point(13, 5);
            this.grbox_cad_pesquisa_filtros.Name = "grbox_cad_pesquisa_filtros";
            this.grbox_cad_pesquisa_filtros.Size = new System.Drawing.Size(775, 100);
            this.grbox_cad_pesquisa_filtros.TabIndex = 0;
            this.grbox_cad_pesquisa_filtros.TabStop = false;
            this.grbox_cad_pesquisa_filtros.Text = "Filtros";
            // 
            // grid_cad_pesquisa_cadastros
            // 
            this.grid_cad_pesquisa_cadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_pesquisa_cadastros.Location = new System.Drawing.Point(13, 138);
            this.grid_cad_pesquisa_cadastros.Name = "grid_cad_pesquisa_cadastros";
            this.grid_cad_pesquisa_cadastros.Size = new System.Drawing.Size(775, 300);
            this.grid_cad_pesquisa_cadastros.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_cad_pesquisa_pesquisar
            // 
            this.btn_cad_pesquisa_pesquisar.Location = new System.Drawing.Point(583, 65);
            this.btn_cad_pesquisa_pesquisar.Name = "btn_cad_pesquisa_pesquisar";
            this.btn_cad_pesquisa_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_pesquisa_pesquisar.TabIndex = 1;
            this.btn_cad_pesquisa_pesquisar.Text = "Pesquisar";
            this.btn_cad_pesquisa_pesquisar.UseVisualStyleBackColor = true;
            // 
            // rbtn_cad_pesquisa_sigla
            // 
            this.rbtn_cad_pesquisa_sigla.AutoSize = true;
            this.rbtn_cad_pesquisa_sigla.Location = new System.Drawing.Point(7, 20);
            this.rbtn_cad_pesquisa_sigla.Name = "rbtn_cad_pesquisa_sigla";
            this.rbtn_cad_pesquisa_sigla.Size = new System.Drawing.Size(48, 17);
            this.rbtn_cad_pesquisa_sigla.TabIndex = 2;
            this.rbtn_cad_pesquisa_sigla.TabStop = true;
            this.rbtn_cad_pesquisa_sigla.Text = "Sigla";
            this.rbtn_cad_pesquisa_sigla.UseVisualStyleBackColor = true;
            // 
            // rbtn_cad_pesquisa_descricao
            // 
            this.rbtn_cad_pesquisa_descricao.AutoSize = true;
            this.rbtn_cad_pesquisa_descricao.Location = new System.Drawing.Point(7, 43);
            this.rbtn_cad_pesquisa_descricao.Name = "rbtn_cad_pesquisa_descricao";
            this.rbtn_cad_pesquisa_descricao.Size = new System.Drawing.Size(73, 17);
            this.rbtn_cad_pesquisa_descricao.TabIndex = 3;
            this.rbtn_cad_pesquisa_descricao.TabStop = true;
            this.rbtn_cad_pesquisa_descricao.Text = "Descrição";
            this.rbtn_cad_pesquisa_descricao.UseVisualStyleBackColor = true;
            // 
            // rbtn_cad_pesquisa_codigo
            // 
            this.rbtn_cad_pesquisa_codigo.AutoSize = true;
            this.rbtn_cad_pesquisa_codigo.Location = new System.Drawing.Point(83, 20);
            this.rbtn_cad_pesquisa_codigo.Name = "rbtn_cad_pesquisa_codigo";
            this.rbtn_cad_pesquisa_codigo.Size = new System.Drawing.Size(58, 17);
            this.rbtn_cad_pesquisa_codigo.TabIndex = 4;
            this.rbtn_cad_pesquisa_codigo.TabStop = true;
            this.rbtn_cad_pesquisa_codigo.Text = "Código";
            this.rbtn_cad_pesquisa_codigo.UseVisualStyleBackColor = true;
            // 
            // frm_cad_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_cad_pesquisa_cadastros);
            this.Controls.Add(this.grbox_cad_pesquisa_filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_cad_pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frm_cad_pesquisa_Load);
            this.grbox_cad_pesquisa_filtros.ResumeLayout(false);
            this.grbox_cad_pesquisa_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_pesquisa_cadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox_cad_pesquisa_filtros;
        private System.Windows.Forms.DataGridView grid_cad_pesquisa_cadastros;
        private System.Windows.Forms.RadioButton rbtn_cad_pesquisa_codigo;
        private System.Windows.Forms.RadioButton rbtn_cad_pesquisa_descricao;
        private System.Windows.Forms.RadioButton rbtn_cad_pesquisa_sigla;
        private System.Windows.Forms.Button btn_cad_pesquisa_pesquisar;
        private System.Windows.Forms.TextBox textBox1;
    }
}