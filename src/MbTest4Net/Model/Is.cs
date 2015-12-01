using System.Collections.Generic;

namespace MbTest4Net.Model
{
    public class Is
    {
        public List<KeyValuePair<string, object>> Data { get; set; }
        public List<KeyValuePair<string, string>> Headers { get; set; }

        public Is()
        {
            Data.Add(new KeyValuePair<string, object>("statusCode", 200));
            Data.Add(new KeyValuePair<string, object>("headers", Headers));
        } 
    }
}