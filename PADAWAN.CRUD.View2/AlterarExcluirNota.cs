using Newtonsoft.Json;
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
    public partial class AlterarExcluirNota : Form
    {
        public AlterarExcluirNota()
        {
            InitializeComponent();
            CarregarAluno();
            CarregarMateria();
            CarregarNota();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cb_Aluno.Text, @"\d+").Value), out int aluno);
            var URL = "http://localhost:60096/CadastroNotas/DeletarNotas";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync($"{URL}?idAluno={aluno}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();



            MessageBox.Show("Excluido com Sucesso");
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

        private void CarregarNota()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/CadastroNotas/MostraNotas";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Nota>>(result.Result);

            foreach (var nota in data)
            {
                cb_Nota.Items.Add($"{nota.NotaAluno}");
            }

        }

        private class Root
        {
            public List<Aluno> Data { get; set; }
            public List<Materia> DataMateria { get; set; }
            public List<Nota> DataNota { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new CadastroNota();
            this.Hide();
            menu.Show();
        }
    }
}
