using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
           
            
            Menudisplay m1 = new Menudisplay();
            
            do
                
            {
                Console.WriteLine("1:For Multiplication");
                Console.WriteLine("2:For reading Text File");
                Console.WriteLine("3:for reading properties of a c# object");
                Console.WriteLine("4:For Exit");
                string input = Console.ReadLine();
                int value3 = Convert.ToInt32(input);

                switch (value3)
                {
                    case 1:
                        int result2 = m1.Multi();
                        Console.WriteLine(result2);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("ENTER TEXT FILE NAME");
                        string filename = Console.ReadLine();
                        
                        m1.Read(filename);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("listIteration  is ");
                        List<string> range = m1.Iteration();
                        foreach (string item in range)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Bye Have a Good Day");
                        Console.ReadLine();
                        
                        break;
                      

                }
        











            } while (true);





        }
    }
}
