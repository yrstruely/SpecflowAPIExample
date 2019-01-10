using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExample.Hooks
{
    public interface IResponse : IDisposable
    {
         string BaseUrl { get; set; }
    }

    public class AResponse : IResponse
    {
        public AResponse()
        {
            BaseUrl = "AResponseURL";
        }

        public string BaseUrl { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    public class BResponse : IResponse
    {
        public BResponse()
        {
            BaseUrl = "BResponseURL";
        }

        public string BaseUrl { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
