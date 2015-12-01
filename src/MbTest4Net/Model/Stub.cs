using System.Collections.Generic;

namespace MbTest4Net.Model
{
    public class Stub
    {
        public List<Response> Responses { get; set; }
        public List<Predicate> Predicates { get; set; }

        public Stub()
        {
            Responses = new List<Response>();
            Predicates = new List<Predicate>();
        }
    }
}