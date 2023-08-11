internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int[] saldoCuenta = new int[10];

        for (int i = 0; i < 10; i++)
        {
            saldoCuenta[i] = random.Next(10000, -10000);
        }
        int n;
        do
        {
            n = 0;
            Console.WriteLine("Ingrese el numero de legajo para buscar la cuenta hay 10 cuentas:");
            n = Convert.ToInt32(Console.ReadLine()) - 1;
            if (saldoCuenta[n - 1] < 0)
            {
                Console.WriteLine($"El saldo de la cuenta {n} es deudor");
            }
            if (saldoCuenta[n - 1] > 0)
            {
                Console.WriteLine($"El saldo de la cuenta {n} es acredor");
            }
            if (saldoCuenta[n - 1] == 0)
            {
                Console.WriteLine($"El saldo de la cuenta {n} es nulo");
            }
        } while (n > 0);
    }
}
