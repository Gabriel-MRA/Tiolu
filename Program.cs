internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quanto Você me ama?");
        string valor = Console.ReadLine();

        int metrica = int.Parse(valor);

        for (int i = 0; i < 1; i++)
        {


            {
                if (metrica > 1000000)
                {
                    Console.WriteLine("Eu te amo mais que tudo nessa vida, caraca");
                }
                else if (metrica > 10000)
                {
                    Console.WriteLine("Você é meu vidão, demais");
                }
                else if (metrica > 1000)
                {
                    Console.WriteLine("Te adoro flor");
                }
                else
                {
                    Console.WriteLine("Agora, só saldade");
                }

            }
        }
    }
}