using System;

internal class Ejercicio_6
{

    private static void Main(string[] args)
    {
        /* 
         * En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
        $500, realizar un programa que lea los sueldos que cobra cada empleado e informe
        cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además
        el programa deberá informar el importe que gasta la empresa en sueldos al personal.            
        */
        int total_empleados;
        total_empleados = 0;
        bool a;
        a= false;
        int empleados100300;
        empleados100300 = 0;
        int empleados300;
        empleados300 = 0;
        
        do
        {
            try
            {
                Console.WriteLine("Ingrese Numero Total de Empleados");
                total_empleados = Int32.Parse(Console.ReadLine());
                Console.Clear();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Numero Invalido \n [(Enter) para continuar]");
                Console.ReadKey();
                a = true;
                Console.Clear();
            }
        } while (total_empleados < 0 || a == true);
        decimal[] sueldos;
        sueldos = new decimal[total_empleados];
        for (int i = 0; i < total_empleados ; i++)
        {
            Console.WriteLine(" Escriba el sueldo del empleado "+ (i+1));
            sueldos[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(sueldos[i]);
            Console.ReadKey();
            if (sueldos[i]<300 && sueldos[i]>100)
            {
                empleados100300++;
            }
            else if (sueldos[i]>300)
            {
                empleados300++;
            }


        }
        decimal sum;
        sum = sueldos.Sum();
        Console.WriteLine($" Empleados que cobran entre $100 y $300: {empleados100300}\n Empleados que cobran mas de $300 {empleados300}");
        Console.WriteLine($" El monto total a liquidar en sueldos es: {sum}");








    }
}