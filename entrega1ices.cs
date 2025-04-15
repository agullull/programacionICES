using System;

class Program
{
    static void Main()
    {
        string nombre;

        do
        {
            Console.WriteLine("Ingresa el nombre del estudiante: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("No se indicó ningún nombre, ingreselo correctamente: ");

            }

        } while (string.IsNullOrEmpty(nombre));

        int cantidadCalificaciones;

        do
        {
            Console.WriteLine("Indica cuantas calificaciones tiene el estudiante, de 1 a 5: ");
        }

        while (!int.TryParse(Console.ReadLine(), out cantidadCalificaciones) || cantidadCalificaciones < 1 || cantidadCalificaciones > 5);

        double suma = 0;
        int calificacion;

        for (int i = 1; i <= cantidadCalificaciones; i++)
        {
            do
            {
                Console.WriteLine($"Ingresa la calificación {i} (del 1 al 10): ");
            }
            while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 1 || calificacion > 10);

            suma += calificacion;
        }
        double promedio = suma / cantidadCalificaciones;
            string clasificacion;

        if (promedio >= 9)
            clasificacion = "Excelente";
        else if (promedio >= 7 && promedio < 9)
            clasificacion = "Bueno";
        else if (promedio >= 6 && promedio > 7)
            clasificacion = "Regular";
        else
            clasificacion = "Reprobado";

        Console.WriteLine($"Estudiante: {nombre}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Clasificación: {clasificacion}");
    }
}


