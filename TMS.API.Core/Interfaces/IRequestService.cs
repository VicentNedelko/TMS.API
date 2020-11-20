using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMS.API.Core.Models;

namespace TMS.API.Core.Interfaces
{
    public interface IRequestService
    {
        public Task<Example> GetInfoReqAsync();
    }
}
