namespace exercicios_logica.Solucao
{
    public class Exercicio06
    {
        public void MostrarExercicio06()
        {
            Console.WriteLine("Digite um numero para receber o antecessor e sucessor: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine($"Antecessor: {numero - 1}");
            
            Console.WriteLine();
            Console.WriteLine($"Sucessor: {numero + 1}");
            
            Console.ReadLine();
        }
    }
}
