namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. 
Requisitos del programa: 
Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas. 
Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3). 
Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices. 
Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas). */

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            Console.WriteLine("Ingrese los elementos de la primera matriz con 2 filas y 3 columnas:");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($"Elementos almacenados en la posición [{i},{j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los elementos de la segunda matriz con 2 filas y 3 columnas:");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz resultado de la suma:");
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.WriteLine($"{suma[i, j]}      |");
                }
            }
        }
    }
}
