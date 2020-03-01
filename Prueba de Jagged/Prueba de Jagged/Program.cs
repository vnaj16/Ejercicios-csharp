using System;

namespace Prueba_de_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de aulas: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int[][] Aula = new int[A][];

            for(int i = 0; i < Aula.GetLength(0); i++)
            {
                Console.Write("Ingrese la cantidad de alumnos en el aula {0}: ", i + 1);
                A = Convert.ToInt32(Console.ReadLine());
                Aula[i] = new int[A];
            }

            Console.Clear();

            for(int c = 0; c < Aula.GetLength(0); c++)
            {

                Console.WriteLine("Aula {0} tiene {1} alumnos", c + 1, Aula[c].GetLength(0));
               
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            for(int c = 0; c < Aula.GetLength(0); c++)
            {
                Console.WriteLine("   AULA {0}", c + 1);
                for(int f = 0; f < Aula[c].GetLength(0); f++)
                {
                    Console.Write("Edad de alumno {0}: ", f + 1);
                    Aula[c][f] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();



            for (int c = 0; c < Aula.GetLength(0); c++)
            {
                Console.WriteLine("   AULA {0}", c + 1);
                for (int f = 0; f < Aula[c].GetLength(0); f++)
                {
                    Console.WriteLine("Edad de alumno {0}: {1}", f+1, Aula[c][f]);
                    
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
