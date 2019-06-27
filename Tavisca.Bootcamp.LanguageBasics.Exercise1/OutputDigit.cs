using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class FixMultiplication
    {
        public int FindDigit(String equation)
        {
            int prev = equation.IndexOf('*');
            string stringA = equation.Substring(0,prev);
            int next = equation.IndexOf('=');
            string stringB = equation.Substring(prev+1,next-prev-1);
            string stringC = equation.Substring(next+1);
            //Console.WriteLine($"{A} {B} {C}");
            if(stringC.Contains('?'))
            {
                float A = float.Parse(stringA);
                float B = float.Parse(stringB);
                float tempResult = A*B;
                int indexOfUnknownDigit = stringC.IndexOf('?');
                string actualNumber = tempResult.ToString();
                if(actualNumber.Length <stringC.Length)
                {
                    return -1;
                }
                char outputCharacterContainUnkownDigit = actualNumber[indexOfUnknownDigit];
               // Console.WriteLine(c);
               int missingDigit = (int)Char.GetNumericValue(outputCharacterContainUnkownDigit);
                return missingDigit;
            }
            else if(stringA.Contains('?'))
            {
                float B = float.Parse(stringB);
                float C = float.Parse(stringC);
                float tempResult = C/B;
                int indexOfUnknownDigit = stringA.IndexOf('?');
                string actualNumber =tempResult.ToString();
                if(actualNumber.Length<stringA.Length)
                {
                    return -1;
                }
                char outputCharacterContainUnkownDigit = actualNumber[indexOfUnknownDigit];
                int missingDigit = (int)Char.GetNumericValue(outputCharacterContainUnkownDigit);
                return missingDigit;
            }
            else if(stringB.Contains('?'))
            {
                float A = float.Parse(stringA);
                float C = float.Parse(stringC);
                float tempResult = C/A;
                int indexOfUnknownDigit = stringB.IndexOf('?');
                string actualNumber = tempResult.ToString();
                if(actualNumber.Length>stringB.Length || stringB.Length > actualNumber.Length)
                {
                    return -1;
                }
                char outputCharacterContainUnkownDigit = actualNumber[indexOfUnknownDigit];
                int missingDigit = (int)Char.GetNumericValue(outputCharacterContainUnkownDigit);
                return missingDigit;
            }
            throw new NotImplementedException();   
        }
    }
}