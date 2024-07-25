//Viết hàm kiểm tra 1 chuỗi có là Palindrome hay không (chuỗi đối xứng)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuoiPalindrome
{
    internal class Program
    {
        /// <summary>
        /// Check input string is Palindrome or not.
        /// </summary>
        /// <param name="input">string need to check</param>
        /// <returns>true: if input is Palindrome, otherwise false</returns>
        //static bool IsPalindrome(string input)
        //{
        //    var length = input.Length;
        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        if (input[i] != input[length - 1 - i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        static bool CheckPalindrome(string input) => input.SequenceEqual(input.Reverse());
        
        //CÁCH 1
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi cần kiểm tra: ");
            string input = Console.ReadLine();

            bool IsPalindrome = CheckPalindrome(input); 
            if (IsPalindrome)
            {
                Console.WriteLine($"Chuỗi {input} là chuỗi Palindrome");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input} không phải là chuỗi Palindrome");
            }

        }
        


        //CÁCH 2
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;
        //    List<string> list = new List<string>();
        //    Console.Write("Nhập mảng: ");
        //    string input = Console.ReadLine();
        //    list.Add(input);

        //    if (IsPalindrome(input))
        //    {
        //        Console.WriteLine("=> Chuỗi đối xứng.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("=> Chuỗi không đối xứng.");
        //    }
        //}
    }
}
