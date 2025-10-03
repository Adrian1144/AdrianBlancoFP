namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Soy Adrián");
            MostrarMensajes($"Tengo {CalcularEdad()} años");
            MostrarMensajes($"Tengo {CalcularEdad(2025,2009)}");
        }

        //Módulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la programación modular");
            MostrarMensajes("Estoy siendo llamado desde MostrarMensaje");
        }

        //Módulo 2 - Procedimiento por parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función sin parámetros
        static int CalcularEdad()
        {
            int edad = 2025 - 2009;
            return edad;
        }

        //Módulo 4 - Función con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
