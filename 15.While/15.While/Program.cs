namespace _15.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15. Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al 
            final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.*/

            int mes = 1;
            float deposito = 0f;
            float ahorroTotal = 0f;

            while(mes<=12)
            {
                Console.WriteLine("Ingrese la cantidad de dinero que depositará este mes:");
                deposito = float.Parse(Console.ReadLine());

                ahorroTotal += deposito;

                Console.WriteLine("El total ahorrado hasta el mes " + mes + " es " + ahorroTotal);

                mes++;
            } 
            Console.WriteLine("El total ahorrado en todo el año es " + ahorroTotal);
        }
    }
}
