using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class FixMultiplication
    {
        public int FindDigit(float tempResult,string stringWithUnknownDigit)
        {
            string actualNumber = tempResult.ToString();
            int indexOfUnknownDigit = stringWithUnknownDigit.IndexOf('?');
            if(actualNumber.Length  < stringWithUnknownDigit.Length || actualNumber.Length > stringWithUnknownDigit.Length)
            {
                    return -1;
            }
            char outputCharacterContainUnkownDigit = actualNumber[indexOfUnknownDigit];
            int missingDigit = (int)Char.GetNumericValue(outputCharacterContainUnkownDigit);
            return missingDigit;
        }
        public int FindDigit(String equation)
        {
            int prev = equation.IndexOf('*');
            string stringContainValueOfA = equation.Substring(0,prev);
            int next = equation.IndexOf('=');
            string stringConainValueOfB = equation.Substring(prev+1,next-prev-1);
            string stringContainValueOfC = equation.Substring(next+1);
            if(stringContainValueOfC.Contains('?'))
            {
                float A = float.Parse(stringContainValueOfA);
                float B = float.Parse(stringConainValueOfB);
                float tempResult = A*B;
                return FindDigit(tempResult,stringContainValueOfC);
                
            }
            else if(stringContainValueOfA.Contains('?'))
            {
                float B = float.Parse(stringConainValueOfB);
                float C = float.Parse(stringContainValueOfC);
                float tempResult = C/B;
                return FindDigit(tempResult,stringContainValueOfA);
            }
            else if(stringConainValueOfB.Contains('?'))
            {
                float A = float.Parse(stringContainValueOfA);
                float C = float.Parse(stringContainValueOfC);
                float tempResult = C/A;
                return FindDigit(tempResult,stringConainValueOfB);
            }
            throw new NotImplementedException();   
        }
    }
}