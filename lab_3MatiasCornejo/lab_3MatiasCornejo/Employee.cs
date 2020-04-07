using System;
namespace lab_3MatiasCornejo

{
    public class Employee : Person  //creamos la subclase empleado 
    {
        public int Salary;
        public string Position;
        public string Horario;


        public Employee(string Name, int Salary, string Rut, string Position, string Horario) : base(Name, Rut)//lo que hay que rellenar cuando lo llevemos al main

        {
            this.Salary = Salary;
            this.Position = Position;
            this.Horario = Horario;
        }



        public override void Greet()
        {
            base.Greet();

            Console.WriteLine("trabajo en el supermercado y mi cargo es :" + Position);

        }

        public int Getsalary() { return Salary; }
        public void Setsalary(int Salary) { this.Salary = Salary; }

        public string Getposition() { return Position; }
        public void Setposition(string Position) { this.Position = Position; }

        public string Gethorario() { return Horario; }
        public void Sethorario(string Horario) { this.Horario = Horario; }
    }
}

