using System;

namespace ProjetoEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Situalçao/Problema: O diretor da empresa quer saber se os funcionarios estão gostando da empresa e se não o porque

            String NomeFuncionario;
            String SituaçãoFuncionario;
            String Relatório;

            Console.WriteLine("Olá, qual é o seu nome?");
            NomeFuncionario = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(NomeFuncionario + ", " + "Você esta gostando da empresa? (Sim/Não)");
            SituaçãoFuncionario = Console.ReadLine();

            if (SituaçãoFuncionario.ToLower() == "sim")
            {

                Console.WriteLine("Tambem gostamos de telo conosco!");

            }
            else if (SituaçãoFuncionario.ToLower() == "não")
            {

                Console.WriteLine("Bom gostarioamos de entender o porque, sua opnião e importante para nós!");
                Console.WriteLine("Por favor, preencha o formulario a baixo para que possamos avaliar seus motivos e melhorar.");
                Console.WriteLine("=================================================================================================");

                Console.WriteLine("Relatório de opnião/Sugestão: por favor escreva seus motivos: ");
                Relatório = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Muito bem, analisaremos sua respota. Agradessemos a cinceridade, bom trabalho!");


            }
            else
            {

                Console.WriteLine("As resposta validas são: Sim ou Não.");

            }

            
            Console.Read();
        }
    }
}
