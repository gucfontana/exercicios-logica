namespace exercicios_logica.Solucao
{
    public class Exercicio02
    {
        private string ? Nome { get; set; }
        
        public void MostrarExercicio02()
        {
            Console.WriteLine("Oi!\nQual eh seu nome?");
            Nome = Console.ReadLine();
            
            Console.WriteLine($"Seja bem vindo {Nome}!");
            Console.ReadLine();
        }
    }
}
