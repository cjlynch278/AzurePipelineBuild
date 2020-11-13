using System;

namespace UtilityLibraries
{
    public static class MathsLibrary
    {
        public static bool divisibleByTwo(this int myInt)
        {
            return myInt%2 == 0;
        }
        public static int add2(this int myInt)
        {
            return myInt + 2;
        }
        public static int subtract2(this int myInt)
        {
            return myInt - 2;
        }
    }
}
