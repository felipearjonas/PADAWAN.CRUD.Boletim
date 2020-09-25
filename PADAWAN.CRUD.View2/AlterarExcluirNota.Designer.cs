namespace PADAWAN.CRUD.View
{
    partial class AlterarExcluirNota
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
            this.cb_Materia = new System.Windows.Forms.ComboBox();
            this.cb_Aluno = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.lbl_Materia = new System.Windows.Forms.Label();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.lbl_AlterarExlcuir = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_Materia
            // 
            this.cb_Materia.FormattingEnabled = true;
            this.cb_Materia.Location = new System.Drawing.Point(197, 170);
            this.cb_Materia.Name = "cb_Materia";
            this.cb_Materia.Size = new System.Drawing.Size(260, 23);
            this.cb_Materia.TabIndex = 10;
            // 
            // cb_Aluno
            // 
            this.cb_Aluno.FormattingEnabled = true;
            this.cb_Aluno.Location = new System.Drawing.Point(197, 129);
            this.cb_Aluno.Name = "cb_Aluno";
            this.cb_Aluno.Size = new System.Drawing.Size(260, 23);
            this.cb_Aluno.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(311, 274);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(197, 274);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 7;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nota.Location = new System.Drawing.Point(123, 216);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(44, 16);
            this.lbl_Nota.TabIndex = 3;
            this.lbl_Nota.Text = "Nota:";
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materia.Location = new System.Drawing.Point(120, 177);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(63, 16);
            this.lbl_Materia.TabIndex = 2;
            this.lbl_Materia.Text = "Matéria:";
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Aluno.Location = new System.Drawing.Point(124, 136);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(50, 16);
            this.lbl_Aluno.TabIndex = 1;
            this.lbl_Aluno.Text = "Aluno:";
            // 
            // lbl_AlterarExlcuir
            // 
            this.lbl_AlterarExlcuir.AutoSize = true;
            this.lbl_AlterarExlcuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AlterarExlcuir.ForeColor = System.Drawing.Color.Blue;
            this.lbl_AlterarExlcuir.Location = new System.Drawing.Point(197, 39);
            this.lbl_AlterarExlcuir.Name = "lbl_AlterarExlcuir";
            this.lbl_AlterarExlcuir.Size = new System.Drawing.Size(229, 25);
            this.lbl_AlterarExlcuir.TabIndex = 0;
            this.lbl_AlterarExlcuir.Text = "Alterar/Excluir Notas";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(197, 208);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(100, 23);
            this.txt_Nota.TabIndex = 11;
            // 
            // AlterarExcluirNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 390);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_AlterarExlcuir);
            this.Controls.Add(this.lbl_Aluno);
            this.Controls.Add(this.lbl_Materia);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Aluno);
            this.Controls.Add(this.cb_Materia);
            this.Name = "AlterarExcluirNota";
            this.Text = "AlterarExcluirNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Materia;
        private System.Windows.Forms.ComboBox cb_Aluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.Label lbl_Materia;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.Label lbl_AlterarExlcuir;
        private System.Windows.Forms.TextBox txt_Nota;
    }
}