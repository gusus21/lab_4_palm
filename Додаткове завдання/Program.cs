using System;
using System.Text;
namespace Додаткове_завдання
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            
            if (FirstRemove(firstString) == SecondRemove(secondString))
                Console.WriteLine("Так");
            else
                Console.WriteLine("Ні");
        }
        static string FirstRemove(string first)
        {

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == ' ')
                {
                    first = first.Remove(i, 1);
                    i--;
                }
                               
            }
            return first;
        }
        static string SecondRemove(string second)
        {
            for (int i = 0; i < second.Length; i++)
            {
                if (second[i] == ' ')
                {
                   second = second.Remove(i, 1);
                    i--;
                }
            }
            return second;
        }
    }
}
