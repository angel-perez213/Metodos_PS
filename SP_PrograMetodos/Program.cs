    using System;

namespace SP_PrograMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa 1
            int num1, num2, suma;

            Console.WriteLine("Ingrese dos números enteros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine($"La suma de {num1} y {num2} es {suma}.");

            // Programa 2
            char[] caracteres = new char[15];

            Console.WriteLine("Ingrese los 15 caracteres: ");

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = Console.ReadKey().KeyChar;
            }

            Console.WriteLine("\nIngrese una letra para buscar en el vector: ");
            char letra = Console.ReadKey().KeyChar;
            int count = 0;

            foreach (char c in caracteres)
            {
                if (c == letra)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nLa letra '{letra}' aparece {count} veces en el vector.");

            // Programa 3
            int[,] calificaciones = new int[30, 6];

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Ingrese las calificaciones del alumno {i + 1}: ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"Asignatura {j + 1}: ");
                    calificaciones[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double[] mediaPorAlumno = new double[30];
            double[] mediaPorAsignatura = new double[6];

            for (int i = 0; i < 30; i++)
            {
                double sum = 0;
                for (int j = 0; j < 6; j++)
                {
                    sum += calificaciones[i, j];
                    mediaPorAsignatura[j] += calificaciones[i, j];
                }
                mediaPorAlumno[i] = sum / 6.0;
            }

            for (int j = 0; j < 6; j++)
            {
                mediaPorAsignatura[j] /= 30.0;
            }

            Console.WriteLine("\nMedia de notas por alumno:");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {mediaPorAlumno[i]}");
            }

            Console.WriteLine("\nMedia de notas por asignatura:");
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine($"Asignatura {j + 1}: {mediaPorAsignatura[j]}");
            }
        }
    }
}
