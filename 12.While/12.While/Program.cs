namespace _12.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.

            int suma = 0;
            int numero = 1;

            while (numero <= 99)
            {
                suma += numero;
                numero += 2;
            }
            Console.WriteLine("La suma de todos los números impares hasta 99 es: " + suma);
        }
    }
}
