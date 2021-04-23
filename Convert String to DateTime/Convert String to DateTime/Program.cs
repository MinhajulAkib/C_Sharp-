using System;

namespace Convert_String_to_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "5/12/2021";
            DateTime dt;
            var isValidDate = DateTime.TryParse(str, out dt);
            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not valid date string");
        }
    }
}
