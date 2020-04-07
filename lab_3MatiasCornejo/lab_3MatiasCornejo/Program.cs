using System;

using System.Collections.Generic;

namespace lab_3MatiasCornejo
{
    class MainClass
    {
        private static string nombreproducto;

        public static string Getname { get; private set; }

        public static void Main(string[] args)

        {
            List<string> listaempleados = new List<string>();
            List<string> listamostrar = new List<string>();
            List<int> listasueldos = new List<int>();
            List<string> listarutempleados = new List<string>();
            List<string> listacargoempleados = new List<string>();
            List<string> listahoras = new List<string>();


            List<string> listaclientes = new List<string>();
            List<string> listarutclientes = new List<string>();
            List<string> listacomprasllevadas = new List<string>();

            List<string> listanombrepructos = new List<string>();
            List<string> listamarcaproductos = new List<string>();
            List<int> listastockproductos = new List<int>();
            List<int> listaprecios = new List<int>();



            int x;
            string linea;
            string j;
            int sueldo;
            string Nombre;

            int cantidad;

            int stock;
            int lleva;
            int precio;


            x = 1;










            while (x <= 7)

            {

                Console.WriteLine("bienvenido");

                Console.WriteLine(" ");

                Console.WriteLine("menu principal: ");

                Console.WriteLine("1) Crear Producto ");
                Console.WriteLine("2) Crear Cliente ");
                Console.WriteLine("3) Crear empleado ");
                Console.WriteLine("4) Mostrar registro compras ");





                x = int.Parse(Console.ReadLine());



                if (x == 1) //opcion crear producto
                {
                    Console.WriteLine("Indique nombre producto:");
                    string nombre = Console.ReadLine();
                    listanombrepructos.Add(nombre);



                    Console.WriteLine("Indique marca producto");
                    string marca = Console.ReadLine();
                    listamarcaproductos.Add(marca);

                    Console.WriteLine("Indique stock producto:");

                    stock = int.Parse(Console.ReadLine());
                    listastockproductos.Add(stock);

                    Console.WriteLine("Indique precio producto:");
                    precio = int.Parse(Console.ReadLine());
                    listasueldos.Add(precio);


                    Product E1 = new Product(nombre, marca, stock, precio);


                    E1.Greet();
                    Console.WriteLine("¿desea agregar otro producto?");
                    Console.WriteLine("1) SI");
                    Console.WriteLine("5)Volver al menu principal");
                    Console.WriteLine("9)Finalizar programa");

                    Console.WriteLine("");
                    x = int.Parse(Console.ReadLine());




                }















                if (x == 2) //opcion crear cliente
                {
                    Console.WriteLine("Indique nombre cliente:");
                    string nombre = Console.ReadLine();
                    listaclientes.Add(nombre);

                    Console.WriteLine("Indique rut cliente:");
                    string rut = Console.ReadLine();
                    listarutclientes.Add(rut);

                    while (x == 2)
                    {

                        Console.WriteLine("Indique que lleva:");
                        string nombreproducto = Console.ReadLine();
                        listacomprasllevadas.Add(nombreproducto);

                        Console.WriteLine("indique cantidad");
                        lleva = int.Parse(Console.ReadLine());


                        Console.WriteLine("¿desea agregar algo mas?");
                        Console.WriteLine("2) SI");
                        Console.WriteLine("3)NO?");
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());

                    }





                    client E1 = new client(nombre, rut, nombreproducto, 3);

                    E1.Greet();
                    Console.WriteLine("¿desea agregar otro cliente?");
                    Console.WriteLine("2) SI");
                    Console.WriteLine("5)Volver al menu principal");
                    Console.WriteLine("9)Finalizar programa");

                    Console.WriteLine("");
                    x = int.Parse(Console.ReadLine());



                }







                if (x == 3) //opcion crear empleado
                {
                    Console.WriteLine("Indique nombre empleado:");
                    string nombre = Console.ReadLine();
                    listaempleados.Add(nombre);

                    Console.WriteLine("Indique sueldo empleado:");
                    sueldo = int.Parse(Console.ReadLine());
                    listasueldos.Add(sueldo);

                    Console.WriteLine("Indique rut empleado:");
                    string rut = Console.ReadLine();
                    listarutempleados.Add(rut);

                    Console.WriteLine("Indique cargo empleado:");
                    string cargo = Console.ReadLine();
                    listacargoempleados.Add(cargo);

                    Console.WriteLine("Indique horas empleado:");
                    string horas = Console.ReadLine();
                    listahoras.Add(horas);



                    Employee E1 = new Employee(nombre, sueldo, rut, cargo, horas);

                    E1.Greet();
                    Console.WriteLine("¿desea agregar otro empleado?");
                    Console.WriteLine("3) SI");
                    Console.WriteLine("5)Volver al menu principal");
                    Console.WriteLine("9)Finalizar programa");

                    Console.WriteLine("");
                    x = int.Parse(Console.ReadLine());



                }





            }

