namespace PADAWAN.CRUD.View
{
    partial class CadastroNota
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
            this.lbl_CadastroNota = new System.Windows.Forms.Label();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.lbl_Materia = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.cb_Aluno = new System.Windows.Forms.ComboBox();
            this.cb_Materia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_CadastroNota
            // 
            this.lbl_CadastroNota.AutoSize = true;
            this.lbl_CadastroNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CadastroNota.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CadastroNota.Location = new System.Drawing.Point(204, 41);
            this.lbl_CadastroNota.Name = "lbl_CadastroNota";
            this.lbl_CadastroNota.Size = new System.Drawing.Size(184, 25);
            this.lbl_CadastroNota.TabIndex = 0;
            this.lbl_CadastroNota.Text = "Matricular Aluno";
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Aluno.Location = new System.Drawing.Point(98, 147);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(50, 16);
            this.lbl_Aluno.TabIndex = 1;
            this.lbl_Aluno.Text = "Aluno:";
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materia.Location = new System.Drawing.Point(94, 188);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(63, 16);
            this.lbl_Materia.TabIndex = 2;
            this.lbl_Materia.Text = "Matéria:";
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nota.Location = new System.Drawing.Point(97, 227);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(44, 16);
            this.lbl_Nota.TabIndex = 3;
            this.lbl_Nota.Text = "Nota:";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(171, 220);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(100, 23);
            this.txt_Nota.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(171, 285);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(85, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Matricular";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(285, 285);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(94, 23);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "Alterar/Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(401, 285);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(83, 23);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // cb_Aluno
            // 
            this.cb_Aluno.FormattingEnabled = true;
            this.cb_Aluno.Location = new System.Drawing.Point(171, 140);
            this.cb_Aluno.Name = "cb_Aluno";
            this.cb_Aluno.Size = new System.Drawing.Size(260, 23);
            this.cb_Aluno.TabIndex = 10;
            this.cb_Aluno.SelectedIndexChanged += new System.EventHandler(this.cb_Aluno_SelectedIndexChanged);
            // 
            // cb_Materia
            // 
            this.cb_Materia.FormattingEnabled = true;
            this.cb_Materia.Location = new System.Drawing.Point(171, 181);
            this.cb_Materia.Name = "cb_Materia";
            this.cb_Materia.Size = new System.Drawing.Size(260, 23);
            this.cb_Materia.TabIndex = 10;
            // 
            // CadastroNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 384);
            this.Controls.Add(this.cb_Materia);
            this.Controls.Add(this.cb_Aluno);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.lbl_Materia);
            this.Controls.Add(this.lbl_Aluno);
            this.Controls.Add(this.lbl_CadastroNota);
            this.Name = "CadastroNota";
            this.Text = "CadastroNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastroNota;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.Label lbl_Materia;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.ComboBox cb_Aluno;
        private System.Windows.Forms.ComboBox cb_Materia;
    }
}