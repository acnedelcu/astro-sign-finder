using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Server.Protos;

namespace Server.Services
{
    public class AstroSignService: AstroSign.AstroSignBase
    {
        public AstroSignService()
        {

        }
        public override Task<AstroSignResult> GetAstroSign(AstroSignLookup request, ServerCallContext context)
        {
            AstroSignResult result = new AstroSignResult();

            System.IO.StreamReader fisier = new System.IO.StreamReader("Zodii.txt");

            List<string> lines = File.ReadAllLines("Zodii.txt").ToList();
            List<Info> info = new List<Info>();

            foreach(var line in lines)
            {
                string[] temp = line.Split(" ");

                Info tempInfo = new Info();

                tempInfo.StartDate = temp[0];
                tempInfo.EndDate = temp[1];
                tempInfo.Sign = temp[2];
                info.Add(tempInfo);
            }

            foreach(var item in info)
            {
                Console.WriteLine($"{item.StartDate} {item.EndDate} {item.Sign}");
            }

            CultureInfo culture = new CultureInfo("en-US");
            foreach (var item in info)
            {
                try
                {
                    DateTime requestedDate = DateTime.ParseExact(request.Date, "MM/dd", culture);
                    DateTime startDate = DateTime.ParseExact(item.StartDate, "MM/dd", culture);
                    DateTime endDate= DateTime.ParseExact(item.EndDate, "MM/dd", culture);

                    if (requestedDate >= startDate && requestedDate <= endDate)
                    {
                        result.Sign = item.Sign;
                        return Task.FromResult(result);
                    }
                }
                catch
                {
                    Console.WriteLine("Parsing error!");
                }
            }
            return Task.FromResult(result);
        }
    }
}
