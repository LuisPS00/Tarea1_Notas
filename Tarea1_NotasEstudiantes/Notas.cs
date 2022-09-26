using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_NotasEstudiantes
{
    class Notas
    {
        static string[] alumnos = new string[5];
        static float[] notas = new float[5];
        static int indice = 0;
        static float resultado = 0;
        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Agregar notas y estudiantes.");
                Console.WriteLine("2- Calcular promedio de notas.");
                Console.WriteLine("3- Calcular nota más alta.");
                Console.WriteLine("4- Total aprobados y reprobados.");
                Console.WriteLine("5- Ver lista de alumnos.");
                Console.WriteLine("6- Finalizar. ");
                Console.Write("Digite una opción ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: AgregarNotas(); break;
                    case 2:
                        Console.WriteLine("El promedio de las notas es {0}", promedio());
                        Console.WriteLine("__________________________________"); break;
                    case 3: NotaAlta(); break;
                    case 4: AprobadosReprobados(); break;
                    case 5: ListaAlumnos(); break;
                    case 6: break;
                    default:
                        break;
                }
            }
            while (opcion != 6);
        }
        public static void AgregarNotas()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Digite el nombre del alumno:");
                alumnos[indice] = Console.ReadLine();
                Console.WriteLine("Digite la nota del alumno:");
                notas[indice] = Convert.ToInt32(Console.ReadLine());
                indice++;
                Console.WriteLine("¿Desea continuar 1- Sí ó 2- No?");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion != 2);

        }
        public float promedio()
        {
            resultado = 0;
            for (int i = 0; i < indice; i++)
            {
                resultado += notas[i];
            }


            resultado /= indice;

            return resultado;


        }
        public void NotaAlta()
        {
            Array.Sort(notas);//Para ordenar lista.
            Array.Reverse(notas);//Para dar vuelta.

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("La nota mayor es: {0} ", notas[i]);
            }
            Console.WriteLine("__________________________________");
        }
        public void AprobadosReprobados()
        {
            int MayoraPromedio, MenoraPromedio;
            MayoraPromedio = 0;
            MenoraPromedio = 0;
            Console.WriteLine("El promedio es: " + resultado);
            Console.WriteLine("__________________________________");
            for (int i = 0; i < indice; i++)
            {
               
                if (notas[i] >= resultado)
                {

                    Console.WriteLine($"Nota mayor a promedio: {notas[i]}");
                    MayoraPromedio++;

                }

                else
                {
                    Console.WriteLine($"Nota menor a promedio: {notas[i]}");
                    MenoraPromedio++;
                }
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("El total de notas mayor a promedio es: " + MayoraPromedio);
            Console.WriteLine("El total de notas menor a promedio  es: " + MenoraPromedio);
            Console.WriteLine("__________________________________");
        }
        public void ListaAlumnos()
        {
            Console.WriteLine("Estudiantes:          Notas:");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine($"{alumnos[i]}                 {notas[i]}");

            }
            Console.WriteLine("____________________________");
        }
    }
}
