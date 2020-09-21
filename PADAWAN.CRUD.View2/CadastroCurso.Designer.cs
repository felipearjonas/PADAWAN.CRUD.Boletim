namespace PADAWAN.CRUD.View
{
    partial class CadastroCurso
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
            this.lbl_CadastroCurso = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.cb_Situacao = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lbl_NomeExcluir = new System.Windows.Forms.Label();
            this.txt_NomeExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CadastroCurso
            // 
            this.lbl_CadastroCurso.AutoSize = true;
            this.lbl_CadastroCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CadastroCurso.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CadastroCurso.Location = new System.Drawing.Point(180, 32);
            this.lbl_CadastroCurso.Name = "lbl_CadastroCurso";
            this.lbl_CadastroCurso.Size = new System.Drawing.Size(209, 25);
            this.lbl_CadastroCurso.TabIndex = 0;
            this.lbl_CadastroCurso.Text = "Cadastro de Curso";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(73, 134);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Situacao.Location = new System.Drawing.Point(73, 178);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(72, 16);
            this.lbl_Situacao.TabIndex = 3;
            this.lbl_Situacao.Text = "Situação:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(158, 126);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(285, 23);
            this.txt_Nome.TabIndex = 4;
            // 
            // cb_Situacao
            // 
            this.cb_Situacao.FormattingEnabled = true;
            this.cb_Situacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_Situacao.Location = new System.Drawing.Point(158, 171);
            this.cb_Situacao.Name = "cb_Situacao";
            this.cb_Situacao.Size = new System.Drawing.Size(121, 23);
            this.cb_Situacao.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(355, 171);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(296, 377);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 8;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(158, 377);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lbl_NomeExcluir
            // 
            this.lbl_NomeExcluir.AutoSize = true;
            this.lbl_NomeExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeExcluir.Location = new System.Drawing.Point(73, 318);
            this.lbl_NomeExcluir.Name = "lbl_NomeExcluir";
            this.lbl_NomeExcluir.Size = new System.Drawing.Size(52, 16);
            this.lbl_NomeExcluir.TabIndex = 10;
            this.lbl_NomeExcluir.Text = "Nome:";
            // 
            // txt_NomeExcluir
            // 
            this.txt_NomeExcluir.Location = new System.Drawing.Point(158, 311);
            this.txt_NomeExcluir.Name = "txt_NomeExcluir";
            this.txt_NomeExcluir.Size = new System.Drawing.Size(251, 23);
            this.txt_NomeExcluir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Excluir:";
            // 
            // CadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NomeExcluir);
            this.Controls.Add(this.lbl_NomeExcluir);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cb_Situacao);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Situacao);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_CadastroCurso);
            this.Name = "CadastroCurso";
            this.Text = "CadastroCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastroCurso;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Situacao;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cb_Situacao;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lbl_NomeExcluir;
        private System.Windows.Forms.TextBox txt_NomeExcluir;
        private System.Windows.Forms.Label label1;
    }
}