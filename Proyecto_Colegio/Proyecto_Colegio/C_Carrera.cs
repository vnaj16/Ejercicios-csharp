using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Colegio
{
    class C_Carrera
    {
        private string Carrera;
        private int Codigo;
        private int Duracion;

        public C_Carrera()
        {

        }

        public C_Carrera(string _Carrera, int _Codigo, int _Duracion)
        {
            Carrera = _Carrera;
            Codigo = _Codigo;
            Duracion = _Duracion;
        }

        public void Pedir_Datos()
        {
            Console.Write("Ingrese la carrera: ");
            Carrera = Console.ReadLine();
            Console.Write("Ingrese el codigo de la carrera: ");
            Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la duracion de la carrera: ");
            Duracion = Convert.ToInt32(Console.ReadLine());
        }

        //////Nueva deficion de ToString para esta clase
        public override string ToString() //override sirve para anular la funcion e implementar una nueva
        { 

            ///////Primera forma para construir una cadena
            //string Cadena = "Carrera: " + Carrera + Environment.NewLine + "Codigo: " + Codigo + Environment.NewLine + "Duracion: " + Duracion;

            //////////Segunda forma para construir una cadena
            /////Recomendado para cadenas largas
            StringBuilder Cadena_Cons = new StringBuilder();

            Cadena_Cons.Append("Carrera: ");
            Cadena_Cons.Append(Carrera);
            Cadena_Cons.AppendLine();
            Cadena_Cons.Append("Codigo: ");
            Cadena_Cons.Append(Codigo);
            Cadena_Cons.AppendLine();
            Cadena_Cons.Append("Duracion: ");
            Cadena_Cons.Append(Duracion);
            Cadena_Cons.Append(" años");
            //Puedo asignar el builder a un string

            return Cadena_Cons.ToString();
        }
    }
}
