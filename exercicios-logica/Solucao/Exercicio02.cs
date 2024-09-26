namespace exercicios_logica.Solucao
{
    public class Exercicio02
    {
        private string ? Nome { get; set; }

        public void MostrarExercicio02()
        {
            while ( true )
            {
                Console.WriteLine("Oi!\nQual eh seu nome?");
                Nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    Console.WriteLine("Por favor, digite seu nome");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine($"Seja bem vindo {Nome}!");
                Console.ReadLine();
                break;
            }
        }
    }
}
