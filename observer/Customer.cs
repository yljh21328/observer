using System;
namespace observer
{
    public class Customer : IObserver
    {
        public string MyName { private get; set; }

        public Customer(string pName)
        {
            MyName = pName;
        }

        public void Update(string pMessage)
        {
            Console.WriteLine("{0} receive a new message: {1}", MyName, pMessage);
        }
    }
}
