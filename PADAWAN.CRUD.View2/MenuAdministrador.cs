using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btn_Materia_Click(object sender, EventArgs e)
        {
            var cadastromateria = new CadastroMateria();
            this.Hide();     //esconde o formulário atual
            cadastromateria.Show();
        }

        private void btn_Curso_Click(object sender, EventArgs e)
        {
            var cadastrocurso = new CadastroCurso();
            this.Hide();
            cadastrocurso.Show();
        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
            var cadastroaluno = new CadastroAluno();
            this.Hide();
            cadastroaluno.Show();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
