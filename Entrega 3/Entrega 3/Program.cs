using System;
using System.Collections.Generic;
using System.Linq;

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
            int hacer;
            int cantidad;
            int x = 0;
            string pname;
            string pmarca;
            int pprecio;
            int pstock;
            string compra;
            int sueldo;
            string n_cajero;
            int z = 0;
            

            List<Persona> jefe = new List<Persona>();
            List<Persona> cajeros = new List<Persona>();
            List<Persona> supervisor = new List<Persona>();
            List<Persona> auxiliar = new List<Persona>();
            List<Persona> clientes = new List<Persona>();
            List<Producto> products = new List<Producto>();
            List<string> comprado = new List<string>();
            List<int> total = new List<int>();

            Console.WriteLine("1) Crear trabajadores");
            Console.WriteLine("2) Crear un producto");
            Console.WriteLine("3) Comprar");
            Console.WriteLine("4) Crear un cliente");
            Console.WriteLine("5) Salir");
            Console.WriteLine("¿Que quiere hacer? ");
            hacer = Convert.ToInt32(Console.ReadLine());
            while (hacer == 1 || hacer == 2 || hacer == 3 || hacer ==4)
            {
                if (hacer == 1)
                {

                    Console.WriteLine("ingrese datos del jefe");
                    Console.WriteLine("Ingerese su rut: ");
                    rut = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Nacionalidad: ");
                    nation = Console.ReadLine();
                    Console.WriteLine("Nacimiento: ");
                    date = Console.ReadLine();
                    Console.WriteLine("Sueldo: ");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Persona boss = new Persona()
                    {
                        prut = rut,
                        pname = name,
                        plastname = lastname,
                        pnationality = nation,
                        pbithday = date,
                        psueldo = sueldo
                    };
                    jefe.Add(boss);
                    Console.WriteLine("Cuantos cajeros desea crear (Mayor o igual a 1): ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    int i = 1;
                    while (i <= cantidad)
                    {
                        Console.WriteLine("Ingrese datos del cajero " + i);
                        Console.WriteLine("Ingerese su rut: ");
                        rut = Console.ReadLine();
                        Console.WriteLine("Ingrese su nombre: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Apellido: ");
                        lastname = Console.ReadLine();
                        Console.WriteLine("Nacionalidad: ");
                        nation = Console.ReadLine();
                        Console.WriteLine("Nacimiento: ");
                        date = Console.ReadLine();
                        Console.WriteLine("Sueldo: ");
                        sueldo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Persona caje = new Persona()
                        {
                            prut = rut,
                            pname = name,
                            plastname = lastname,
                            pnationality = nation,
                            pbithday = date,
                            psueldo = sueldo
                        };
                        cajeros.Add(caje);

                        i++;
                    }
                    Console.WriteLine("Ingrese datos del supervisor");
                    Console.WriteLine("Ingerese su rut: ");
                    rut = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Nacionalidad: ");
                    nation = Console.ReadLine();
                    Console.WriteLine("Nacimiento: ");
                    date = Console.ReadLine();
                    Console.WriteLine("Sueldo: ");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    Persona super = new Persona()
                    {
                        prut = rut,
                        pname = name,
                        plastname = lastname,
                        pnationality = nation,
                        pbithday = date,
                        psueldo = sueldo
                    };
                    supervisor.Add(super);

                    
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese datos del Auxiliar");
                    Console.WriteLine("Ingerese su rut: ");
                    rut = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Nacionalidad: ");
                    nation = Console.ReadLine();
                    Console.WriteLine("Nacimiento: ");
                    date = Console.ReadLine();
                    Persona aux = new Persona()
                    {
                        prut = rut,
                        pname = name,
                        plastname = lastname,
                        pnationality = nation,
                        pbithday = date,
                        psueldo = sueldo
                    };
                    auxiliar.Add(aux);


                }
                else if (hacer == 2)
                {
                    Console.WriteLine("Nombre producto: ");
                    pname = Console.ReadLine();
                    Console.WriteLine("Marca: ");
                    pmarca = Console.ReadLine();
                    Console.WriteLine("Precio: ");
                    pprecio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Stock: ");
                    pstock = Convert.ToInt32(Console.ReadLine());
                    Producto ee = new Producto()
                    {
                        ppname = pname,
                        ppmarca = pmarca,
                        ppprecio = pprecio,
                        ppstock = pstock
                    };
                    products.Add(ee);
                }

                else if (hacer == 3)
                {
                    Console.WriteLine("Ingrese nombre del cajero que desea ir : ");
                    n_cajero = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Productos: ");
                    foreach (Producto c in products)
                    {      
                        Console.WriteLine("Nombre: "+c.ppname+" Marca: "+c.ppmarca+" Precio: "+c.ppprecio+" Stock: "+c.ppstock);
                    }
                    Console.WriteLine("Que desea comprar (escribir producto)");
                    compra = Console.ReadLine();
                    foreach (Producto c in products)
                    {
                        if (compra == c.ppname)
                        {
                            if (c.ppstock <= 0)
                            {
                                Console.WriteLine("No quedan productos");
                            }
                            else
                            {
                                comprado.Add(compra);
                                total.Add(c.ppprecio);
                                Console.WriteLine(c.ppprecio);
                                c.ppstock--;
                            }
                           
                            
                        }
                    }
                }

                else if (hacer == 4)
                {
                    /*
                    Console.WriteLine("Ingrese datos del cliente");
                    Console.WriteLine("Ingerese su rut: ");
                    rut = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Nacionalidad: ");
                    nation = Console.ReadLine();
                    Console.WriteLine("Nacimiento: ");
                    date = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Cuantos cajeros desea hacer (Mayor o igual a 1): ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Persona client = new Persona(rut, name, lastname, nation, date);
                    clientes.Add(client.retornaNombre());
                    */
                }
                Console.WriteLine("");
                Console.WriteLine("¿Que quiere hacer?");
                Console.WriteLine("1) Crear un trabajador");
                Console.WriteLine("2) Crear un producto");
                Console.WriteLine("3) Comprar");
                Console.WriteLine("4) Crear un cliente");
                Console.WriteLine("5) Salir");
                Console.WriteLine("¿Que quiere hacer? ");
                hacer = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Boleta:");
            while (x < comprado.Count)
            {
                Console.WriteLine("Nombre producto: "+comprado[x]+"   Coste del producto: "+total[x]);
                x++;
            }
            int totaal = 0;
            while (z < total.Count)
            {
                totaal = totaal + total[z];
                z++;
            }
            Console.WriteLine("Tiene que pagar: " + totaal);
        }


    }

}
