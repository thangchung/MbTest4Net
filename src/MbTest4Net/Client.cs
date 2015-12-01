using System;
using System.Net;
using MbTest4Net.Extensions;
using MbTest4Net.Model;

namespace MbTest4Net
{
    public class Client
    {
        public static string DEFAULT_BASE_URL = "http://localhost:2525";

        public bool StillAlive()
        {
            var uri = new Uri(DEFAULT_BASE_URL);
            var result = uri.Get<object>();
            return result != null;
        }

        public HttpStatusCode CreateImposter(Imposter imposter)
        {
            var uri = new Uri(DEFAULT_BASE_URL + "/imposters");
            var result = uri.Post(imposter);
            return result;
        }

        public HttpStatusCode DeleteImposter(int port)
        {
            var uri = new Uri(DEFAULT_BASE_URL + "/imposters/" + port);
            var result = uri.Delete();
            return result;    
        }

        public int CountImposter()
        {
            var uri = new Uri(DEFAULT_BASE_URL + "/imposters");
            var result = uri.Get<ImposterJson>();
            return result.Imposters.Count;    
        }
    }
}