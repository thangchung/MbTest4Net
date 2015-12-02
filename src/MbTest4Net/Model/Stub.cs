using System.Collections.Generic;

namespace MbTest4Net.Model
{
    public class Stub : ModelBase
    {
        public Stub()
        {
            Responses = new List<Response>();
            Predicates = new List<Predicate>();
        }

        public List<Response> Responses { get; set; }
        public List<Predicate> Predicates { get; set; }
    }
}