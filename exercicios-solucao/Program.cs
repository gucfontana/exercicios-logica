﻿using exercicios_logica.Solucao;

namespace exercicios_solucoes;

class Program
{
    static void Main(string[] args)
    {
        bool funcionando = true;
        while ( funcionando )
        {
            Console.WriteLine("Lista de exercicios!\n" +
                "\nSelecione o exercicio para abrir a solucao!\n" +
                "\n0 - Sair\n" +
                "\n1 - Exercicio 01" +
                "\n2 - Exercicio 02" +
                "\n3 - Exercicio 03" +
                "\n4 - Exercicio 04" +
                "\n5 - Exercicio 05" +
                "\n6 - Exercicio 06"
                );

            var escolhaUsuario = Console.ReadLine();
            Console.Clear();

            switch (escolhaUsuario)
            {
                case "1":
                    Exercicio01 helloWorld = new Exercicio01();
                    helloWorld.MostrarExercicio01();
                    break;
                
                case "2":
                    Exercicio02 boasVindas = new Exercicio02();
                    boasVindas.MostrarExercicio02();
                    break;

                case "3":
                    Exercicio03 nomeESalario = new Exercicio03();
                    nomeESalario.MostrarExercicio03();
                    break;
                
                case "4":
                    Exercicio04 somaNumeros = new Exercicio04();
                    somaNumeros.MostrarExercicio04();
                    break;
                
                case "5":
                    Exercicio05 mediaNotas = new Exercicio05();
                    mediaNotas.MostrarExercicio05();
                    break;
                
                case "6":
                    Exercicio06 antecessorSucessor = new Exercicio06();
                    antecessorSucessor.MostrarExercicio06();
                    break;
                
                case "0":
                    funcionando = false;
                    break;

                default:
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    break;
            }
        }
    }
}
