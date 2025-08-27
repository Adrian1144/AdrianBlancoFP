using System.ComponentModel.Design;
using System.Diagnostics;

namespace Taller_Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
         numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
         diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
         pantalla los números de menor a mayor.
         Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
         ingresar números diferentes.

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingresar el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el número 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el número 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Se deben ingresar números diferentes");
            }
            else
            {
                if (num1 < num2 && num1 < num3)
                {
                    if (num2 < num3)
                    {
                         Console.WriteLine($"{num1}, {num2}, {num3}");
                    }
                    else Console.WriteLine($"{num1} {num3} {num2}");
                }
                else if (num2 < num1 && num2 < num3)
                {
                    if (num1 < num3)
                    {
                        Console.WriteLine($"{num2},{num1}, {num3}");
                    }
                    else
                    {
                        Console.WriteLine($"{num2}, {num3}, {num1}");
                    }
                }
                else
                {
                    if (num1 < num2)
                    {
                        Console.WriteLine($"{num3}, {num1}, {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"{num3}, {num2}, {num1}");
                    }
                }
            }*/

            /*2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si 
cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
a. Permita ingresar por teclado si el personaje está en estado invencible (True). 
b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. */


            /*El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), 
crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve 
hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado. 
 Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la 
derecha 
 Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha 
 En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra 
dirección”

            char movimiento = ' ';
            Console.WriteLine("Ingrese la dirección a la que se desea mover - d: derecha, i:izquierda");
            movimiento = Convert.ToChar(Console.ReadLine());

            switch (movimiento)
            {
                case 'd':
                    Console.WriteLine("El personaje se mueve hacia la derecha.");
                    break;
                case 'i':
                    Console.WriteLine("El Personaje se mueve hacia la izquierda.");
                    break;
                default:
                    Console.WriteLine("No me puedo mover en otra dirección");
                    break;
            }*/

            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
 Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
(Función Random) 
 Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
ninguna acción”. 
 Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
carácter que se ingrese: 
o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”*/

            /* int vidas;
             Random rnd = new Random();
             vidas = rnd.Next(0, 5);
             Console.WriteLine($"Número de vidas:{vidas}");

             if (vidas > 0)
             {
                 char acción = ' ';

                 Console.WriteLine("El personaje puede realizar acciones. Ingrese la acción deseada: c: disparar, x: hablar con la rana, t: entrar en modo turbo, i: volverse invencible");

                 acción = Convert.ToChar(Console.ReadLine());
                 switch (acción)
                 {
                     case 'c':
                         Console.WriteLine("El personaje está disparando");
                         break;
                     case 'x':
                         Console.WriteLine("El personaje está hablando con la rana");
                         break;
                     case 't':
                         Console.WriteLine("El personaje está en modo turbo");
                         break;
                     case 'i':
                         Console.WriteLine("El personaje es invencible");
                         break;
                     default:
                         Console.WriteLine("Ingrese una acción válida");
                         break;
                 }
             }
             else
             {
                 Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción.");
             }*/


            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
a.Permita ingresar por teclado si el personaje está en estado invencible(True).
b.La cantidad de munición que tiene el personaje en el momento será calculada por el
sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
Ejemplo:
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
            Console.WriteLine(numero);
            c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
no hacer nada.*/

            Random rnd = new Random();
            int munición = rnd.Next(1, 10);

            Console.WriteLine($"Munición disponible: {munición}");

            Console.WriteLine("¿El personaje está en estado invencible? (True/False)");
            bool invencible = bool.Parse(Console.ReadLine());

            if (invencible && munición >= 1 && munición <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }
        }
    }
}
