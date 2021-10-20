using System;
using System.Reflection;

namespace Demo_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection in c#!");

            Type T = typeof(bool);
            Console.WriteLine("Type of Name:\t{0}", T.Name);
            Console.WriteLine("Full name of the type defined:\t{0}", T.FullName);
            Console.WriteLine("Type of assembly is defined:\t{0}", T.Assembly);
            Console.WriteLine("infomation about base type:\t{0}", T.BaseType);


        }
    }
}
