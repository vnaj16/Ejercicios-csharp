using System;

namespace Ejercicio_1_Hoja_1_Arrays
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] Notas = new int[6];
            float Promedio = 0;
            int Menor = 20;

             Pedir_Notas(Notas);
             Console.WriteLine();
             Mostrar_Notas(Notas);
            Console.WriteLine();
            Analizar_Notas(Notas, ref Promedio, ref Menor);

            Console.WriteLine("La menor nota es: {0}", Menor);
            Console.WriteLine("El promedio es: {0}", Promedio);

            Console.ReadKey();

            return 0;
        }


        static void Pedir_Notas(int [] Notas)
        {
            for(int i = 0; i < 6; i++)
            {
                do
                {
                    Console.Write("Ingrese la nota {0}: ", i + 1);
                    Notas[i] = Convert.ToInt32(Console.ReadLine());
                } while (Notas[i] < 0 || Notas[i] > 20);
            }
        }

        static void Mostrar_Notas(int [] Notas)
        {
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i + 1, Notas[i]);
            }
        }


        static void Analizar_Notas(int [] Notas, ref float Promedio, ref int Menor)
        {
       
            for(int i = 0; i < 6; i++)
            {
                if (Notas[i] < Menor)
                {
                    Menor = Notas[i];
                }
                Promedio += Notas[i];
            }

            Promedio -= Menor;
            Promedio /= 5;

        }

    }
}
