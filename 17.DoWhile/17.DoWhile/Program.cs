namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que genera y suma los primeros 5 números enteros

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador=acumulador+contador;
            } while (contador<5);
            
            Console.WriteLine("La suma de los cinco primeros números enteros es: " + acumulador);

            17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar
            desde el 1 hasta el 10. Y asi sucesivamente hasta que el usuario ya no desee continuar
            generando tablas de multiplicar*/

            int contador = 1;
            int num = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un número para generar su correspondiente tabla de multiplicar");
                num = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{num} x {contador} = {num * contador}");
                    contador++;
                } while (contador <= 10);
                contador = 1;

                Console.WriteLine("¿Desea generar una nueva tabla de multiplicar? s: sí, n: no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
        }
    }
}
