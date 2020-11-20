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
            IRequestService reqData = new RequestService();
            var result = reqData.GetInfoReqAsync().GetAwaiter().GetResult();
            Console.WriteLine(result.details);
            Console.ReadKey();
        }
    }
}
