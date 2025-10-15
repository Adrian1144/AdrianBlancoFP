namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
encuentre y muestre el valor máximo y mínimo de los números ingresados.

            int[] numeros = new int[5];
            int valorMaximo = 0;
            int valorMinimo = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese un número entero para la posición {i + 1} del vector.");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            valorMaximo = numeros[0];
            valorMinimo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > valorMaximo)
                {
                    valorMaximo = numeros[i];
                }

                if (numeros[i] < valorMinimo)
                {
                    valorMinimo = numeros[i];
                }
            }

            Console.WriteLine($"El valor máximo ingresado fue {valorMaximo}");
            Console.WriteLine($"El valor mínimo ingresado fue {valorMinimo}");*/

            /*Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
orden de los elementos del vector. Se deben mostrar lo dos vectores.

            int cantidad = 0;

            Console.WriteLine("¿Cuántos caracteres desea ingresar?");
            cantidad = int.Parse(Console.ReadLine());

            char[] caracteres = new char[cantidad];
            char[] vectorInvertido = new char[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese un caracter para la posición {i + 1} del vector");
                caracteres[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad; i++)
            {
                vectorInvertido[i] = caracteres[cantidad - 1 - i];
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Caracter para la posición {i + 1} del vector original: {caracteres[i]}");
            }

            Console.WriteLine("");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Caracter para la posición {i + 1} del vector invertido: {vectorInvertido[i]}");
            }*/

            /*Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 
0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el 
número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el 
vector resaltando el número en un color diferente. Si no se encuentra el número, se debe 
devolver y mostrar -1. */

            /*Random rnd = new Random();
            int[] vector = new int[20];
            int numeroABuscar = 0;
            int posicion = -1;

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(0, 51);
            }

            Console.WriteLine("Ingrese el número a buscar en el vector generado");
            numeroABuscar = int.Parse(Console.ReadLine());

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numeroABuscar)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"Número encontrado en la posición {posicion + 1}");
            }
            else
            {
                Console.WriteLine("El número no se encontró. -1");
            }*/

            /*Escribir un algoritmo que permita:  
 Crear un vector con rango impar, exceptuando el 1, 
 Pedirle al usuario un número entero y almacenarlo en la mitad del vector. 
 Llenar la primera mitad del vector, con los números menores al número almacenado 
en la posición de la mitad. 
 Llenar la parte inicial del vector, con los números menores al número almacenado en 
la posición de la mitad. 
 Llenar la parte final del vector, con los números mayores al número almacenado en la 
posición de la mitad. 
 Mostrar el vector en pantalla.

            int tamañoVector = 0;
            do
            {
                Console.WriteLine("Ingrese el tamaño del vector (número impar mayor que 1):");
                tamañoVector = int.Parse(Console.ReadLine());
                if (tamañoVector % 2 == 0 || tamañoVector <= 1)
                {
                    Console.WriteLine("Error: Debe ser impar y mayor que 1. Intente de nuevo.");
                }
            } while (tamañoVector % 2 == 0 || tamañoVector <= 1);
            
            int[] vector = new int[tamañoVector];

            int mitad = (tamañoVector - 1) / 2;

            Console.WriteLine("Ingrese un número entero para almacenar en la mitad del vector: ");
            int numeroCentral = int.Parse(Console.ReadLine());

            vector[mitad] = numeroCentral;
            Random rnd = new Random();
            int rangoMax = 100;

            for (int i = 0; i < mitad; i++)
            {
                int maxMenor = numeroCentral - 1;
                if (maxMenor < 0)
                {
                    maxMenor = 0;
                }
                vector[i] = rnd.Next(0, maxMenor + 1);
            }

            for (int i = mitad + 1; i < tamañoVector; i++)
            {
                int minMayor = numeroCentral + 1;
                vector[i] = rnd.Next(minMayor, rangoMax + 1);
            }
            // Mostrar el vector
            Console.WriteLine("Vector resultante:");
            for (int i = 0; i < tamañoVector; i++)
            {
                Console.WriteLine(vector[i]);
            }*/


            /*. Escribir un algoritmo que permita:  
 Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario. 
 LLenar el primer vector con números aleatorios entre 0 y su rango+1 
 LLenar el segundo vector con números aleatorios entre rango y rango*2 
 Combinar los dos vectores en uno solo. 
 Mostrar en pantalla los tres vectores */

            int tamaño1 = 0;
            int tamaño2 = 0;

            Console.WriteLine("Ingrese el tamaño del primer vector:");
            tamaño1 = int.Parse(Console.ReadLine());
            while (tamaño1 <= 0)
            {
                Console.WriteLine("El tamaño debe ser positivo. Intente de nuevo:");
                tamaño1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el tamaño del segundo vector:");
            tamaño2 = int.Parse(Console.ReadLine());
            while (tamaño2 <= 0)
            {
                Console.WriteLine("El tamaño debe ser positivo. Intente de nuevo:");
                tamaño2 = int.Parse(Console.ReadLine());
            }

            int[] vector1 = new int[tamaño1];
            Random rnd = new Random();
            for(int i = 0; i < tamaño1; i++)
            {
                vector1[i] = rnd.Next(0, tamaño1 + 2);
            }

            int[] vector2 = new int[tamaño2];
            for(int i = 0; i < tamaño2; i++)
            {
                vector2[i] = rnd.Next(0, tamaño2 * 2 + 1);
            }

            int[] vectorCombinado = new int[tamaño1 + tamaño2];
            for (int i = 0; i < tamaño1; i++)
            {
                vectorCombinado[i] = vector1[i];
            }
            for (int i = 0; i < tamaño2; i++)
            {
                vectorCombinado[tamaño1 + i] = vector2[i];
            }

            Console.WriteLine("Primer vector:");
            for (int i = 0; i < tamaño1; i++)
            {
                Console.WriteLine(vector1[i] + " ");
            }

            Console.WriteLine("Segundo vector:");
            for (int i = 0; i < tamaño2; i++)
            {
                Console.WriteLine(vector2[i] + " ");
            }

            Console.WriteLine("Vector combinado:");
            for (int i = 0; i < tamaño1 + tamaño2; i++)
            {
                Console.WriteLine(vectorCombinado[i]);
            }
        }
    }
}
