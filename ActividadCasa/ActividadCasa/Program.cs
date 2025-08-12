namespace ActividadCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un algoritmo que lea la edad de un usuario, si el usuario
            es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”.*/

            int edad = 0;

            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
        }
    }
}
