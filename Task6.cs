using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining
{
    class Task6
    {
        public static void RevertByMe<T>(ref T[] BaseArray)
        {
            T[] ArrayTemp = new T[BaseArray.Length];
            for (int i=0;i<ArrayTemp.Length;i++)
            {
                ArrayTemp[i] = BaseArray[i];
            }
            for (int a=0;a<BaseArray.Length;a++)
            {
                BaseArray[a] = ArrayTemp[BaseArray.Length-1-a];

            }
        }
    }
}
