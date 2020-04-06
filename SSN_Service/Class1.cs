using System;


namespace SSN_Service
{
    public class Class1
    {

        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
