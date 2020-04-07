using System;
namespace lab_3MatiasCornejo
{
    public class Product
    {
        private string NameProduct;
        private string Brand;//marca
        private int Stock;
        private int Price; //precio

        public Product(string NameProduct, string Brand, int Stock, int Price)


        {
            this.NameProduct = NameProduct;
            this.Brand = Brand;
            this.Stock = Stock;
            this.Price = Price;

        }
        public virtual void Greet()
        {

            Console.WriteLine("se han añadido " + Stock + "  " + NameProduct);
        }
        public int Getprice() { return Price; }
        public void Setprice(int Price) { this.Price = Price; }

        public int Getstock() { return Stock; }
        public void Setstock(int Stock) { this.Stock = Stock; }

        public string Getnameproduct() { return NameProduct; }
        public void Setnameproduct(string NameProduct) { this.NameProduct = NameProduct; }

        public string Getbrand() { return Brand; }
        public void Setpbrand(string Brand) { this.Brand = Brand; }



    }
}

