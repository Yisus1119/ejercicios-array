using System;

namespace package
{
    class ClaseObjeto
    {

        //metodo para la tabla de multiplicar

        public void TablaMultiplicar()
        {
            int tbl = 0;
            while (tbl != -1)
            {
                Console.WriteLine("Ingrese un numero: ");
                tbl = Convert.ToInt32(Console.ReadLine());

                if (tbl == -1)
                {
                    continue;
                }
                Console.WriteLine("Tabla del " + tbl);
                for (int h = 1; h <= 12; h++)
                {
                    int mp = tbl * h;

                    Console.WriteLine(tbl + " X " + h + " = " + mp);
                }
            }
        }

        public void DatosPersona()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El nombre ingresado fue: " + nombre);
            Console.WriteLine("La edad ingresada fue: " + edad);

            if (edad >= 18)
            {
                Console.WriteLine("El usuario es mayor de edad.");
            }
            else
            {
                Console.WriteLine("El usuario es menor de edad.");
            }

        }

                


    }

}