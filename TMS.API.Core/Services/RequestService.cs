using System;
using System.Collections.Generic;
using System.Text;
using TMS.API.Core.Interfaces;
using TMS.API.Core.Models;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace TMS.API.Core.Services
{
    public class RequestService : IRequestService
    {
        public string url = "https://api.spacexdata.com/";
        public async Task<Example> GetInfoReqAsync()
        {
            return await url.AppendPathSegments("v4", "launches", "latest")
                .GetJsonAsync<Example>();

        }
    }
}
