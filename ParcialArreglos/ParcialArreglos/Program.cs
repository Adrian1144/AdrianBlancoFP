namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Construcción y validación de un tablero de ajedrez
Se solicita desarrollar un programa que permita al usuario construir manualmente un tablero de ajedrez estándar de 8x8 casillas, validando cada ficha ingresada y mostrando el tablero final correctamente armado.
________________________________________
Requisitos:
1.	Representación del tablero:
El tablero debe ser almacenado en una matriz bidimensional (8x8) de caracteres.
2.	Fichas válidas:
o	Rey                    (R)
o	Dama/Reina  (D)
o	Torre                  (T)
o	Alfil                     (A)
o	Caballo             (C)
o	Peón                   (p)
o	Casilla vacía   (X)
3.	Ingreso y validación:
El programa solicitará al usuario ingresar, posición por posición (de izquierda a derecha, de arriba hacia abajo), la ficha correspondiente para cada casilla.
o	Para cada posición, la ficha ingresada debe coincidir con la ficha correcta según la configuración estándar del tablero.
o	Si el valor ingresado no es correcto, el programa debe mostrar un mensaje de error y solicitar nuevamente la entrada hasta que sea válida.
o	El programa debe garantizar que no se permita ingresar fichas inválidas ni colocar fichas en posiciones incorrectas.
4.	Configuración inicial del tablero:
Para validar la entrada del usuario, el programa deberá utilizar la siguiente tabla como referencia, donde cada fila representa una fila del tablero (0 a 7) y cada columna una posición dentro de la fila (0 a 7):

T 	C 	A 	D 	R 	A 	C 	T 
p 	p 	p 	p 	p 	p 	p 	p 
X 	X 	X 	X 	X 	X 	X 	X 
X 	X 	X 	X 	X 	X 	X 	X 
X 	X 	X 	X 	X 	X 	X 	X 
X 	X 	X 	X 	X 	X 	X 	X 
p 	p 	p 	p 	p 	p 	p 	p 
T 	C 	A 	D 	R 	A 	C 	T 

5.	Salida:
Al finalizar, el programa debe imprimir el tablero completo en un formato legible, mostrando las fichas en sus posiciones correspondientes.
*/
            char[,] tablero = new char[8, 8];
            char[,] tableroReferencia = new char[8, 8];
            char[] piezasMayores = { 'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T' };

            for (int i = 0; i < 8; i++)
            {
                tableroReferencia[0, i] = piezasMayores[i];
                tableroReferencia[7, i] = piezasMayores[i];
            }

            for (int i = 0;i < 8; i++)
            {
                tableroReferencia[1, i] = 'p';
                tableroReferencia[6, i] = 'p';
            }

            for (int i = 2; i <= 5; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    tableroReferencia[i, j] = 'x';
                }
            }

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0;j < 8; j++)
                {
                    char caracter = tableroReferencia[i, j];
                    char entrada = ' ';
                    string textoIngresado = " ";

                    while (true)
                    {
                        Console.WriteLine($"Ingrese la ficha para la fila {i+1}, columna {j+1}");
                        textoIngresado = Console.ReadLine();

                        if( textoIngresado.Length > 0)
                        {
                            entrada = textoIngresado[0];

                            if (entrada == caracter)
                            {
                                tablero[i, j] = entrada;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Error: la ficha debe ser '{caracter}' para esta posición, intente de nuevo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada ínválida, intente de nuevo");
                        }
                    }
                }
            }

            Console.WriteLine("Tablero final:");
            for(int i = 0;i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 7)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}