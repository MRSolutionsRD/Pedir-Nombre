using System;

namespace Pedir_Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            Console.WriteLine("Cuál es tu nombre?");
            nom = Console.ReadLine();


            int ed;
            Console.WriteLine("Qué edad tienes?");
            ed = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Te llamas " + nom+ " y tienes " + ed + " años de edad.");
            

            Console.ReadKey();

        
        
        }
    }
}
