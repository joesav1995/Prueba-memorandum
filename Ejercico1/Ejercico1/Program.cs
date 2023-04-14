using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico1
{
    class Program
    {
        static void Main(string[] args)
        {

            int resulta;

            resulta = 0;
            Console.WriteLine("Introduzca un numero");
            String numero1;
            numero1 = Console.ReadLine();

            Console.WriteLine("Introduzca un numero");
            String numero2;
            numero2 = Console.ReadLine();

            Console.WriteLine("Introduzca un simbolo (suma, resta, multiplicar, o dividir)");
            String signo;
            signo = Console.ReadLine();
            
            switch (signo)
            {
                case "/":
                    resulta = Int32.Parse(numero1)/ Int32.Parse(numero2);
                    break;
                case "+":
                    resulta = Int32.Parse(numero1) + Int32.Parse(numero2);
                    break;
                case "-":
                    resulta = Int32.Parse(numero1) - Int32.Parse(numero2);
                    break;
                case "*":
                    resulta = Int32.Parse(numero1) * Int32.Parse(numero2);
                    break;
            }
            Console.WriteLine("El sultado es: " + resulta);

            if (EsPrimo(resulta))
            {
            }
            else {
                Console.WriteLine("ALERTA!!! El numero "+ resulta + "no es primo " );
            }
            
            Console.Write("Presiona <Enter> para salir ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            //Console.WriteLine("El texto introducido es: " + texto);
        }
        static bool EsPrimo(int numero)
        {
            int c = 2;
            int final = numero - 1;
            bool primo = true;
            while (c<final)
            {
                if (numero % c ==0)
                {
                    c = final - 1;
                    primo = false;
                }
                c++;
            }
            
            return primo;
        }
    }
}
