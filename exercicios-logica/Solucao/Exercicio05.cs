namespace exercicios_logica.Solucao
{
    public class Exercicio05
    {
        public void MostrarExercicio05()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double primeiraNota = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota: ");
            double segundaNota = Convert.ToDouble(Console.ReadLine());

            double media = (primeiraNota + segundaNota) / 2;
            
            Console.WriteLine($"A média é: {media}");

            Console.ReadLine();
        }
    }
}
