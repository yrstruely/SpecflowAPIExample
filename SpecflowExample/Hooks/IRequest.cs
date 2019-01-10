using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExample.Hooks
{
    public interface IRequest : IDisposable
    {
         string BaseUrl { get; set; }
    }

    public class ARequest : IRequest
    {
        public ARequest()
        {
            BaseUrl = "ARequestURL";
        }

        public string BaseUrl { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class BRequest : IRequest
    {
        public BRequest()
        {
            BaseUrl = "BRequestURL";
        }

        public string BaseUrl { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
