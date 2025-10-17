namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            BorrarPantalla();
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5)
        }

        //Módulo - Procedimiento que borra lo que hay en la consola
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Módulo - Procedimiento que recibe la matriz que se va a mostrar en pantalla
        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}  |");
                }
                Console.WriteLine();
            }
        }

        //Módulo - Función que recibe la matriz a llenar y la devuelve con múltiplos de 5
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int numero = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        BorrarPantalla();
                        Console.WriteLine("Ingrese su número para almacenar en la matriz");
                        numero = int.Parse(Console.ReadLine());
                    } while (EsMultiploDe5(numero)==false);
                    matriz[i, j] = numero;
                }
            }
            return matriz;
        }

        //Módulo - Función que comprueba si el número es múltiplo de 5
        static bool EsMultiploDe5(int numero)
        {
            if (numero%5==0 && numero != 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: debe digitar un multiplo de 5");
                return false;
            }
        }

        //Módulo - Función que le pregunta al usuario por el número de filas de la matriz y lo devuelve
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        //Módulo - Función que le pregunta al usuario por el número de columnas de la matriz y lo devuelve
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }
    }
}
