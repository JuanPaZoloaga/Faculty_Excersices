internal class Program
{
    private static void Main(string[] args)
    {
        int precio;
        int cantidad;
        int total;
        int formula;
        bool continua;
        char respuesta;
        continua = true;
        formula = 0;
        total = 0;
        precio = 0;
        cantidad = 0;




        while (continua == true)
        {
            Console.WriteLine("Desesa Agregar una Compra {[y]si-[n]salir y dar el total}");
            respuesta = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if (respuesta == 'y')
            {
                Console.WriteLine("Precio del Articulo");
                precio = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Cantidad de Articulos");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                formula = precio * cantidad;
                total = formula;
            }
            else if (respuesta == 'n')
            {
                Console.WriteLine("Total a cobrar es igual a = " + total);
                continua = false;
            }
            else
            {
                Console.WriteLine("Opcion Invalida");
            }

        }
    }
}
