using System;
using System.Collections;

namespace Prueba_de_ArrayList
{
    class ArrayListAJ
    {
        //  Add / foreach / Count / Insert / RemoveAt / IndexOf

        static void Menu(ref int Opcion)
        {
            Console.WriteLine("       Menu");
            Console.WriteLine("1. Agregar numero");
            Console.WriteLine("2. Mostrar numeros");
            Console.WriteLine("3. Mostrar cantidad de elementos");
            Console.WriteLine("4. Insertar elemento en posicion x");
            Console.WriteLine("5. Eliminar elemento de posicion x");
            Console.WriteLine("6. Buscar elemento");
            Console.WriteLine("7. Salir");
            Console.Write("Opcion: ");
            Opcion = Convert.ToInt32(Console.ReadLine());
        }

        static void Agregar_Numero( ArrayList Lista)
        {
            int Numero;
            Console.Write("Ingrese el numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            Lista.Add(Numero);

            Console.Write("Numero agregado");
            Console.ReadKey();

        }

        static void Mostrar_Numeros(ArrayList Lista)
        {
            foreach(int i in Lista)
            {
                Console.Write("{0} |", i);
            }
            Console.ReadKey();
        }

        static void Mostrar_Cantidad(ArrayList Lista)
        {
            Console.WriteLine("Cantidad de elementos de Lista: {0}", Lista.Count);
            Console.ReadKey();
        }

        static void Ingresar_Elemento_Posicion(ArrayList Lista)
        {
            int Numero, Posicion;
            do
            {
                Console.Write("En que posicion desea ingresar el numero [0, {0}]: ", Lista.Count - 1);
                Posicion = Convert.ToInt32(Console.ReadLine());
            } while (Posicion < 0 || Posicion > Lista.Count - 1);

            Console.Write("Numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            Lista.Insert(Posicion, Numero);

            Console.Write("Numero agregado");
            Console.ReadKey();


        }

        static void Eliminar_Elemento_Posicion(ArrayList Lista)
        {
            int Posicion;
            do
            {
                Console.Write("En que posicion desea eliminar el numero [0, {0}]: ", Lista.Count - 1);
                Posicion = Convert.ToInt32(Console.ReadLine());
            } while (Posicion < 0 || Posicion > Lista.Count - 1);

            Lista.RemoveAt(Posicion);

            Console.Write("Numero eliminado");
            Console.ReadKey();


        }

        static void Buscar_Elemento(ArrayList Lista)
        {
            int Elemento, Posicion;
            Console.Write("Ingrese que numero quiere buscar: ");
            Elemento = Convert.ToInt32(Console.ReadLine());

            Posicion = Lista.IndexOf(Elemento);

            if(Posicion != -1)
            {
                Console.WriteLine("El numero se encontro en la posicion {0}", Posicion);
            }
            else
            {
                Console.WriteLine("El numero no se encuentra");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            ArrayList Lista = new ArrayList();
            int Opcion = 0;

            while (Opcion != 7)
            {
                Menu(ref Opcion);
                Console.Clear();
                switch (Opcion)
                {
                    case 1:
                        Agregar_Numero( Lista);
                        break;
                    case 2:
                        Mostrar_Numeros(Lista);
                        break;
                    case 3:
                        Mostrar_Cantidad(Lista);
                        break;
                    case 4:
                        Ingresar_Elemento_Posicion(Lista);
                        break;
                    case 5:
                        Eliminar_Elemento_Posicion(Lista);
                        break;
                    case 6:
                        Buscar_Elemento(Lista);
                        break;
                }
                Console.Clear();
            }


        }
    }
}
