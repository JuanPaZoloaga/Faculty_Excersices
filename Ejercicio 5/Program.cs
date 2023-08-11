internal class Ejercicio_5
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        decimal c;
        bool d;
        a = 0;
        b = 0;
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese Cantidad Preguntas Realizadas");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese Cantidad Preguntas Correctas");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    d=true; 
                }
                catch (Exception e)
                {                    
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Numero Invalido, Enter para continuar");
                    Console.ReadKey();
                    d = false;
                    Console.Clear();
                }
            } while (a < 0 || b < 0);

        } while (d == false);
            
            c = (b / (decimal) a)*100 ;
            Console.WriteLine(c);
            Console.Clear();
            if (c >= 90)
            {
                Console.WriteLine("Nivel Maximo");
            }
            else if (c < 90 && c >=75)
            {
                Console.WriteLine("Nivel Medio");
            }
            else if (c < 75 && c >= 50)
            {
                Console.WriteLine("Nivel Regular");

            }
            else if (c < 50)
            {
                Console.WriteLine("Fuera de Nivel");

            }
        
        
        

    }
}
