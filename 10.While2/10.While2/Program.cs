namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita calcular la factorial de un número dado por por el usuario.
              (Ej: 5! = 1*2*3*4*5)*/

            int num = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese el número al cual desea calcular su factorial:");
            num = Convert.ToInt32(Console.ReadLine());

            while (contador <= num)
            {
                acumulador *= contador;
                Console.WriteLine($"C: {contador} - A: {acumulador}");
                contador++;
            }

            Console.WriteLine($"El factorial del número {num} es: {acumulador}");
        }
    }
}
