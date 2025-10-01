namespace _16.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y
            el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.*/

            Random rnd = new Random();
            int numeroRandom = rnd.Next(0, 10);
            int numero = 0;

            while (numero != numeroRandom)
            {
                Console.WriteLine("Ingresa tu intento para adivinar el número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < numeroRandom)
                {
                    Console.WriteLine("Demasiado bajo.");
                }
                else if (numero > numeroRandom)
                {
                    Console.WriteLine("Demasiado alto.");
                }
            }
            Console.WriteLine("Correcto. Has adivinado el número.");
        }
    }
}
