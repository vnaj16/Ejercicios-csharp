using System;

namespace Ejercicio_2_Hoja_1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int Clientes,Personas_Delgadas=0, Personas_Medianas=0, Personas_Gruesas=0;
            
            float Peso_Promedio = 0, Mayor_Peso = 0;

            Console.Write("Cuantos clientes son: ");
            Clientes = Convert.ToInt32(Console.ReadLine());

            float[] Peso = new float[Clientes];

            Pedir_Pesos(Peso, Clientes);
            Console.WriteLine();
            Mostrar_Pesos(Peso, Clientes);
            Console.WriteLine();
            Console.WriteLine();

            Analizar_Datos(Peso, ref Personas_Delgadas, ref Personas_Medianas, ref Personas_Gruesas, ref Peso_Promedio, ref Mayor_Peso);

            Console.WriteLine("Peso promedio: {0}", Peso_Promedio);
            Console.WriteLine("Mayor peso: {0}", Mayor_Peso);
            Console.WriteLine("Cantidad de");
            Console.WriteLine("   Personas delgadas: {0}", Personas_Delgadas);
            Console.WriteLine("   Personas medianas: {0}", Personas_Medianas);
            Console.WriteLine("   Persona gruesas: {0}", Personas_Gruesas);

            Console.ReadKey();
        }


        static void Pedir_Pesos(float[] Peso, int Clientes)
        {
            for(int i = 0; i < Peso.GetLength(0); i++)
            {
                Console.Write("Ingrese el peso numero {0}: ", i + 1);
                Peso[i] = Convert.ToSingle(Console.ReadLine());
            }
        }

        static void Mostrar_Pesos(float[] Peso, int Clientes)
        {
            for (int i = 0; i < Clientes; i++)
            {
                Console.WriteLine("Cliente {0}", i + 1);
                Console.WriteLine("    Peso: {0}", Peso[i]);
            }
        }

        static void Analizar_Datos(float[] Peso,ref int Personas_Delgadas, ref int Personas_Medianas, ref int Personas_Gruesas, ref float Promedio, ref float Mayor_Peso)
        {
            for(int i = 0; i < Peso.GetLength(0); i++)
            {
                Promedio += Peso[i];
                if (Peso[i] > Mayor_Peso)
                {
                    Mayor_Peso = Peso[i];
                }

                if (Peso[i] < 53)
                {
                    ++Personas_Delgadas;
                }
                else if(Peso[i]>53 && Peso[i] < 60)
                {
                    ++Personas_Medianas;
                }
                else
                {
                    ++Personas_Gruesas;
                }

            }

            Promedio /= Peso.GetLength(0);
        }

    }
}
