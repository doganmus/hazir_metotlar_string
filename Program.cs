﻿using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";
            //Lenghth
            Console.WriteLine(degisken.Length);

            //Toupper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(string.Concat(degisken," Merhaba"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Doğan"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft, PedRight
            Console.WriteLine(degisken+degisken2.PadLeft(30)); 
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); 
            Console.WriteLine(degisken.PadRight(50)+degisken2);             
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2); 

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSahrp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
