namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
El número de partidos perdidos  
El número de partidos empatados  
El número de partidos ganados  
El porcentaje de partidos perdidos  
El porcentaje de partidos empatados  
El porcentaje de partidos ganados */

            int contador = 0;
            int totalPartidos = 5;
            char resultado = ' ';
            int partidosGanados = 0;
            int partidosEmpatados = 0;
            int partidosPerdidos = 0;
            float porcentajeGanados = 0;
            float porcentajeEmpatados = 0;
            float porcentajePerdidos = 0;
            do
            {
                Console.WriteLine($"Ingrese el resultado del partido {contador + 1}. G = ganado, E: empatado, P: perdido");
                resultado = char.Parse(Console.ReadLine());

                if (resultado == 'g' || resultado == 'G')
                {
                    partidosGanados++;
                }
                else if (resultado == 'e' || resultado == 'E')
                {
                    partidosEmpatados++;
                }
                else if (resultado == 'p' || resultado == 'P')
                {
                    partidosPerdidos++;
                }
                else
                {
                    Console.WriteLine("Ingrese un resultado válido.");
                }

                contador++;

            } while (contador < totalPartidos);

            porcentajeGanados = (partidosGanados * 100) / totalPartidos;
            porcentajeEmpatados = (partidosEmpatados * 100) / totalPartidos;
            porcentajePerdidos = (partidosPerdidos * 100) / totalPartidos;

            Console.WriteLine("Resultados del año:");
            Console.WriteLine($"Partidos ganados: {partidosGanados}, representando un {porcentajeGanados}% de los partidos totales.");
            Console.WriteLine($"Partidos empatados: {partidosEmpatados}, representando un {porcentajeEmpatados}% de los partidos totales.");
            Console.WriteLine($"Partidos perdidos: {partidosPerdidos}, representando un {porcentajePerdidos}% de los partidos totales.");
        }
    }
}
