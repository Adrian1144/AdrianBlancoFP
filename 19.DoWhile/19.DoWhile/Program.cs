using System.ComponentModel;

namespace _19.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son
            mujeres, además se desea saber cuántos son mayores de edad y cuántos no.  */

            int cantidadEstudiantes = 0;
            int edad = 0;
            int genero = 0;
            int cantidadHombres = 0;
            int cantidadMujeres = 0;
            int cantidadMayores = 0;
            int cantidadMenores = 0;
            int cantidad = 100;
            do
            {
                Console.WriteLine($"Estudiante {cantidadEstudiantes + 1}: ");
                Console.WriteLine("Ingrese su edad:");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su género");
                Console.WriteLine("1: Hombre, 2: Mujer");
                genero = Convert.ToInt32(Console.ReadLine());

                if (genero == 1)
                {
                    cantidadHombres++;
                }
                else
                {
                    cantidadMujeres++;
                }

                if (edad >= 18)
                {
                    cantidadMayores++;
                }
                else
                {
                    cantidadMenores++;
                }

                cantidadEstudiantes++;

            } while (cantidadEstudiantes < cantidad);

            Console.WriteLine($"De los 100 estudiantes, {cantidadHombres} son hombres, {cantidadMujeres} son mujeres, {cantidadMayores} son mayores de edad y {cantidadMenores} son menores de edad.");
        }
    }
}
