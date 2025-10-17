using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
pantalla la suma de los elementos de cada columna.
            int[,] matriz = new int[10, 20];
            int[] sumaColumnas = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Matriz generada");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = rnd.Next(1, 101);
                    Console.WriteLine($"Valores de la posición [{i}, {j}]");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    sumaColumnas[j] += matriz[i, j];
                }
            }

            Console.WriteLine("Matriz resultado de la suma:");
            for (int j = 0; j < sumaColumnas.GetLength(0); j++)
            {
                Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
            }*/

            /*Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
matriz con el intercambio de filas.
            int n = 0;
            int m = 0;

            Console.Write("Ingrese el número de filas: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];
            char[,] matrizIntercambiada = new char[n, m];

            Console.WriteLine("Ingrese los valores para la matriz");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Posición [{i}, {j}]");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrizIntercambiada[i, j] = matriz[i, j];
                }
            }

            for (int j = 0; j < m; j++)
            {
                char intercambio = matrizIntercambiada[0, j];
                matrizIntercambiada[0, j] = matrizIntercambiada[n - 1, j];
                matrizIntercambiada[n - 1, j] = intercambio;
            }

            Console.WriteLine("Matriz original");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{matriz[i, j]}  |");
                }
            }

            Console.WriteLine("Matriz con filas intercambiadas");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{matrizIntercambiada[i, j]}  |");
                }
            }*/

            /*. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
5x5 llena de números aleatorios. 
El algoritmo debe permitir: 
 Usa la función Random para generar los números aleatorios. 
 Crea un arreglo adicional para almacenar la frecuencia de cada número. 
 Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número

            Random rnd = new Random();
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(1, 11);
                }
            }

            int[] frecuencia = new int[11];
            int numero = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    numero = matriz[i, j];
                    frecuencia[numero]++;
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{matriz[i, j]}  |");
                }
            }

            // Paso 6: Mostrar el arreglo de frecuencias
            Console.WriteLine("Frecuencias de los números del 1 al 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Número " + i + ": " + frecuencia[i] + " veces");
            }*/

            /*Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
posición de una "X". 
El algoritmo debe permitir: 
 Usar la función Random para colocar las "X" en la matriz. 
 Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
 Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz.

            Random rnd = new Random();
            char[,] tablero = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = ' ';
                }
            }

            int posicionesAleatorias = 0;
            while (posicionesAleatorias < 3)
            {
                int fila = rnd.Next(0, 5);
                int columna = rnd.Next(0, 5);

                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                    posicionesAleatorias++;
                }
            }

            Console.WriteLine("Tablero generado con 3 'X' en posiciones aleatorias. Intente adivinar.");

            int aciertos = 0;
            string[] posicionesAdivinadas = new string[3];
            int intentos = 3;

            for (int i = 1; i <= intentos; i++)
            {
                Console.WriteLine($"Intento {i} de {intentos}:");
                int filaUsuario = 0;
                bool filaValida = false;
                string entradaFila = " ";

                while (!filaValida)
                {
                    Console.WriteLine("Ingrese la fila (1-5):");
                    entradaFila = Console.ReadLine();
                    filaUsuario = int.Parse(entradaFila);

                    if (filaUsuario >= 1 && filaUsuario <= 5)
                    {
                        filaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Debe ser un número entre 1 y 5.");
                    }
                }

                int columnaUsuario = 0;
                bool columnaValida = false;
                string entradaColumna = " ";

                while (!columnaValida)
                {
                    Console.WriteLine("Ingrese la columna (1-5): ");
                    entradaColumna = Console.ReadLine();
                    columnaUsuario = int.Parse(entradaColumna);

                    if (columnaUsuario >= 1 && columnaUsuario <= 5)
                    {
                        columnaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Debe ser un número entre 1 y 5.");
                    }
                }

                int posicionFila = filaUsuario - 1;
                int posicionColumna = columnaUsuario - 1;

                if (tablero[posicionFila, posicionColumna] == 'X')
                {
                    Console.WriteLine("Acertaste: Hay una 'X' en esa posición.");
                    aciertos++;
                    posicionesAdivinadas[i - 1] = $"Fila {filaUsuario}, Columna {columnaUsuario}";
                }
                else
                {
                    Console.WriteLine("Fallaste: No hay una 'X' en esa posición.");
                }
            }

            if (aciertos > 0)
            {
                Console.WriteLine("Has acertado en " + aciertos + " intento(s).");
                Console.WriteLine("Posiciones de las 'X' que adivinaste:");

                for (int i = 0; i < aciertos; i++)
                {
                    Console.WriteLine(posicionesAdivinadas[i]);
                }

                Console.WriteLine("Tablero completo:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error: No has acertado en ningún intento.");
                Console.WriteLine("Aquí está el tablero completo:");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j]);
                    }
                    Console.WriteLine();
                }
            }*/

            /*Desarrollar un programa e C# que: 
 Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz 
de enteros 
 Cargue los datos de la matriz ingresándolos por teclado  
 Muestre la matriz ingresada 
 Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser 
ahora la columna 1. 
 Mostrar la nueva matriz

            int filas = 0;
            int columnas = 0;

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            columnas = int.Parse(Console.ReadLine());

            int[,] matrizOriginal = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Elemento [{i + 1},{j + 1}]: ");
                    matrizOriginal[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"{matrizOriginal[i, j]}  |");
                }
            }

            int[,] matrizEnReversa = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizEnReversa[j, i] = matrizOriginal[i, j];
                }
            }

            Console.WriteLine("Matriz en reversa (filas convertidas en columnas):");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.WriteLine($"{matrizEnReversa[i, j]}  |");
                }
            }*/

            /*Crear una aplicación en C# que permita realizar las siguientes acciones: 
 Crear una matriz de n filas por m columnas 
 Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
 Mostrar la matriz generada 
 Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
número 3, y cuál de los tres números fue repetido más veces.*/

            int filas = 0;
            int columnas = 0;
            Random rnd = new Random();

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 4);
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"{matriz[i, j]}  |");
                }
            }

            int conteo1 = 0;
            int conteo2 = 0;
            int conteo3 = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] == 1)
                    {
                        conteo1++;
                    }
                    else if (matriz[i, j] == 2)
                    {
                        conteo2++;
                    }
                    else if (matriz[i, j] == 3)
                    {
                        conteo3++;
                    }
                }
            }

            Console.WriteLine("\nConteo de números:");
            Console.WriteLine($"El número 1 fue ingresado {conteo1} veces.");
            Console.WriteLine($"El número 2 fue ingresado {conteo2} veces.");
            Console.WriteLine($"El número 3 fue ingresado {conteo3} veces.");

            int maxConteo = conteo1;
            string Moda = "1";

            if (conteo2 > maxConteo)
            {
                maxConteo = conteo2;
                Moda = "2";
            }
            else if (conteo2 == maxConteo)
            {
                Moda += " y 2";
            }

            if (conteo3 > maxConteo)
            {
                maxConteo = conteo3;
                Moda = "3";
            }
            else if (conteo3 == maxConteo)
            {
                Moda += " y 3";
            }

            Console.WriteLine($"El número más repetido es {Moda} con {maxConteo} repeticiones.");
        }
    }
}
