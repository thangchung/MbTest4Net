using Newtonsoft.Json;

namespace MbTest4Net.Extensions
{
    public static class JsonExtensions
    {
        public static TReturn DeserializeObject<TReturn>(this string json)
            where TReturn : new()
        {
            return string.IsNullOrEmpty(json)
                ? new TReturn()
                : JsonConvert.DeserializeObject<TReturn>(json);
        }

        public static string SerializeObject<TObject>(this TObject obj)
            where TObject : class
        {
            return obj == null
                ? string.Empty
                : JsonConvert.SerializeObject(obj);
        }
    }
}