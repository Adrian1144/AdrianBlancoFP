using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace ParcialCondicionalesAdrian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa en C# que permita determinar el elemento zodiacal de una persona, en función de su mes de nacimiento y signo zodiacal (70%).

El programa debe:
Solicitar al usuario que ingrese el mes de nacimiento (por ejemplo: "marzo").
Solicitar el signo zodiacal de la persona (por ejemplo: "aries").
Analizar la información ingresada y determinar a qué elemento pertenece la persona, según las siguientes condiciones:
Elemento: Fuego
Mostrar el mensaje “El elemento de la persona es Fuego” si:
El mes de nacimiento es: marzo, abril, julio, agosto, noviembre o diciembre,
Y
El signo zodiacal es: Aries, Leo o Sagitario.
Elemento: Tierra
Mostrar el mensaje “El elemento de la persona es Tierra” si:
El mes de nacimiento es: abril, mayo, agosto, septiembre, diciembre o enero,
Y
El signo zodiacal es: Tauro, Virgo o Capricornio.
Elemento: Aire
Mostrar el mensaje “El elemento de la persona es Aire” si:
El mes de nacimiento es: mayo, junio, septiembre, octubre, enero o febrero,
Y
El signo zodiacal es: Géminis, Libra o Acuario.
Elemento: Agua
Mostrar el mensaje “El elemento de la persona es Agua” si:
El mes de nacimiento es: marzo, junio, julio, octubre, noviembre, febrero,Y

El signo zodiacal es: Cáncer, Escorpión o Piscis.
Nota importante:
En caso de que no se cumpla ninguna condición, no se debe mostrar ningún mensaje o se puede indicar que los datos no coinciden con ninguna categoría.
2.  Crear los casos de prueba, y realizar la prueba de escritorio. (30%).*/


            char mes = ' ';
            char signo = ' ';

            Console.WriteLine("Ingrese su mes de nacimiento - e: enero, f: febrero, m: marzo, a: abril, y: mayo, j: junio, x: julio, g: agosto, s: septiembre, o: octubre, n: noviembre, d: diciembre");
            mes = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese su signo zodiacal - a: aries, l: leo, s: sagitario, t: tauro, v: virgo, c: capricornio, g: geminis, i: libra, o: acuario, n: cancer, e: escorpion, p: piscis");
            signo = Convert.ToChar(Console.ReadLine());

            if (mes == 'm' || mes == 'a' || mes == 'x' || mes == 'g' || mes == 'n' || mes == 'd' && signo == 'a' || signo == 'l' || signo == 's')
            {
                Console.WriteLine("El elemento de la persona es Fuego");
            }
            else if (mes == 's' || mes == 'd' || mes == 'g' || mes == 'e' || mes == 'y' || mes == 'a' || signo == 't' || signo == 'v' || signo == 'c')
            {
                Console.WriteLine("El elemento de la persona es Tierra");
            }
            else if (mes == 'y' || mes == 'j' || mes == 's' || mes == 'o' || mes == 'e' || mes == 'f' && signo == 'g' || signo == 'i' || signo == 'o')
            {
                Console.WriteLine("El elemento de la persona es Aire");
            }
            else if (mes == 'm' || mes == 'j' || mes == 'x' || mes == 'o' || mes == 'n' || mes == 'f' && signo == 'n' || signo == 'e' || signo == 'p')
            {
                Console.WriteLine("El elemento de la persona es Agua");
            }
        }
    }
}
