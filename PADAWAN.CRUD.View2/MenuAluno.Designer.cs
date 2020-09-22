namespace PADAWAN.CRUD.View
{
    partial class MenuAluno
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_Notas = new System.Windows.Forms.Label();
            this.btn_Notas = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Visualizacao = new System.Windows.Forms.Label();
            this.cb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(52, 147);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(50, 16);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Aluno:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 346);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_Notas
            // 
            this.lbl_Notas.AutoSize = true;
            this.lbl_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Notas.Location = new System.Drawing.Point(434, 39);
            this.lbl_Notas.Name = "lbl_Notas";
            this.lbl_Notas.Size = new System.Drawing.Size(52, 16);
            this.lbl_Notas.TabIndex = 5;
            this.lbl_Notas.Text = "Notas:";
            // 
            // btn_Notas
            // 
            this.btn_Notas.Location = new System.Drawing.Point(212, 209);
            this.btn_Notas.Name = "btn_Notas";
            this.btn_Notas.Size = new System.Drawing.Size(94, 40);
            this.btn_Notas.TabIndex = 6;
            this.btn_Notas.Text = "Notas";
            this.btn_Notas.UseVisualStyleBackColor = true;
            this.btn_Notas.Click += new System.EventHandler(this.btn_Notas_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(45, 391);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Visualizacao
            // 
            this.lbl_Visualizacao.AutoSize = true;
            this.lbl_Visualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Visualizacao.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Visualizacao.Location = new System.Drawing.Point(91, 52);
            this.lbl_Visualizacao.Name = "lbl_Visualizacao";
            this.lbl_Visualizacao.Size = new System.Drawing.Size(247, 25);
            this.lbl_Visualizacao.TabIndex = 8;
            this.lbl_Visualizacao.Text = "Visualização de Notas";
            // 
            // cb_NomeAluno
            // 
            this.cb_NomeAluno.FormattingEnabled = true;
            this.cb_NomeAluno.Location = new System.Drawing.Point(164, 140);
            this.cb_NomeAluno.Name = "cb_NomeAluno";
            this.cb_NomeAluno.Size = new System.Drawing.Size(194, 23);
            this.cb_NomeAluno.TabIndex = 9;
            // 
            // MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_NomeAluno);
            this.Controls.Add(this.lbl_Visualizacao);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Notas);
            this.Controls.Add(this.lbl_Notas);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "MenuAluno";
            this.Text = "MenuAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_Notas;
        private System.Windows.Forms.Button btn_Notas;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Visualizacao;
        private System.Windows.Forms.ComboBox cb_NomeAluno;
    }
}