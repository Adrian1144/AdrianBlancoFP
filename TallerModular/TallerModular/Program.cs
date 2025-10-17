namespace TallerModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*esarrolla un programa que permita: 
 Ingresar una palabra 
 LLevar la palabra ingresada a un vector de caracteres 
 Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
usuario. 
            bool continuar = true;
            while (continuar)
            {
                string palabra = ObtenerPalabra();
                
                int vocales = ContarVocales(palabra);
                int consonantes = ContarConsonantes(palabra);
                string respuesta = " ";

                Console.WriteLine($"La palabra '{palabra}' tiene:");
                Console.WriteLine($"Vocales: {vocales}");
                Console.WriteLine($"Consonantes: {consonantes}");
                
                Console.WriteLine("¿Desea ingresar otra palabra? (s/n)");
                respuesta = Console.ReadLine();
                continuar = (respuesta == "s");
            }
        }

        static string ObtenerPalabra()
        {
            Console.WriteLine("Ingrese una palabra:");
            return Console.ReadLine();
        }

        static int ContarVocales(string palabra)
        {
            int conteo = 0;
            
            for (int i = 0; i < palabra.Length; i++)
            {
                char caracter = palabra[i];
                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                    caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U')
                {
                    conteo++;
                }
            }
            
            return conteo;
        }
        static int ContarConsonantes(string palabra)
        {
            int conteo = 0;

            for (int i = 0; i < palabra.Length; i++)
            {
                char caracter = palabra[i];

                if ((caracter >= 'a' && caracter <= 'z') || (caracter >= 'A' && caracter <= 'Z'))
                {
                    if (!(caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                          caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U'))
                    {
                        conteo++;
                    }
                }
            }
            return conteo;*/

            /*Crear un programa que permita gestionar una lista de tareas: 
 Agregar tareas. 
 Eliminar tareas 
 Mostrar la lista de tareas.

            string[] tareas = new string[100];
            int numTareas = 0;

            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        numTareas = AgregarTarea(tareas, numTareas, 100);
                        break;
                    case "2":
                        numTareas = EliminarTarea(tareas, numTareas);
                        break;
                    case "3":
                        MostrarTareas(tareas, numTareas);
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Gestor de Tareas");
            Console.WriteLine("1. Agregar una tarea");
            Console.WriteLine("2. Eliminar una tarea");
            Console.WriteLine("3. Mostrar la lista de tareas");
            Console.WriteLine("4. Salir");
        }
        static int AgregarTarea(string[] tareas, int numTareas, int maxTareas)
        {
            Console.WriteLine("Ingrese el nombre de la tarea: ");
            string nuevaTarea = Console.ReadLine();

            if (nuevaTarea != null && nuevaTarea.Length > 0)
            {
                tareas[numTareas] = nuevaTarea;
                numTareas++;
                Console.WriteLine("Tarea agregada exitosamente.");
            }
            else
            {
                Console.WriteLine("La tarea no puede estar vacía.");
            }
            return numTareas;
        }

        static int EliminarTarea(string[] tareas, int numTareas)
        {
            if (numTareas == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
                return numTareas;
            }

            MostrarTareas(tareas, numTareas);
            Console.WriteLine("Ingrese el índice de la tarea a eliminar (empezando en 0): ");
            string input = Console.ReadLine();

            int indice = int.Parse(input);
            if (indice >= 0 && indice < numTareas)
            {
                for (int i = indice; i < numTareas - 1; i++)
                {
                    tareas[i] = tareas[i + 1];
                }
                tareas[numTareas - 1] = null;
                numTareas--;
                Console.WriteLine("Tarea eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            return numTareas;
        }

        static void MostrarTareas(string[] tareas, int numTareas)
        {
            if (numTareas == 0)
            {
                Console.WriteLine("La lista de tareas está vacía.");
            }
            else
            {
                Console.WriteLine("Lista de tareas:");
                for (int i = 0; i < numTareas; i++)
                {
                    Console.WriteLine($"Tarea {i + 1}: {tareas[i]}");
                }
            }
        }*/

            /*Utiliza programación modular para crear un programa que permita: 
     Recorrer una matriz y llenarla con nombres de contactos. 
     Ingresar un nombre y buscarlo en la matriz 
     Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa 
    el usuario 
     Mostrar por pantalla el nombre encontrado, su posición en la matriz (f,c), y el nuevo 
    nombre ingresado.

            int filas = 3;
            int columnas = 3;
            string[,] matriz = new string[filas, columnas];

            LlenarMatriz(matriz);
            Console.Write("Ingresa el nombre a buscar: ");
            string nombreBuscado = Console.ReadLine();
            (bool encontrado, int fila, int columna) resultadoBusqueda = BuscarNombre(matriz, nombreBuscado);

            if (resultadoBusqueda.encontrado)
            {
                Console.Write("Ingresa el nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();
                CambiarNombre(matriz, resultadoBusqueda.fila, resultadoBusqueda.columna, nuevoNombre);
                MostrarResultado(nombreBuscado, resultadoBusqueda.fila, resultadoBusqueda.columna, nuevoNombre);
            }
            else
            {
                Console.WriteLine("El nombre no se encontró en la matriz.");
            }
        }
        static void LlenarMatriz(string[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            Console.WriteLine("Ingresa los nombres de contactos para llenar la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingresa el nombre para la posición [{i}, {j}]: ");
                    matriz[i, j] = Console.ReadLine();
                }
            }

        }
        static (bool encontrado, int fila, int columna) BuscarNombre(string[,] matriz, string nombre)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j].ToLower() == nombre.ToLower())
                    {
                        return (true, i, j);
                    }
                }
            }
            return (false, -1, -1);
        }

        static void CambiarNombre(string[,] matriz, int fila, int columna, string nuevoNombre)
        {
            matriz[fila, columna] = nuevoNombre;
        }
        static void MostrarResultado(string nombreEncontrado, int fila, int columna, string nuevoNombre)
        {
            Console.WriteLine($"El nombre encontrado es '{nombreEncontrado}', en la posición ({fila}, {columna}), y el nuevo nombre es '{nuevoNombre}'.");
        }*/

            /*5. Crear un programa que implemente el juego de tres en raya (triqui o gato), para dos 
jugadores. El programa debe: 
 Dibujar el tablero 
 Permitir realizar movimientos. 
 Verificar ganadores*/


            char[,] tablero = new char[3, 3];
            InicializarTablero(tablero);
            char jugadorActual = 'X';
            bool juegoTerminado = false;
            while (!juegoTerminado)
            {
                DibujarTablero(tablero);
                RealizarMovimiento(tablero, jugadorActual);
                if (VerificarGanador(tablero, jugadorActual))
                {
                    DibujarTablero(tablero);
                    Console.WriteLine($"El jugador {jugadorActual} ha ganado.");
                    juegoTerminado = true;
                }
                else if (VerificarEmpate(tablero))
                {
                    DibujarTablero(tablero);
                    Console.WriteLine("Empate. El tablero está lleno.");
                    juegoTerminado = true;
                }
                else
                {
                    jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                }
            }

            static void InicializarTablero(char[,] tablero)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tablero[i, j] = ' ';
                    }
                }
            }

            static void DibujarTablero(char[,] tablero)
            {
                Console.Clear();
                Console.WriteLine("  0 1 2");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tablero[i, j]);
                        if (j < 2) Console.Write("|");
                    }
                    Console.WriteLine();
                    if (i < 2) Console.WriteLine("  -----");
                }
                Console.WriteLine();
            }

            static void RealizarMovimiento(char[,] tablero, char jugador)
            {
                bool movimientoValido = false;
                while (!movimientoValido)
                {
                    Console.Write($"Jugador {jugador}, ingresa la fila (0-2): ");
                    int fila = int.Parse(Console.ReadLine());
                    Console.Write($"Jugador {jugador}, ingresa la columna (0-2): ");
                    int columna = int.Parse(Console.ReadLine());
                    if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ')
                    {
                        tablero[fila, columna] = jugador;
                        movimientoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Movimiento inválido. Intenta de nuevo.");
                    }
                }
            }

            static bool VerificarGanador(char[,] tablero, char jugador)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador)
                        return true;
                }
                for (int j = 0; j < 3; j++)
                {
                    if (tablero[0, j] == jugador && tablero[1, j] == jugador && tablero[2, j] == jugador)
                        return true;
                }
                if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
                    return true;
                if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
                    return true;
                return false;
            }

            static bool VerificarEmpate(char[,] tablero)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tablero[i, j] == ' ')
                            return false;
                    }
                }
                return true;
            }

        }
    }
}
