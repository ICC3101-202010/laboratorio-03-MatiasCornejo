using System;
namespace lab_3

{
    public class Person //creamos la clase principal que seria persona
    {
        private string Rut;
        string Name;
        private string SurName;  
        private string Date;
        private string Nacionalidad;

        public Person(string Rut, string Name, string SurName,string Date,string Nacionalidad)
        {
            this.Rut = Rut;
            this.Name = Name;
            this.SurName = SurName;
            this.Date = Date;
            this.Nacionalidad = Nacionalidad;
        }

        public Person(string name, string rut)
        {
            Name = name;
            Rut = rut;
        }

        public virtual void Greet ()
        {

            Console.WriteLine("mi nombre es :" + Name);
        }

        public string Getname() { return Name; }
        public void Setname(string Name) { this.Name = Name; }

        public string Getrut() { return Rut; }
        public void Setrut(string Rut) { this.Rut = Rut; }

        public string Getsurname() { return SurName; }
        public void Setsurname(string SurName) { this.SurName = SurName; }

        public string Getdate() { return Date; }
        public void Setdate(string Date) { this.Name = Date; }

        public string Getnacionalidad() { return Nacionalidad; }
        public void Setnacionalidad(string Nacionalidad) { this.Nacionalidad = Nacionalidad; }




    }


}
