using System;

namespace Konstruktorerövning3inl
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jag = new Person("alex", "ved", 2001, 09, 11);
            if(jag.isMyndig())
            {
                Console.WriteLine(jag.getFullnamn() + " är myndig");
            }
            else
            {
                Console.WriteLine(jag.getFullnamn() + " är inte myndig");
            }
        }
    }
}