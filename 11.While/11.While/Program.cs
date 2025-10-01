namespace _11.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            int contador = 0;
            int suma = 0;
            int n = 0;

            while (n >= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo:");
                n = Convert.ToInt32(Console.ReadLine());

                suma += n;
                contador++;
            }

            Console.WriteLine("La suma de los números ingreados es: " + suma + ".");

        }
    }
}
