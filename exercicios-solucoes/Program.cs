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
                "\n1 - Exercicio 01"
                );

            var escolhaUsuario = Console.ReadLine();
            Console.Clear();

            switch (escolhaUsuario)
            {
                case "1":
                    Exercicio01 helloWorld = new Exercicio01();
                    helloWorld.MostrarExercicio01();
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
