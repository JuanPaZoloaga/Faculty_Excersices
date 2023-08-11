internal class Ejercicio_2
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int d;
        int suma;
        int promedio;
        Console.WriteLine("Ingrese Valor 1");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese Valor 2");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese Valor 3");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese Valor 4");
        d = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        suma = a + b + c + d;
        promedio = suma / 4;
        Console.WriteLine("La Suma de sus 4 Valores es: " + suma);
        Console.WriteLine("El Promedio de sus 4 Valores es: " + promedio);
    }
}
