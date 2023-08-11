using System;

internal class Ejercicio_6
{

    private static void Main(string[] args)
    {
        /* De un operario se conoce su sueldo y los años de antigüedad.Se pide
        confeccionar un programa que lea los datos de entrada e informe:

        a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle
        un aumento del 20 %, mostrar el sueldo a pagar.

        b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años,
        otorgarle un aumento de 5 %.

        c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
        */
        bool a;
        decimal sueldo;
        sueldo = 0;
        int antiguedad;
        antiguedad = 0;
        a = false;

        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese Sueldo Actual [Numeros positivos]");
                    sueldo = decimal.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese Años de Antiguedad[Numeros positivos]");
                    antiguedad = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    a = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Numero Invalido \n [(Enter) para continuar]");
                    Console.ReadKey();
                    a = true;
                    Console.Clear();
                }
            } while (sueldo<0 || antiguedad<0);
           
        } while (a == true);
        
        if (sueldo < 500 && antiguedad >= 10)
        {
            Console.WriteLine("Otorgar Aumento del 20% \n [(Enter) para finalizar]");
            Console.ReadKey();
        }
        else if (sueldo < 500 && antiguedad < 10)
        {
            Console.WriteLine("Otorgar Aumento del 5% \n [(Enter) para finalizar]");
            Console.ReadKey();
        }
        else if (sueldo >= 500)
        {
            Console.WriteLine("Sin Cambios \n [(Enter) para finalizar]");
            Console.ReadKey();
        }


     
    }
 }