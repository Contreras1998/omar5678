using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program1
    {

        static void Main(string[] args)
        {

            var person = new Person();
            person.BirthDate = new DateTime(2000, 1, 11);
            Console.WriteLine(person.Age);




        }

    }


}
