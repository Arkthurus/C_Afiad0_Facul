using System;
using System.Globalization;


namespace SistemaDeAlunos{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a Nota 1: ");
            float  nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //garante o separador decimal

            Console.WriteLine("Digite a Nota 2: ");
            float  nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //garante o separador decimal

            ALUNO aluno1 = new ALUNO(nome,nota1,nota2);
            aluno1.ExibirResult();

        }
    }

    class ALUNO
    {
        private string nome {get; set;}
        private float nota1 {get; set;}
        private float nota2 {get; set;}

        public ALUNO(string nome, float nota1, float nota2)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void ExibirResult()
        {
            float media = CalcMedia();
            System.Console.WriteLine($"\nALuno: {this.nome}");
            System.Console.WriteLine($"Média: {media}");

            if (media > 6.0)
            {
                System.Console.WriteLine("\nAprovado!!");
            }else
            {
                System.Console.WriteLine("\n Reprovado!!");
            }
        }
        public float CalcMedia()
        {
            float soma = this.nota1+this.nota2;
            return soma/2;
        }
    }
}