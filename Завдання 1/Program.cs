using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Завдання_1
{
    class Program
    {
        static void FirstVar(int x)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();           
            string a = null;
            sw.Start();
            for (int i = 1; i <= x; i++)
            {
                a += i + " ";
            }
            sw.Stop();
            Console.WriteLine(a);            
            Console.WriteLine((sw.ElapsedMilliseconds / 100.0).ToString());
        }
        static void SecondVar(int y)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();            
            string a = null;
            sw.Start();
            for (int i = y; i != 0; i--)
            {
                a += i + " ";
            }
            sw.Stop();
            Console.WriteLine(a);            
            Console.WriteLine((sw.ElapsedMilliseconds / 100.0).ToString());
        }
        static void ThirdVar(int z)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();            
            StringBuilder a = new StringBuilder("1");            
            sw.Start();
            for (int i = 1; i <= z; i++)
            {
                a.Append(" " + i);                  
            }           
            sw.Stop();
            Console.WriteLine(a);            
            Console.WriteLine((sw.ElapsedMilliseconds / 100.0).ToString());
        }
        static void FourthVar(int k)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            StringBuilder a = new StringBuilder("1");
            sw.Start();
            for (int i = 2; i <= k; i++)
            {                
                a.Insert(0, i + " ");
            }
            sw.Stop();
            Console.WriteLine(a);            
            Console.WriteLine((sw.ElapsedMilliseconds / 100.0).ToString());
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            int choise;
            do
            {
                Console.WriteLine("Виберіть спосіб (1, 2, 3, 4), 0 - вихід");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                    {
                            FirstVar(n);
                            break;
                    }
                    case 2:
                        {
                            SecondVar(n);
                            break;
                        }
                    case 3:
                        {
                            ThirdVar(n);
                            break;
                        }
                    case 4:
                        {
                            FourthVar(n);
                            break;
                        }
                    default:
                        Console.WriteLine("За таке банять. Вийди і зайди нормально");
                        break;                        
                }
                
            } while (choise != 0);
            
        }
    }
}
