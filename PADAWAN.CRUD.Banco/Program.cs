using PADAWAN.CRUD.Context;
using System;

namespace PADAWAN.CRUD.Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BoletimContext();

            foreach (var aluno in context.Alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("Banco criado");
            Console.ReadKey();
        }
    }
}
