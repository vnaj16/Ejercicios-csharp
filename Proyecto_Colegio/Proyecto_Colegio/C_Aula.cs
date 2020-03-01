using System;
using System.Collections;


namespace Proyecto_Colegio
{
    class C_Aula
    {
        private int Numero_Alumnos;
        private int Codigo;
        private ArrayList Alumnos; // el arraylist especifica su tipo cuando se inserta un elemento por primera vez
        private C_Profesor Profesor;

        public C_Aula()
        {
            Alumnos = new ArrayList(); //Los objetos siempre deben instanciarse con un new
            Profesor = new C_Profesor();
            Profesor.Pedir_Datos();
            Numero_Alumnos = 0;
        }

        public C_Aula(int Codig)
        {
            Codigo = Codig;
            Alumnos = new ArrayList();
            Profesor = new C_Profesor();
            Console.WriteLine("         Profesor");
            Profesor.Pedir_Datos();
            Numero_Alumnos = 0;
        }

        public void Registrar_Alumno()
        {
            
            C_Alumno Alumno = new C_Alumno(); //Creo el alumno que pasare al ArrayList
            Console.WriteLine("         ALUMNO {0}", Numero_Alumnos + 1);
            Alumno.Pedir_Datos();
            Alumnos.Add(Alumno);

            ++Numero_Alumnos;
        }

        public void Mostrar_Datos()
        {
            Console.WriteLine("                         AULA {0}", Codigo);
            Console.WriteLine();
            Console.WriteLine("             PROFESOR");
            Profesor.Mostrar_Datos();

            Console.WriteLine();
            Console.WriteLine();
            if (!(Alumnos.Count == 0))
            {
                Console.WriteLine("             ALUMNOS");
                Console.WriteLine();

                //AMBOS SIRVEN PARA MOSTRAR LOS ELEMENTOS//

                /*for (int i = 0; i < Alumnos.Count; ++i)
                {
                    ((C_Alumno)Alumnos[i]).Mostrar_Datos(); // el type cast sirve para obtener el objeto, ya que la mayoria de metodo regresan 
                                                            // el tipo Object, es como un moldeado
                    Console.WriteLine();
                }*/


                //// foreach recorre todo el container
                ////foreach(tipo identificador in container)
                foreach (C_Alumno i in Alumnos)
                {
                    i.Mostrar_Datos();
                    Console.WriteLine();
                }

                /////////////////////////////////////////
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("NUMERO DE ALUMNOS: {0}", Numero_Alumnos);

            Console.ReadKey();

         
        }

        public void Eliminar_Alumno()
        {
            if (!(Alumnos.Count == 0))
            {
                int Posicion = 0;
                Console.Write("Ingrese la posicion del alumno a eliminar [0,{0}]: ", Alumnos.Count - 1);
                Posicion = Convert.ToInt32(Console.ReadLine());
                Alumnos.RemoveAt(Posicion);
                --Numero_Alumnos;
                Console.Write("REMOVED");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("NO HAY DATOS");
            }
        }

        public void Administrar()
        {
            Console.Clear();
            int Opcion;
            Console.WriteLine("         AULA {0}", Codigo);
            Console.WriteLine("1. Registrar Alumno");
            Console.WriteLine("2. Mostrar Datos");
            Console.WriteLine("3. Eliminar Alumno");
            Console.WriteLine("4. Salir");
            Console.Write("OPCION: ");
            Opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (Opcion)
            {
                case 1: Registrar_Alumno(); break;
                case 2: Mostrar_Datos(); break;
                case 3: break;
                case 4: break;
            }
        }
    }
}
