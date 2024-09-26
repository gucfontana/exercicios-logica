namespace exercicios_logica.Solucao
{
    public class Exercicio04
    {
        public Exercicio04()
        {
            Soma = PrimeiroNumero + SegundoNumero;
        }
        
        private string Soma { get; set; }
        private string ? SegundoNumero { get; set; }
        private string ? PrimeiroNumero { get; set; }
        
        public void MostrarExercicio04()
        {
            while ( true )
            {
                Console.WriteLine("Digite o primeiro numero: ");
                PrimeiroNumero = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(PrimeiroNumero))
                {
                    Console.WriteLine("Por favor, digite o primeiro numero");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o segundo numero: ");
                SegundoNumero = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(SegundoNumero))
                {
                    Console.WriteLine("Por favor, digite o segundo numero");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine($"A soma dos numeros digitados eh: {Soma}");
                Console.ReadLine();
                break;
            }
        }
    }
}
