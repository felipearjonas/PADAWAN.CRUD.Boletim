using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lbl_Menu_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Administrador_Click(object sender, EventArgs e)
        {
            var menuadmistrador = new MenuAdministrador();
            this.Hide();
            menuadmistrador.Show();
        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
            var menualuno = new MenuAluno();
            this.Hide();
            menualuno.Show();
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            var cadastronota = new CadastroNota();
            this.Hide();
            cadastronota.Show();
        }
    }
}
