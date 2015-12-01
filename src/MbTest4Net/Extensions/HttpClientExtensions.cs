using System;
using System.Net;
using System.Net.Http;

namespace MbTest4Net.Extensions
{
    public static class HttpClientExtensions
    {
        public static TResult Get<TResult>(this Uri endpoint)
            where TResult : new()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(endpoint).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return result.DeserializeObject<TResult>();
            }
        }

        public static HttpStatusCode Post(this Uri endpoint, object bodyContent)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(bodyContent.SerializeObject());
                var response = httpClient.PostAsync(endpoint, content).Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode Delete(this Uri endpoint)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.DeleteAsync(endpoint).Result;
                return response.StatusCode;
            }
        }
    }
}