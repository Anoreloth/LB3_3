using System;

namespace LB3_3
{
    class Book
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int pages;
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Book(string name, int pages, int price)
        {
            this.name = name;
            this.pages = pages;
            this.price = price;
        }
    }
    class Library : Book
    {
        public int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public Library(string name, int pages, int price, int discount) : base(name, pages, price)
        {
            this.discount = discount;
        }
        public void PR(string name, int price)
        {
            if (name == "Programming")
            {
                price = 2 * price;
            }

        }
        public void Cost(int discount, int price)
        {
            double cost = price * (discount * 0.01);
            Console.WriteLine("The cost of the book: " + cost);
        }
        public void Average(int pages, int price)
        {

            double av = price / pages;
            Console.WriteLine("Cost of 1 page: " + av);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var l = new Library("", 0, 0, 0);
            Console.Write("Book title: ");
            l.name = Console.ReadLine();
            Console.Write("Percentage discount: ");
            l.discount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of pages: ");
            l.pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("The price of the book: ");
            l.price = Convert.ToInt32(Console.ReadLine());
            l.Cost(l.discount, l.price);
            l.Average(l.pages, l.price);
        }

    }
}
