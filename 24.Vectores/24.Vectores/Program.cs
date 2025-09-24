namespace _24.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*24. Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un
             arreglo, al final, debe visualizar el promedio de esos números.*/

            float[] numeros = new float[10];
            float suma = 0;
            float promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número {i+1}");
                numeros[i] = float.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            promedio = suma / 10.0f;

            Console.WriteLine("El promedio de los 10 números es igual a: " + promedio);
        }
    }
}
