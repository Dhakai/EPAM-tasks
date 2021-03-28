using System;

namespace EpamTraining
{
    class Task7
    {
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
    }
}
