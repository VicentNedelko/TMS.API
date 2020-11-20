using System;
using TMS.API.Core.Interfaces;
using TMS.API.Core.Models;
using TMS.API.Core.Services;

namespace TMS.API.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestService reqData = new RequestService();
            var result = reqData.GetExampleReqAsync().GetAwaiter().GetResult();
            var resCores = reqData.GetCoreInfoAsync().GetAwaiter().GetResult();
            Console.WriteLine(result.details);
            Console.WriteLine(result.success);
            Console.WriteLine("CREW members : ");
            foreach(string member in result.ships)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine($" landing type = {resCores.landing_type}");
            Console.ReadKey();
        }
    }
}
