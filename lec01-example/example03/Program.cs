using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "lance";
            Console.WriteLine("Student name:{0}",
            someone.name);
        }
    }
}
