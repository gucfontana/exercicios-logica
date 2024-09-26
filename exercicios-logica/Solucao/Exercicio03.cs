using System.Diagnostics.CodeAnalysis;

namespace exercicios_logica.Solucao
{
    public class Exercicio03
    {
        private string ? Salario { get; set; }
        private string ? Nome { get; set; } 
        
        public void MostrarExercicio03()
        {
            while ( true )
            {
                Console.WriteLine("Digite o seu nome: ");
                Nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    Console.WriteLine("O nome nao pode ficar em branco");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o seu salario: ");
                Salario = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Salario))
                {
                    Console.WriteLine("O salario nao pode ficar em branco");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine($"{Nome} o seu salario eh R${Salario}");
                Console.ReadLine();
                break;
            }
        }
    }
}
