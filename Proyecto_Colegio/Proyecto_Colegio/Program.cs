using System;
using System.Collections;

namespace Proyecto_Colegio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase alumno, carrera, profesor, aula, colegio
            //alumno(carrera) //aula(alumno,profesor) //colegio(aula)

            

            C_Aula Aula = new C_Aula(16);

            while (true)
            {
                Aula.Administrar();
            }

            Console.ReadKey(); //Para esperar que se presione una tecla
        }
    }
}
