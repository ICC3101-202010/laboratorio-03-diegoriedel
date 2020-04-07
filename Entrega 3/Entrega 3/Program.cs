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
            string rut_cliente;
            int z = 0;
            int tra;

            List<Persona> jefe = new List<Persona>();
            List<Persona> cajeros = new List<Persona>();
            List<Persona> supervisor = new List<Persona>();
            List<Persona> auxiliar = new List<Persona>();
            List<Persona> clientes = new List<Persona>();
            List<Producto> products = new List<Producto>();
            List<string> comprado = new List<string>();
            List<int> total = new List<int>();

            Console.WriteLine("Bienvenido al supermercado");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1) Crear trabajadores");
            Console.WriteLine("2) Crear un producto");
            Console.WriteLine("3) Comprar");
            Console.WriteLine("4) Crear un cliente");
            Console.WriteLine("5) Ver trabajadores o clientes");
            Console.WriteLine("6) Salir");
            Console.WriteLine("¿Que quiere hacer? ");
            hacer = Convert.ToInt32(Console.ReadLine());
            while (hacer == 1 || hacer == 2 || hacer == 3 || hacer ==4 || hacer ==5)
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
                    Console.WriteLine("Ingrese rut del cliente con el cual desea comprar : ");
                    rut_cliente = Console.ReadLine();
                    foreach (Persona c in clientes)
                    {
                        if (rut_cliente == c.prut)
                        {
                            int pr = 1;
                            while (pr == 1)
                            {


                                Console.WriteLine("Productos:");
                                foreach (Producto ii in products)
                                {
                                    Console.WriteLine("Nombre: " + ii.ppname + " Marca: " + ii.ppmarca + " Precio: " + ii.ppprecio + " Stock: " + ii.ppstock);
                                }
                                Console.WriteLine("Que desea comprar (escribir producto)");
                                compra = Console.ReadLine();
                                foreach (Producto w in products)
                                {
                                    if (compra == w.ppname)
                                    {
                                        if (w.ppstock <= 0)
                                        {
                                            Console.WriteLine("No quedan productos");
                                        }
                                        else
                                        {
                                            comprado.Add(compra);
                                            total.Add(w.ppprecio);
                                            Console.WriteLine(w.ppprecio);
                                            w.ppstock--;
                                        }


                                    }
                                }
                                Console.WriteLine("¿Quiere seguir comprando?");
                                Console.WriteLine("1) Si");
                                Console.WriteLine("2) NO");
                                pr = Convert.ToInt32(Console.ReadLine());
                                
                                if (pr == 2)
                                {
                                    Console.WriteLine("Boleta:");
                                    while (x < comprado.Count)
                                    {
                                        Console.WriteLine("Nombre producto: " + comprado[x] + "   Coste del producto: " + total[x]);
                                        x++;
                                    }
                                    int totaal = 0;
                                    while (z < total.Count)
                                    {
                                        totaal = totaal + total[z];
                                        z++;
                                    }
                                    Console.WriteLine(c.pname + " " + c.plastname);
                                    Console.WriteLine("Tiene que pagar: " + totaal);
                                    Console.WriteLine(DateTime.Now.ToString("h:mm:ss"));
                                    break;
                                }
                                break;  
                                
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Rut no valido");
                        }
                    }
                }

                else if (hacer == 4)
                { 
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
                    Persona client = new Persona()
                    {
                        prut = rut,
                        pname = name,
                        plastname = lastname,
                        pnationality = nation,
                        pbithday = date
                    };
                    clientes.Add(client);

                }
                else if (hacer == 5)
                {
                    Console.WriteLine("¿Que Trabajador/Cliente quieres ver?");
                    Console.WriteLine("1) Jefes");
                    Console.WriteLine("2) Cajeros");
                    Console.WriteLine("3) Supervisores");
                    Console.WriteLine("4) Auxiliares");
                    Console.WriteLine("5) Clientes");
                    tra = Convert.ToInt32(Console.ReadLine());
                    int q = 0;
                    if (tra == 1)
                    {
                        while (q < jefe.Count)
                        {
                            Console.WriteLine(jefe[q]);
                            q++;
                        }
                    }
                    else if (tra == 2)
                    {
                        while (q < cajeros.Count)
                        {
                            Console.WriteLine(cajeros[q]);
                            q++;
                        }
                    }
                    else if (tra ==3)
                    {
                        while  (q < supervisor.Count)
                        {
                            Console.WriteLine(supervisor[q]);
                            q++;
                        }
                    }
                    else if (tra == 4)
                    {
                        while (q < auxiliar.Count)
                        {
                            Console.WriteLine(auxiliar[q]);
                            q++;
                        }
                    }
                    else
                    {
                        while (q < clientes.Count)
                        {
                            Console.WriteLine(clientes[q]);
                            q++;
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("¿Que quiere hacer?");
                Console.WriteLine("1) Crear un trabajador");
                Console.WriteLine("2) Crear un producto");
                Console.WriteLine("3) Comprar");
                Console.WriteLine("4) Crear un cliente");
                Console.WriteLine("5) Ver trabajadores o clientes");
                Console.WriteLine("6) Salir");
                Console.WriteLine("¿Que quiere hacer? ");
                hacer = Convert.ToInt32(Console.ReadLine());
            }





            
        }


    }

}
