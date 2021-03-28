using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining
{
    class Task8
    {
        public static string StringwSpaces(string BaseString)
        {
            char[] tempCharArray = BaseString.ToCharArray();
            char[] almostString = new char[tempCharArray.Length * 2];
            for (int i=0; i<almostString.Length;i++)
            {
                if (i % 2 == 0) almostString[i] = tempCharArray[i / 2];
                else almostString[i] = ' ';
            }
            string FinalString = new string(almostString);
            return FinalString;
        }
    }
}
