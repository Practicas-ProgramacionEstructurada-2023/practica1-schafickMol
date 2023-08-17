using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // Declaracion de variables
            string? nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera;
            string? facultad;
            int ciclo;


            Console.WriteLine("\n************Practica 1 - Programacion estructurada************");
            Console.WriteLine("ingrese su nombre completo: "); //obetener datos
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese su edad: ");//obetener datos
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese su direccion: ");//obetener datos
            direccion = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese su numero de telefono: ");//obetener datos
            telefono = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el nombre de la universidad donde estudia: ");//obetener datos
            universidad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese el nombre de su carrera: ");//obetener datos
            carrera = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese el nombre de su facultad: ");//obetener datos
            facultad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese el ciclo que esta cursando: ");//obetener datos
            ciclo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su nombre es: "+ nombre);
            Console.WriteLine("Su edad es: "+ edad);
            Console.WriteLine("Su direccion es: "+ direccion);
            Console.WriteLine("Su telefono es: "+ telefono);
            Console.WriteLine("La universidad donde estudia es: "+ universidad);
            Console.WriteLine("Su carrera es: "+ carrera);
            Console.WriteLine("Su facultad es: "+ facultad);
            Console.WriteLine("Su ciclo cursando es: "+ ciclo);
        }
    }
}