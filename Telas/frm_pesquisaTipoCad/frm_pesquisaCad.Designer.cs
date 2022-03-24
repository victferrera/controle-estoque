namespace EstoqueApp.Telas
{
    partial class frm_pesquisaCad
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
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.dt_tiposcadastro = new System.Windows.Forms.DataGridView();
            this.gb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tiposcadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(6, 43);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(297, 23);
            this.txt_filtro.TabIndex = 0;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(309, 42);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 1;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.lbl_filtro);
            this.gb_filtro.Controls.Add(this.txt_filtro);
            this.gb_filtro.Controls.Add(this.btn_pesquisar);
            this.gb_filtro.Location = new System.Drawing.Point(12, 12);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(390, 81);
            this.gb_filtro.TabIndex = 2;
            this.gb_filtro.TabStop = false;
            this.gb_filtro.Text = "Filtro";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(7, 25);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(177, 15);
            this.lbl_filtro.TabIndex = 2;
            this.lbl_filtro.Text = "Pesquise pela Sigla ou Descrição";
            // 
            // dt_tiposcadastro
            // 
            this.dt_tiposcadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_tiposcadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_tiposcadastro.Location = new System.Drawing.Point(12, 99);
            this.dt_tiposcadastro.Name = "dt_tiposcadastro";
            this.dt_tiposcadastro.RowTemplate.Height = 25;
            this.dt_tiposcadastro.Size = new System.Drawing.Size(390, 124);
            this.dt_tiposcadastro.TabIndex = 3;
            this.dt_tiposcadastro.Visible = false;
            // 
            // frm_pesquisaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 235);
            this.Controls.Add(this.dt_tiposcadastro);
            this.Controls.Add(this.gb_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_pesquisaCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tiposcadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.DataGridView dt_tiposcadastro;
    }
}