using System;

namespace HiddenMessageC
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedPinNumber = Console.ReadLine();
            string startPostionString = Console.ReadLine();
            int step = Convert.ToInt32(Console.ReadLine());

            string pin = "";
            int startPostion = startPostionString[0] - 'a';
            pin += (encodedPinNumber[startPostion] - '0').ToString() + (encodedPinNumber[startPostion + step] - '0').ToString();
            pin += (encodedPinNumber[startPostion + 2 * step] - '0').ToString() + (encodedPinNumber[startPostion + 3 * step] - '0').ToString();

            Console.WriteLine(pin);
            Console.Read();
        }
    }
}