            Employee E2 = new Employee("martin", 200000, "18.434.541-k", "Reponedor", "1-22");
            Employee E3 = new Employee("macarena", 200000, "12.321.235-1", "Reponedor", "1-22");
            Employee E4 = new Employee("francois", 200000, "20.432.321-2", "Reponedor", "1-22");
            Employee E5 = new Employee("italo", 200000, "18282.22", "Reponedor", "1-22");
            Employee E6 = new Employee("francisca", 200000, "18282.22", "Reponedor", "1-22");
            Employee E7 = new Employee("natalia", 200000, "18282.22", "Reponedor", "1-22");
            Employee E8 = new Employee("anto", 200000, "18282.22", "Reponedor", "1-22");




            //clientes

            client C1 = new client("matias", "23.323.3232,-1", "yogurth", 23);
            client C2 = new client("jose", "21.232.476,-1", "yogurth", 23);
            client C3 = new client("bastian", "23.254.327,-0", "yogurth", 23);
            client C4 = new client("marco", "18.323.111-4", "yogurth", 23);
            client C5 = new client("alfonso", "8-439.020-1", "yogurth", 23);
            client C6 = new client("juan", "23.323.3232,-1", "yogurth", 23);
            client C7 = new client("Alejando", "23.323.3232,-1", "yogurth", 23);
            client C8 = new client("Nataly", "23.323.3232,-1", "yogurth", 23);
            client C9 = new client("Almendra", "23.323.3232,-1", "yogurth", 23);
            client C10 = new client("Francisca", "23.323.3232,-1", "yogurth", 23);
            client C11 = new client("Fernanda", "23.323.3232,-1", "yogurth", 23);
            client C12 = new client("Loreto", "23.323.3232,-1", "yogurth", 23);
            client C13 = new client("Nancy", "23.323.3232,-1", "yogurth", 23);
            client C14 = new client("Gloria", "23.323.3232,-1", "yogurth", 23);
            client C15 = new client("naty", "23.323.3232,-1", "yogurth", 23);



            //productos
            Product p1 = new Product("Leche 200ml", "Soprole", 120, 290);
            Product p2 = new Product("Leche 1l", "Soprole", 55, 800);
            Product p3 = new Product("mini triton", "soprole", 67, 200);
            Product p4 = new Product("tallerines 77", "carozzi", 232, 620);
            Product p5 = new Product("corbatas", "carozzi", 175, 650);
            Product p6 = new Product("coca cola 3l", "coca cola", 76, 2150);
            Product p7 = new Product("coca cola 2l", "coca cola", 89, 2650);
            Product p8 = new Product("coca cola 1l", "coca cola", 110, 950);
            Product p9 = new Product("coca cola 500ml", "coca cola", 60, 600);
            Product p10 = new Product("frac", "costa", 34, 500);
            Product p11 = new Product("triton", "costa", 44, 550);
            Product p12 = new Product("azucar 1kg", "iansa", 77, 730);
            Product p13 = new Product("sal", "lobos", 50, 450);
            Product p14 = new Product("te verde ", "supremo", 34, 400);
            Product p15 = new Product("te rojo", "supremo", 43, 770);
            Product p16 = new Product("harina con polvo 1kg", "carozzi", 54, 600);
            Product p17 = new Product("harina sin polvo 1kg", "carozzi", 34, 600);
            Product p18 = new Product("mantequilla", "soprole", 45, 990);
            Product p19 = new Product("margarina", "soprole", 34, 770);
            Product p20 = new Product("manzana kg", "granel", 11, 700);
            Product p21 = new Product("pera kg", "granel", 12, 1200);
            Product p22 = new Product("bandeja champiñon", "huerto", 5, 990);
            Product p23 = new Product("atun en aceite", "real", 12, 1100);
            Product p24 = new Product("atun en agua", "real", 9, 1400);
            Product p25 = new Product("cerveza 1l", "corona", 45, 1000);
            Product p26 = new Product("cerveza 1l", "escudo", 55, 900);
            Product p27 = new Product("doritos", "costa", 43, 670);
            Product p28 = new Product("ramitas", "costa", 33, 900);
            Product p29 = new Product("papas fritas tarro", "lays", 60, 1400);
            Product p30 = new Product("papas fritas", "krispo", 80, 1200);














            //p1.Greet();

            // E1.Greet();







            foreach (string letra in listaempleados)
            {
                Console.WriteLine(letra);

            }
            Console.ReadKey();

        }
    }
}



