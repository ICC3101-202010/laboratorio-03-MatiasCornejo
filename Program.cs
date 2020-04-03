using System;

using System.Collections.Generic;
namespace lab_3
{
    class MainClass
    {
        private const int V = 0;

        public static void Main(string[] args)

        {
            List<string> listaempleados = new List<string>();
         

            Person p1 = new Person("13.232.534-1", "matias", "cornejo", "21/sep/1997", "chile");
           


            Employee E1 = new Employee("jose", 200000, "19.542.345-1","Reponedor","1-22");
            Employee E2 = new Employee("martin", 200000, "18.434.541-k", "Reponedor", "1-22");
            Employee E3 = new Employee("macarena", 200000, "12.321.235-1", "Reponedor", "1-22");
            Employee E4 = new Employee("francois", 200000, "20.432.321-2", "Reponedor", "1-22");
            Employee E5 = new Employee("italo", 200000, "18282.22", "Reponedor", "1-22");
            Employee E6 = new Employee("francisca", 200000, "18282.22", "Reponedor", "1-22");
            Employee E7 = new Employee("natalia", 200000, "18282.22", "Reponedor", "1-22");
            Employee E8 = new Employee("anto", 200000, "18282.22", "Reponedor", "1-22");




            p1.Greet();

            E1.Greet();
            
           

            

           
            foreach (string letra in listaempleados)
            {
                Console.WriteLine(letra);

            }
            Console.ReadKey();

        }
    }
}
