namespace _6.CondicionalMultipleYTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
 Si el día es martes o jueves, se realizará un descuento del 15% por la compra. 
 Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra.
 Si el día es viernes o sábado, se realizará un descuento del 20% por la compra.
 Si es domingo no se realiza descuento.
 Visualizar el día, el descuento y el total a pagar por la compra.

            float valorCompra = 0;
            float descuento = 0;
            char día = ' ';

            Console.WriteLine("Ingrese el valor de la compra:");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: l:lunes, m:martes, x:miércoles, j:jueves, v:viernes, s:sábado, d:domingo");
            día = Convert.ToChar(Console.ReadLine());

            switch (día)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miércoles, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sábado, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es Domingo, descuento: {descuento}, Valor a pagar: {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Debe ingresar un valor válido");
                    break;
            }*/

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas
            entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación
            y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float num1 = 0;
            float num2 = 0;
            char operación = ' ';
            Console.WriteLine("Ingrese el número 1");
            num1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2");
            num2 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operación arimética que desea realizar: s: suma, r:resta, m: multiplicación, d: división");

            operación = Convert.ToChar(Console.ReadLine());

            switch (operación)
            {
                case 's':
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 'r':
                    Console.WriteLine($"La resta es: num1 - num2");
                    break;

                case 'm':
                    Console.WriteLine($"El producto es: {num1 * num2}");
                    break;
                case 'd':
                    Console.WriteLine($"El cociente es: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Ingrese una operación válida");
                    break;

            }
        }
    }
}
