using System;

namespace DeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your message? ");
            string input = (Console.ReadLine());
            string inputUpCase = input.ToUpper();
            string message = "";
            int checksum = 0;

            for (int i = 0; i < input.Length; i++) {
                int UniValue = Convert.ToInt32(inputUpCase[i]);
                int EncodeValue = UniValue - 64;

                checksum += UniValue;

                if (i < (input.Length - 1)) {
                    message += EncodeValue.ToString() + "-";
                }
                else {
                    message += EncodeValue.ToString();
                }
            }
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum.ToString());
        }
    }
}
