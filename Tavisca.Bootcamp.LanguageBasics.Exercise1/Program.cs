using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            int prev = equation.IndexOf('*');
            string A = equation.Substring(0,prev);
            int next = equation.IndexOf('=');
            string B = equation.Substring(prev+1,next-prev-1);
            string C = equation.Substring(next+1);
            //Console.WriteLine($"{A} {B} {C}");
            if(C.Contains('?'))
            {
                float a = float.Parse(A);
                float b = float.Parse(B);
                float res = a*b;
                int index = C.IndexOf('?');
                string final =res.ToString();
                if(final.Length <C.Length)
                {
                    return -1;
                }
                char c = final[index];
               // Console.WriteLine(c);
               int ff = (int)Char.GetNumericValue(c);
                return ff;
            }
            else if(A.Contains('?'))
            {
                float b = float.Parse(B);
                float c = float.Parse(C);
                float res = c/b;
                int index = A.IndexOf('?');
                string final =res.ToString();
                if(final.Length<A.Length)
                {
                    return -1;
                }
                char d = final[index];
                int ff = (int)Char.GetNumericValue(d);
                return ff;
            }
            else if(B.Contains('?'))
            {
                float a = float.Parse(A);
                float c = float.Parse(C);
                float res = c/a;
                int index = B.IndexOf('?');
                string final =res.ToString();
                if(final.Length>B.Length || B.Length > final.Length)
                {
                    return -1;
                }
                char d = final[index];
                int ff = (int)Char.GetNumericValue(d);
                return ff;
            }
            throw new NotImplementedException();   
        }
    }
}
