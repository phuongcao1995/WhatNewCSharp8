using System;

namespace PropertyPatterns
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        public static decimal SalesTax(Address address) =>
        address switch
        {
            { City: "Ha Noi" } => 2,
            { City: "Da Nang" } => 5,
            { City: "Ho Chi Minh" } => 7,
            _ => 0
        };
        static void Main(string[] args)
        {
            Address address = new Address();
            address.City = "Hue";
            var salesTax = SalesTax(address);
            Console.WriteLine(salesTax);

            Console.ReadLine();

        }
    }
}
