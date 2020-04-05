using System;

namespace Entrega_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rut;
            string name;
            string lastname;
            string nation;
            string date;
            string altura;
            int hacer;
            int trabajador;

            Console.WriteLine("¿Que quiere hacer?");
            Console.WriteLine("1) Crear un trabajador");
            Console.WriteLine("2) Crear un producto");
            Console.WriteLine("3) Comprar");
            Console.WriteLine("4) Salir");
            Console.WriteLine("¿Que quiere hacer? ");
            hacer = Convert.ToInt32(Console.ReadLine());
            while (hacer == 1 || hacer == 2 || hacer == 3)
            {
                if (hacer == 1)
                {
                    Console.WriteLine("1) Jefe");
                    Console.WriteLine("2) Empleados");
                    Console.WriteLine("3) Auxiliares");
                    Console.WriteLine("4) Supervisores");
                    Console.WriteLine("¿Que trabajador desea crear?");
                    trabajador = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese datos del trabajador");
                    Console.WriteLine("Ingerese su rut: ");
                    rut = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine("apellido: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("nacion: ");
                    nation = Console.ReadLine();
                    Console.WriteLine("nacimiento: ");
                    date = Console.ReadLine();
                    Console.WriteLine("Altura:");
                    altura = Console.ReadLine();
                    if (trabajador == 1)
                    {


                    }
                    Persona p1 = new Persona(rut, name, lastname, nation, date, altura);
                    Console.WriteLine(p1.retornaNombre());

                }
            }
            Console.WriteLine("Ingerese su rut: ");
            rut = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("apellido: ");
            lastname = Console.ReadLine();
            Console.WriteLine("nacion: ");
            nation = Console.ReadLine();
            Console.WriteLine("nacimiento: ");
            date = Console.ReadLine();
            Console.WriteLine("Altura:");
            altura = Console.ReadLine();

            Persona diego = new Persona(rut,name,lastname,nation,date,altura);
            Console.WriteLine(diego.retornaNombre());
        }
    }
}
