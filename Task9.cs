using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining
{
    class Task9
    {
        public static string[] FindWords(string BaseString, char KeyChar)
        {
            string[] splittedString = BaseString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> tempListString = new List<string>();
            foreach (var a in splittedString)
            {
                char[] tempChar = a.ToCharArray();
                if (tempChar[0] == KeyChar) tempListString.Add(a);
            }
            string[] FinalString = new string[tempListString.Count];
            for (int i=0;i<FinalString.Length;i++)
            {
                FinalString[i] = tempListString[i];
            }
            return FinalString;
        }
    }
}
