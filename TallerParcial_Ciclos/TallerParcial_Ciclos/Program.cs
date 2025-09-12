using System.Diagnostics.CodeAnalysis;

namespace TallerParcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float acumulador = 0;
            string respuesta = "";
            float nota = 0;
            float promedio = 0;

            do
            {
                Console.WriteLine($"Ingrese la calificación {contador + 1}");
                nota = float.Parse(Console.ReadLine());

                acumulador += nota;
                contador++;

                Console.WriteLine("¿Desea ingresar otra nota? s: sí, n: no");
                respuesta = Console.ReadLine();

            } while (respuesta == "s");

            if (contador > 0)
            {
                promedio = acumulador / contador;
                Console.WriteLine($"El promedio de las calificacionjes es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones");
            }
        }
    }
}
