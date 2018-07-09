using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Decode(".... . -.--   .--- ..- -.. .");



        }
        public static string Decode(string morseCode)
        {
            Console.WriteLine(string.Join(" ", morseCode.Split().Select(x => x)));
            Console.ReadKey();
            return morseCode.Split().Select(x => x).ToString();
        }

        public static String Accum(string s)
        {
            Console.WriteLine(string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)))); // select(x,i) - х это значение, i Это индекс значения. В первой части создаются все  большие буквы Select((x,i) => char.ToUpper(x) затем добавляется строка с двумя параметрами x и i где х это значение а i это длина строки


            Console.ReadKey();
            return string.Join("-", s.Select((x, i) => char.ToUpper(x)));
        }


    }
}
//s.Select(x=>x.IsUpper? x.ToUpper:x.ToLower).ToArray;

//int i = Convert.ToInt32(year.ToString().Substring(year.ToString().Length - 2)) == 00 ? (year) : year + 100;
/*string a = "";
char ch;
           for (int i = 0; s.Length > i; i++)
           {
               ch = s[i];
               string s3 = new String(ch, i + 1);
s3 = s3.ToLower();
               s3 = char.ToUpper(s3[0]) + s3.Substring(1);
               a += s3 + "-";
           }
           a = a.Trim(new char[] { '-' });
           Console.WriteLine(a);
           Console.ReadKey();
           return a;*/



/*public static String Accum(string s)
{
    Console.WriteLine(string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)))); // select(x,i) - х это значение, i Это индекс значения. В первой части создаются все  большие буквы Select((x,i) => char.ToUpper(x) затем добавляется строка с двумя параметрами x и i где х это значение а i это длина строки


    Console.ReadKey();
    return string.Join("-", s.Select((x, i) => char.ToUpper(x)));*/