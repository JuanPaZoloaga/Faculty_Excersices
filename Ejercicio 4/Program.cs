internal class Ejercicio_4
{
    private static void Main(string[] args)
    {
        int i;
        i= 0;
        decimal x;     

        while (i==0)
        {
            while (i <= 0)
            {
                Console.WriteLine("Ingrese un Numero Positivo de 1 o 2 Digitos");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            x = i / 10;

            if (x >= 0 && x < 1)
            {
                Console.WriteLine("Numero Ingresado tiene 1 Digito");
                break;

            }
            else if (x >= 1 && x < 10)
            {
                Console.WriteLine("Numero Ingresado tiene 2 Digito");
                break ;
            }
            else
            {
                Console.WriteLine("Numero Ingresado No es Valido\n");
            }

        }        

        

    }
}
