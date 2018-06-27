using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NewspaperOffice office = new NewspaperOffice();

            Customer arvin = new Customer("Arvin");
            office.SubscribeNewspaper(arvin);

            Customer jack = new Customer("Jack");
            office.SubscribeNewspaper(jack);

            office.SendNewspaper("News One ...");

            office.UnsubscribeNewspaper(arvin);

            office.SendNewspaper("News Two ...");
        }
    }
}
