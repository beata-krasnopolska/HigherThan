using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherThanLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program asks the user for numbers than asks for additional specified value and displays the numbers higher than the specified value");
            List<int> userList = new List<int>();
            Console.WriteLine("Input the number of members on the List");
            int amount = int.Parse(Console.ReadLine());
            for (int i =0; i< amount; i++)
            {
                Console.WriteLine("Number {0} : ", i+1);
                int listMemer = int.Parse(Console.ReadLine());
                userList.Add(listMemer);
            }
            Console.WriteLine("Input the value above which you want to display the members of the List : ");
            int value = int.Parse(Console.ReadLine());

            var result = from x in userList
                         where x > value
                         select x;

            List<int> filterList = userList.FindAll(y => y > value);
            Console.WriteLine("The numers greater than {0} are: ", value);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Additional check by LINQ method");
            foreach (var n in filterList)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
