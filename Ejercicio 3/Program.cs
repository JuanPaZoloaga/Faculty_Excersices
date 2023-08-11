internal class Ejercicio_3
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int suma;
        int promedio;
        Console.WriteLine("Ingrese Nota 1");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese Nota 2");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese Nota 3");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        suma = a + b + c;
        promedio = suma / 3;
        if (promedio >= 7)
        {
            Console.WriteLine("Promocionado");

        }
        else
        {
            Console.WriteLine("No Promociona");
        }


    }
}
