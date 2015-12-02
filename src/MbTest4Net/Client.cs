using MbTest4Net.Fluency;
using MbTest4Net.Model;

namespace MbTest4Net
{
    public class Client
    {
        public Client()
        {
            Imposter = new ImposterFluency();
        }

        public IImposterFluency<Imposter> Imposter { get; private set; }
        //TODO: consider to remove this
        public bool StillAlive()
        {
            return true;
        }
    }
}