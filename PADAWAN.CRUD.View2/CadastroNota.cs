﻿using Newtonsoft.Json;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class CadastroNota : Form
    {
        public CadastroNota()
        {
            InitializeComponent();
            CarregarAluno();
            CarregarMateria();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cb_Aluno.Text, @"\d+").Value), out int aluno);
            int.TryParse((Regex.Match(cb_Materia.Text, @"\d+").Value), out int materia);

            //(int, int) content = (aluno, materia);

          
            var URL = $"http://localhost:60096/CadastroNotas/MatricularAluno?idAluno={aluno}&idMateria={materia}";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Cadastrado com Sucesso");
        }
        private void CarregarAluno()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/Cadastro/MostraAlunos";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Aluno>>(result.Result);

            foreach (var aluno in data)
            {
                cb_Aluno.Items.Add($"{aluno.IdAluno} - {aluno.Nome}");
            }
        }
        private void CarregarMateria()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/CadastroMateria/MostraMaterias";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Materia>>(result.Result);

            foreach (var materia in data)
            {
                cb_Materia.Items.Add($"{materia.IdMateria} - {materia.NomeMateria}");
            }

        }

        private class Root
        {
            public List<Aluno> Data { get; set; }
            public List<Materia> DataMateria { get; set; }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdministrador();
            this.Hide();
            menu.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var menu = new AlterarExcluirNota();
            this.Hide();
            menu.Show();

        }

        private void cb_Aluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
