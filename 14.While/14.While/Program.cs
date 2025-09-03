namespace _14.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
El algoritmo debe escribir en pantalla: 
La cantidad de números introducidos que son mayores que 0 
La cantidad de números introducidos menores que 0  
La cantidad de números iguales a 0. */

            int contador = 0;
            int num = 0;
            int cantidadNum = 0;
            int positivos = 0;
            int ceros = 0;
            int negativos = 0;

            Console.WriteLine("Indique la cantidad de números que desea ingresar: ");
            cantidadNum = Convert.ToInt32(Console.ReadLine());

            while (contador < cantidadNum)
            {
                Console.WriteLine($"Ingrese el número # {contador + 1}");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    positivos++;
                }
                else if (num < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }

                contador = contador + 1;
            }
            Console.WriteLine($"La cantidad de números introducidos que son mayores que 0: {positivos}");
            Console.WriteLine($"La cantidad de números introducidos menores que 0: {negativos}");
            Console.WriteLine($"La cantidad de números iguales a 0: {ceros}");
        }
    }
}
