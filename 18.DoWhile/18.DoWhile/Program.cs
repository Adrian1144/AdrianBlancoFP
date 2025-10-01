namespace _18.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            string nombre = " ";
            int numCuenta = 0;
            float saldo = 0f;
            float sumaSaldos = 0f;
            float promedioSaldos = 0f;
            int numeroPersonas = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su número de cuenta");
                numCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo");
                saldo = float.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine("El usuario " + nombre + " con número de cuenta " + numCuenta + " y saldo de " + saldo + ", es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine("El usuario " + nombre + " con número de cuenta " + numCuenta + " y saldo de " + saldo + ", NO es apto para el crédito.");
                }

                sumaSaldos += saldo;
                numeroPersonas++;

                Console.WriteLine("¿Desea registrar más usuarios? s: sí, n: no");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');

            promedioSaldos = sumaSaldos / numeroPersonas;

            Console.WriteLine("El número de usuarios registrados fueron " + numeroPersonas + ", con promedio de saldos de " + promedioSaldos + ".");
        }
    }
}
