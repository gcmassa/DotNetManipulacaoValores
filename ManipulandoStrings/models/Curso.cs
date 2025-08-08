using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulandoStrings.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}"); // $ caracteriza uma interpolação de string

            Console.WriteLine("Usando técnica de Concatenação de String\n");
            for (int count = 0; count < Alunos.Count; count++)
            {
                int exibicao = count + 1;
                string texto = "N. " + exibicao + " - " + Alunos[count].NomeCompleto.ToUpper(); // Concatenando a string, caracterizado pelo sinal + com a variável
                Console.WriteLine(texto);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Usando técnica de Interpolação de String\n");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N. {count+1} - {Alunos[count].NomeCompleto.ToUpper()}"; // Interpolando a string, caracterizado pelo sinal $ e entre chaves {} à variável
                Console.WriteLine(texto);
            }

        }
    }
}