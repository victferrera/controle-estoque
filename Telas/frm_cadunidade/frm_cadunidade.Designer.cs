namespace EstoqueApp.form_cadaux_unidade
{
    partial class frm_cadaux_unidade
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
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.lbl_cadaux_unidade_sigla = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.grbox_cadaux_unidade_cadastro = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alteraStatus = new System.Windows.Forms.Button();
            this.grbox_cadaux_unidade_cadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sigla
            // 
            this.txt_sigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sigla.Enabled = false;
            this.txt_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sigla.Location = new System.Drawing.Point(6, 57);
            this.txt_sigla.MaxLength = 2;
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(90, 22);
            this.txt_sigla.TabIndex = 17;
            // 
            // lbl_cadaux_unidade_sigla
            // 
            this.lbl_cadaux_unidade_sigla.AutoSize = true;
            this.lbl_cadaux_unidade_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadaux_unidade_sigla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cadaux_unidade_sigla.Location = new System.Drawing.Point(2, 30);
            this.lbl_cadaux_unidade_sigla.Name = "lbl_cadaux_unidade_sigla";
            this.lbl_cadaux_unidade_sigla.Size = new System.Drawing.Size(51, 24);
            this.lbl_cadaux_unidade_sigla.TabIndex = 16;
            this.lbl_cadaux_unidade_sigla.Text = "Sigla";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(183, 19);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(83, 25);
            this.btn_pesquisar.TabIndex = 22;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_cadaux_unidade_pesquisar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(95, 19);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(82, 25);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(9, 19);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(80, 25);
            this.btn_novo.TabIndex = 20;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // grbox_cadaux_unidade_cadastro
            // 
            this.grbox_cadaux_unidade_cadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.cb_status);
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.label4);
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.txt_descricao);
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.lbl_descricao);
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.lbl_cadaux_unidade_sigla);
            this.grbox_cadaux_unidade_cadastro.Controls.Add(this.txt_sigla);
            this.grbox_cadaux_unidade_cadastro.Location = new System.Drawing.Point(12, 57);
            this.grbox_cadaux_unidade_cadastro.Name = "grbox_cadaux_unidade_cadastro";
            this.grbox_cadaux_unidade_cadastro.Size = new System.Drawing.Size(733, 247);
            this.grbox_cadaux_unidade_cadastro.TabIndex = 26;
            this.grbox_cadaux_unidade_cadastro.TabStop = false;
            this.grbox_cadaux_unidade_cadastro.Text = "Dados da Unidade";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(6, 163);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Enabled = false;
            this.txt_descricao.Location = new System.Drawing.Point(6, 112);
            this.txt_descricao.MaxLength = 60;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(150, 20);
            this.txt_descricao.TabIndex = 21;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_descricao.Location = new System.Drawing.Point(2, 85);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(94, 24);
            this.lbl_descricao.TabIndex = 20;
            this.lbl_descricao.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cadastro de Unidade de Medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_remover);
            this.groupBox1.Controls.Add(this.btn_alteraStatus);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 53);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.SystemColors.Control;
            this.btn_remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover.Enabled = false;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(554, 19);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(83, 25);
            this.btn_remover.TabIndex = 24;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_alteraStatus
            // 
            this.btn_alteraStatus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_alteraStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alteraStatus.Enabled = false;
            this.btn_alteraStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alteraStatus.Location = new System.Drawing.Point(643, 19);
            this.btn_alteraStatus.Name = "btn_alteraStatus";
            this.btn_alteraStatus.Size = new System.Drawing.Size(83, 25);
            this.btn_alteraStatus.TabIndex = 23;
            this.btn_alteraStatus.Text = "Inativar";
            this.btn_alteraStatus.UseVisualStyleBackColor = false;
            // 
            // frm_cadaux_unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbox_cadaux_unidade_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cadaux_unidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade";
            this.Load += new System.EventHandler(this.frm_cadaux_unidade_Load);
            this.grbox_cadaux_unidade_cadastro.ResumeLayout(false);
            this.grbox_cadaux_unidade_cadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.Label lbl_cadaux_unidade_sigla;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.GroupBox grbox_cadaux_unidade_cadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alteraStatus;
    }
}