internal class Program
{
    private static void Main(string[] args)
    {
        int[] cursoA = new int[5];
        int[] cursoB = new int[5];
        float promedioA = 0, promedioB = 0;
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            cursoA[i] = random.Next(10);
            cursoB[i] = random.Next(10);
            promedioA += cursoA[i];
            promedioB += cursoB[i];
        }
        promedioA = promedioA / 5;
        promedioB = promedioB / 5;
        Console.WriteLine($"El promedio del curso A es: {promedioA}\nEl promedio del curso B es: {promedioB}");
    }
}