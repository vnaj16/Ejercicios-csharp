using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Colegio
{
    class C_Profesor
    {
        private string Nombre;
        private int Codigo;
        private string Curso;

        public C_Profesor()
        {

        }

        public void Pedir_Datos()
        {
          
            Console.Write("Ingrese su nombre: "); Nombre = Console.ReadLine();
            Console.Write("Ingrese su codigo: "); Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el curso: "); Curso = Console.ReadLine();
        }

        public void Mostrar_Datos() {
            Console.WriteLine("Nombre: {0} \nCodigo: {1} \nCurso: {2}", Nombre, Codigo, Curso);

        }

    }
}
