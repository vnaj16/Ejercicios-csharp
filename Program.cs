using System;

namespace Ejercicio_3_Hoja_1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Edades;
            int N;

            int[] Datos = {200,0,0}; // {Menor edad, Posicion de menor edad, Personas dentro de rango};
            int[] Buscar = new int[3]; //   {Numero a buscar, Posicion del numero, seEncontro?1/2};

            Buscar[2] = 0;

            do
            {
                Console.Write("Ingrese la cantidad total de personas: ");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N < 0 || N > 100);
            
            Edades = new int[N];

            Generar_Edades(Edades,Datos);
            Mostrar_Edades(Edades);

            Console.WriteLine();
            Console.WriteLine("Menor edad: {0}", Datos[0]);
            Console.WriteLine("   Posicion en el arreglo: {0}", Datos[1]+1);
            Console.WriteLine("   Personas que tienen entre 30 y 50 years: {0}", Datos[2]);

            Console.WriteLine("Ingrese la edad que desea buscar: ");
            Buscar[0] = Convert.ToInt32(Console.ReadLine());

            Buscar_Numero(Edades,Buscar);

            Console.Write("El numero {0} que busca {1} se encuentra", Buscar)

            Console.ReadKey();
          
        }

        static void Generar_Edades(int [] Edades, int [] Datos)
        {
            Random r = new Random();
            for (int i = 0; i < Edades.GetLength(0); i++)
            {
                Edades[i] = r.Next(1,105);

                if(Edades[i] < Datos[0])
                {
                    Datos[0] = Edades[i];
                    Datos[1] = i; 
                }

                if (Edades[i] >= 30 && Edades[i] <= 50)
                {
                    ++Datos[2];
                }
            }
        }

        static void Mostrar_Edades(int[] Edades)
        {
           
            for (int i = 0; i < Edades.GetLength(0); i++)
            {
                Console.WriteLine("Edad de la persona {0}: {1}", i + 1, Edades[i]);
            }
        }


        static void Buscar_Numero(int[] Edades, int [] Buscar)
        {
            for(int i = 0; i < Edades.GetLength(0); i++)
            {
                if (Edades[i] == Buscar[0])
                {
                    Buscar[1] = i;
                    Buscar[2] = 1;
                }
            }
        }
    }
}
