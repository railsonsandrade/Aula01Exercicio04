internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor para saque: ");

        int valor = Convert.ToInt32(Console.ReadLine());

        if (valor % 2 != 0 && valor < 5)
        {
            Console.WriteLine("O valor informado é inválido para saque! Apenas notas de 100, 50, 20, 10, 5 e 2 reais são permitidas.");
            return;
        }

        int[] cedulas = { 100, 50, 20, 10, 5, 2 };
        int[] quantidadeNotas = new int[cedulas.Length];

        for (int i = 0; i < cedulas.Length; i++)
        {
            quantidadeNotas[i] = valor / cedulas[i];
            valor %= cedulas[i];
        }

        if (valor != 0)
        {
            Console.WriteLine("Valor inválido para saque.");
        }
        else
        {
            Console.WriteLine("Notas fornecidas:");
            for (int i = 0; i < cedulas.Length; i++)
            {
                if (quantidadeNotas[i] > 0)
                {
                    Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {cedulas[i]}");
                }
            }
        }
    }
}