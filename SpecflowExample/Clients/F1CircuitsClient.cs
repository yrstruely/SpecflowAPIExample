using RestSharp;
using RestSharp.Deserializers;
using SpecflowExample.DataModels;

namespace SpecflowExample.Clients
{
    class F1CircuitsClient : BaseClient
    {
        private const string baseUrl = "http://ergast.com/api/f1";

        public F1CircuitsClient(ICacheService cache, IDeserializer deserializer, IErrorLogger errorLogger)
        : base(cache, deserializer, errorLogger, baseUrl) { }

        public F1 GetF1BySeason(int season)
        {
            IRestRequest request = new RestRequest("{season}/circuits.json", Method.GET)
                .AddUrlSegment("season", season.ToString());

            return Get<F1>(request);
        }
    }
}
