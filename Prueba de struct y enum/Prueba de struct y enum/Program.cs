using System;

namespace Prueba_de_struct_y_enum
{
    class Program
    {
        enum dia { Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

        struct persona
        {
            short Edad;
            string Nombre;
            dia Dia_Favorito;

            public persona(short E, string N, dia F)
            {
                Edad = E;
                Nombre = N;
                Dia_Favorito = F;
            }

            public override string ToString()
            {
                string Cadena = "       " + Nombre + "\n" + "Edad: " + Edad + "\n" + "Dia Favorito: " + Dia_Favorito.ToString();
                return Cadena;
            }

        };

        static void Main(string[] args)
        {
            persona Individuo = new persona(19, "Arthur Valladares", dia.Sabado);

            Console.Write(Individuo.ToString());

            Console.ReadKey();

        }
    }
}
  
