using System;
namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = Console.ReadLine();
            string userText = Console.ReadLine();
            if(Equals(example, userText))
                Console.WriteLine("Однакові");            
           else if (Similar(example, userText))
                Console.WriteLine("Візуально схожі");
            else
                Console.WriteLine("Різні");
        }
        static bool Equals (string a, string b)
        {
            return a == b;
        }
        static bool Similar (string x, string y)
        {
            string alphabetEn = "ABCPHMOTKXEIaoyikbepnx";
            string alphabetUk = "АВСРНМОТКХЕІаоуікьерпх";
            bool res = false;
            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                for (int j = 0; j < alphabetEn.Length; j++)
                {
                    if ((x[i] == alphabetEn[j] || x[i] == alphabetUk[j]) && (y[i] == alphabetEn[j] || y[i] == alphabetUk[j]))
                    {
                        res = true;
                        break;
                    }
                }
                if (!res)
                    break;

            }       
            return res;
        }        
    }
}
