using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Server.Protos;

namespace Client
{
    class Program
    {
        public static bool HasValidFormat(string date)
        {
            string acceptedChar = "0123456789/";
            foreach(char ch in date)
            {
                if(acceptedChar.Contains(ch)==false)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidDate(string date)
        {
            try
            {
                DateTime dateTime = DateTime.ParseExact(date, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new AstroSign.AstroSignClient(channel);

            while (true)
            {
                Console.WriteLine("Introduceti data:");
                string data = Console.ReadLine();
                if (HasValidFormat(data) && IsValidDate(data))
                {
                    string temp = data.Substring(0, 5); //remove the year from the date
              
                    var date = new AstroSignLookup { Date = temp };
                    var reply = await client.GetAstroSignAsync(date);
                    Console.WriteLine("Zodia "+ reply.Sign);
                }
                else
                {
                    Console.WriteLine("Data invalida introdusa!\n");
                }

            }
        }
    }
}
