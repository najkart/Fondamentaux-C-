using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //exo 1 
            Console.WriteLine(test(1,2));
            Console.WriteLine(test(2, 2));
            Console.WriteLine(test(2, 2));
            //exo 2
            Console.WriteLine(test2(45));
            Console.WriteLine(test2(58));
            Console.WriteLine(test2(51));
            //exo 3
            Console.WriteLine(test3(30,3));
            Console.WriteLine(test3(15, 15));
            Console.WriteLine(test3(3, 30));
            Console.WriteLine(test3(6, 7));
            //exo 11 
            Console.WriteLine(test11("Python"));
            Console.WriteLine(test11("js"));
            Console.WriteLine(test11("code"));
            //exo 12
            Console.WriteLine(test12("C# Sharp"));
            Console.WriteLine(test12("C#"));
            Console.WriteLine(test12("C++"));
            Console.ReadLine();
          

        
        }
        //exo 1 
        public static int test(int a , int b)
        {

            return a==b ?(a+b)*3:a+b;
        }
        //exo 2
        public static int test2(int n)
        {
            int result;
            if (n < 51)
            {
                result = 51 - n;
            }
            else
            {
                result = (n - 51) * 3;
            }
            return result;
        }
        //exo 3
        public static bool test3(int a ,int b)
        {
            return a == 30 || b == 30 || (a + b == 30);
        }
        //exo 11
        public static string test11(string word)
        {
           
            if (word.Length < 3)
            {
                return word + word + word;
            }
            else
            {
                string newWord = word.Substring(0, 3);

                return newWord + word + newWord;
            }
           
            
        }
        public static bool test12(string word)
        {
            //return (word.Substring(0, 2) == "c#") ? true : false;
            return (word.Length < 3 && word.Equals("C#")) || (word.StartsWith("C#")&& word[2] == ' ');
        }

    }
}
