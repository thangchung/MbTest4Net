using System;

namespace MbTest4Net.Tests.Helpers
{
    public class ClientFixture : IDisposable
    {
        private const int Port = 6868;
        private const string Protocol = "http";

        public ClientFixture()
        {
            Client = new Client();
            Client
                .Imposter
                .With(x => x.Port, Port)
                .With(x => x.Protocol, Protocol)
                .Do.Create();
        }

        public Client Client { get; private set; }

        public void Dispose()
        {
            Client
                .Imposter
                .With(x => x.Port, Port)
                .With(x => x.Protocol, Protocol)
                .Do.Delete();

            if (Client != null)
            {
                GC.SuppressFinalize(Client);
            }
        }
    }
}