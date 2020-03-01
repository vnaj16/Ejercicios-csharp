using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Colegio
{
    class C_Alumno
    {
        private string Nombre_Completo;
        private int Edad;
        //Clase carrera
        private C_Carrera Carrera;


        ////////Propiedad/////////////////
        public string P_Nombre_Completo
        {
            get
            {
                return Nombre_Completo;
            }
            set
            {
                Nombre_Completo = value;
            }
        }
        ///////////////////////////////////


        ///////Constructores/////////
        public C_Alumno()
        {
            Carrera = new C_Carrera();
        }
        public C_Alumno(string _Nombre, int _Edad, C_Carrera _Carrera)
        {
            Nombre_Completo = _Nombre;
            Edad = _Edad;
            Carrera = _Carrera;
        }
        ////////////////////////////

        public void Pedir_Datos()
        {
            Console.Write("Ingrese el nombre completo: ");
            Nombre_Completo = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            Edad = Convert.ToInt32(Console.ReadLine()); //Para convertir la cadena a int
            Carrera.Pedir_Datos();
        }

        public void Mostrar_Datos()
        {
            Console.WriteLine("    {0}", Nombre_Completo);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine(Carrera.ToString());
        }

    }
}
