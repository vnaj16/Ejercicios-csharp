using System;
using System.IO;
using System.Text;

namespace Test_flujos_streams
{
    class Program
    {

        static void Mostrar_Datos_Stream(MemoryStream Flujo_Memoria)
        {
            Console.WriteLine("Capacidad: {0}", Flujo_Memoria.Capacity);
            Console.WriteLine("Longitud: {0}", Flujo_Memoria.Length);
            Console.WriteLine("Posicion: {0}", Flujo_Memoria.Position);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ///////////////////////////// MemoryStream ///////////

            //Capacity (Capacidad total)
            //Length (Longitud ocupada)
            //Position (Posicion del byte a leer - actual)

            // Seek() -> Ubicar la posicion en un byte
                    //Parametros (distancia al PtRef, PtRef)
            
            // Write() -> sirve para escribir informacion en el flujo
                    //Parametros (arreglo de bytes que se colocara o escribira en el flujo, offset(Posicion desde donde se pondra a escribir), cantidad de bytes a escribir)

            // Read() -> lee los bytes contenidos en el flujo
                    //Parametros (arreglo de bytes para guardar informacion, offset(desde donde se pondra la informacion en el array), cantidad bytes a leer)

            // Close() -> para liberar los recursos usados

            /////////////////////////////////////////////////////////////
            

            MemoryStream Flujo_Memoria = new MemoryStream(40);
            byte[] Buffer = new byte[10]; // Arreglo para almacenar los bytes que se lean
            string Texto = "0123456789";

            /*Mostrar_Datos_Stream(Flujo_Memoria);

            Flujo_Memoria.Seek(10, SeekOrigin.Begin); // Mover la posicion 10 bytes desde el inicio

            Mostrar_Datos_Stream(Flujo_Memoria);

            Flujo_Memoria.Seek(20, SeekOrigin.Current); // Mover la posicion 20 bytes desde la posicion actual 

            Mostrar_Datos_Stream(Flujo_Memoria);

            Flujo_Memoria.Seek(-5, SeekOrigin.Current); // Mover la posicion 5 bytes a la izquierda desde la posicion actual 

            Mostrar_Datos_Stream(Flujo_Memoria);*/

            Flujo_Memoria.Write(ASCIIEncoding.ASCII.GetBytes(Texto), 0, Texto.Length); //Escribimos en el flujo desde la posicion 0 hasta la longitud de Texto
            Mostrar_Datos_Stream(Flujo_Memoria);

            Flujo_Memoria.Seek(0, SeekOrigin.Begin);//Ubicamos el iterador en la posicion de inicio
            Mostrar_Datos_Stream(Flujo_Memoria);

            //Flujo_Memoria.Read(Buffer, 0, Texto.Length); //Para leer toda la cadena
            Flujo_Memoria.Read(Buffer, 0, 10); //Para leer los 10 bytes y colocarlos desde la posicion 0 en el buffer
            Mostrar_Datos_Stream(Flujo_Memoria);

            Flujo_Memoria.Close();

            Console.WriteLine();
            Console.Write(ASCIIEncoding.ASCII.GetString(Buffer));

            Console.ReadKey();
            
        }
    }
}
