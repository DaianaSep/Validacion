using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    class Actividades
    {
        public void A35()
        {
            bool IngresoValido=false;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                string Num = Console.ReadLine();

                if(!int.TryParse(Num, out int NumOk))
                {
                    Console.WriteLine("No ingresó un número válido");
                    continue;
                }
                IngresoValido = true;
                Console.WriteLine("El número ingresado es: " + NumOk);

            } while (!IngresoValido);
        }

        public void A36()
        {
            bool IngresoValido = false;

            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string Ingreso = Console.ReadLine();

                if (!DateTime.TryParse(Ingreso, out DateTime IngresoOk))
                {
                    Console.WriteLine("No ingresó una fecha válida");
                    continue;
                }
                IngresoValido = true;
                Console.WriteLine("La fecha ingresada es: " + IngresoOk);

            } while (!IngresoValido);
        }

        public void A37()
        {
            bool IngresoValido = false;

            do
            {
                Console.WriteLine("Ingrese un texto entre 10 y 20 caracteres: ");
                string Ingreso = Console.ReadLine();

                if (string.IsNullOrEmpty(Ingreso) || Ingreso.Length>20 || Ingreso.Length<10)
                {
                    Console.WriteLine("No ingresó un texto válido");
                    continue;
                }
                IngresoValido = true;
                Console.WriteLine("El texto ingresado es: " + Ingreso);

            } while (!IngresoValido);
        }

        //public void A38()
        //{
        //    bool IngresoValido = false;

        //    do
        //    {
        //        Console.WriteLine("Ingrese un número: ");
        //        string Ingreso = Console.ReadLine();

        //        if (string.IsNullOrEmpty(Ingreso) || Ingreso.Length > 20 || Ingreso.Length < 10)
        //        {
        //            Console.WriteLine("No ingresó un texto válido");
        //            continue;
        //        }
        //        IngresoValido = true;
        //        Console.WriteLine("El texto ingresado es: " + Ingreso);

        //    } while (!IngresoValido);

        //    for (int i = 0; i < 0; i++)
        //    {

        //    }
        //}


    }
}
