using System;

namespace TerzoGiorno
{
    class ShowMessage
    {
        
        public ShowMessage()
        {
            Console.WriteLine("Hi, i am default");
        }

        public ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        ~ShowMessage()
        {
            Console.WriteLine("I am destructor and I clean the resources and free up memory as soon as program closed");
            Console.ReadLine();
        }
    }
    class DieciCaratteri
    {
        private int iDimensioneFinestra = 10;
        private int sStringaCorrente;
    }

}

