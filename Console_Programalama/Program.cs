using System;

namespace Console_Programalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string name= Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz:");
            string surname= Console.ReadLine();
            Console.WriteLine("Hello!" +" "+name+" "+surname);
            Console.ReadLine();
        }
    }
}
