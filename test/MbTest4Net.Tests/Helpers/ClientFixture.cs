using System;
using MbTest4Net.Model;

namespace MbTest4Net.Tests.Helpers
{
    public class ClientFixture : IDisposable
    {
        private const int PORT = 6868;

        public ClientFixture()
        {
            Client = new Client();
            var imposter = new Imposter
            {
                Port = PORT,
                Protocol = "http"
            };
            Client.CreateImposter(imposter);
        }

        public Client Client { get; private set; }

        public void Dispose()
        {
            Client.DeleteImposter(PORT);
            if (Client != null)
            {
                GC.SuppressFinalize(Client);
            }
        }
    }
}