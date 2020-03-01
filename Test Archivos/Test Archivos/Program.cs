using System;
using System.Text;
using System.IO;

namespace Test_Archivos
{
    class Program
    {
        //Class FileStream
            //FileMode
                //Append -  Create - Open - Truncate

        //Write() -> escribe la cadena que se le pasa (array bytes)
            //Parametros(arreglo de bytes de donde se pasara, posicion desde donde se escribira respecto a la PA, cantidad de bytes que se colocara)

        //Read() -> lee el contenido de los archivos y los pasa a arrays de bytes
            //Parametros(arreglo de bytes donde se guardara,desde donde se leera en el stream, cantidad de bytes a leer)
        //Close() -> liberar recursos utilizados

        static void Pedir_Texto(string Texto, ref FileStream Archivo_Test, ref long Posicion)
        {
            Texto = "Nombre: ";
            Console.Write("Ingrese el texto: "); Texto += Console.ReadLine();

            Texto += Environment.NewLine;

            Archivo_Test.Seek(Posicion, SeekOrigin.Begin);
            Archivo_Test.Write(ASCIIEncoding.ASCII.GetBytes(Texto), 0, Texto.Length);
            Console.WriteLine("TEXTO AGREGADO");
            Posicion = Archivo_Test.Position;
            Console.WriteLine("Posicion Actual: {0}", Posicion);
            

            Console.ReadKey();
        }

        static void Leer_Datos_Archivo(string Texto,FileStream Archivo_Test)
        {
            Archivo_Test.Seek(0, SeekOrigin.Begin); // Ubico el posicionador en el inicio para desde ahi
            byte [] Buffer = new byte[(int)Archivo_Test.Length]; // Creo el arreglo de bytes donde guardare lo que saque del archivo
            Archivo_Test.Read(Buffer, 0, (int)Archivo_Test.Length);

            Texto = ASCIIEncoding.ASCII.GetString(Buffer); //Transoformo los bytes a strings

            Console.Write(Texto);
            Console.ReadKey();
        }

        static void Menu(ref int Opcion)
        {
            Console.WriteLine("         MENU");
            Console.WriteLine("1. Agregar texto");
            Console.WriteLine("2. Leer datos del archivo");
            Console.WriteLine("4. Salir");
            Console.Write("OPCION: "); Opcion = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            //Ordenar para abrir y cerrar archivos para leer, escribir desde la ultima posicion del stream
            FileStream Archivo_Test = new FileStream("MiTexto.txt", FileMode.OpenOrCreate);
            int Opcion=0;
            long Posicion = Archivo_Test.Position;
            string Texto = "";

            while (Opcion != 4)
            {
                Console.Clear();
                Menu(ref Opcion);

                Console.Clear();

                switch (Opcion)
                {
                    case 1: Pedir_Texto(Texto, ref Archivo_Test, ref Posicion); break;
                    case 2: Leer_Datos_Archivo(Texto,Archivo_Test); break;
                    case 4: break;
                            
                }
            }

            Archivo_Test.Close();
            Console.Write("ARCHIVO CERRADO");
            Console.ReadKey();
        }
    }
}
