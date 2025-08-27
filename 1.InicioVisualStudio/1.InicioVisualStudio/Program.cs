using System;

namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaracíón e inicialización de una variable
            string nombre = "Adrián";
            const string iva = "19%";
            Console.Write("Hola, " + nombre + "\n");
            Console.Write("\tBienvenido a la clase de programación");
            nombre = "Fabio";
            Console.Write("\n" + nombre);
            //iva = "20%"; No se puede cambiar el valor de una constante                                                                       

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 202321;
            long dato3 = 44057321298;
            double dato4 = 326.543;
            char dato5 = '&';//Puede almacenar un solo carácter
            bool dato6 = false;//Almacena true o false
            object dato7 = new Program();
        }
    }
}
