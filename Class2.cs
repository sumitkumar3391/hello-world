using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Menudisplay
    {
        public int Multi()
        {
            Console.WriteLine("Enter First Value");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter Second Value");
            string value2 = Console.ReadLine();
            return Convert.ToInt32(value1)* Convert.ToInt32(value2);
        }
        

        public void Read(string textFile)
        {

            string path = @"C:\Users\su.kumar1\Desktop\test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("file Exists");
                string text3 = File.ReadAllText(path);
                Console.WriteLine(text3);
            }
            else
            {
                Console.WriteLine("file doesnot Exists");
            }
        }
        public  List<string> Iteration()
        {
            List<string> ls = new List<string>(10);
            ls.Add("one");
            ls.Add("two");
            ls.Add("three");
            ls.Add("four");

            return ls;
        }
    }

}
