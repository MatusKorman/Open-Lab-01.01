using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int fifa;
            Int32.TryParse(input, out fifa);
            if (fifa < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
