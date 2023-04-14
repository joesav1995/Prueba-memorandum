using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String persona1;
            String edad1;

            List<Persona> lst = new List<Persona>();
            for (int i=0; i<5; i++)
            {
                Persona person = new Persona();
                Console.WriteLine("Introduzca el nombre de la persona:");
                
                persona1 = Console.ReadLine();

                Console.WriteLine("Introduzca la edad de la persona:");
                
                edad1 = Console.ReadLine();
                lst.Add(new Persona(persona1, Int32.Parse(edad1)));
                
            }

            foreach (var i in lst)
            {
                if (i.edad >= 18)
                {
                    Console.WriteLine("Nombre de la persona: " + i.nombre);
                    Console.WriteLine("Edad de la persona: " + i.edad);
                }



            }
            Console.Write("Presiona <Enter> para salir ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

    }
}
