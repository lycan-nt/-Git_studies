using System;

namespace ProjetoNotaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma escola precisa calcular a media dos alunos de uma sala

            Console.WriteLine("=================Média dos alunos====================");

            // Variaveis
            float Soma = 0;
            float Media = 0;
            float nota = 0;

            //Comando de reptção (Dentro do bloco sera execultado a soma de todos os 5 alunos  apos isso sai do bloco)
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("digite a nota do aluno  " + i + ":");
                float.TryParse(Console.ReadLine(), out nota);
                Soma = Soma + nota;

            }

            //Pega a media da soma por 5 e joga na variavel
            Media = Soma / 5;

            //Escreve na tela
            Console.WriteLine("A média dos alunos é: " + Media);

            Console.Read();

        }
    }
}
