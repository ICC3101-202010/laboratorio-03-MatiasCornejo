using System;
namespace lab_3
{
    public class Cliente : Person
    { 

        public string Compras;

        public int Cant;



        public Cliente(string Name, string Rut,string Compras ,int Cant) : base(Name, Rut)

        {
            this.Cant = Cant;
            this.Compras = Compras;

        }
        public override void Greet()
        {
            base.Greet();

            Console.WriteLine("jjxjcjc");

        }

        public string Getcompras() { return Compras; }
        public void Setcompras(string Compras) { this.Compras = Compras; }

        public int Getcant() { return Cant; }
        public void Setcant(int Cant) { this.Cant = Cant; }



    }
}
