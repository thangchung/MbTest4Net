using System.Net;

namespace MbTest4Net.Fluency
{
    public interface IImposterActionFluency
    {
        HttpStatusCode Create();
        HttpStatusCode Delete();
        int Count();
    }
}