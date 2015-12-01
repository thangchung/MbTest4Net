using Xunit;

namespace MbTest4Net.Tests.Helpers
{
    [CollectionDefinition("Client collection")]
    public class ClientCollection : ICollectionFixture<ClientFixture>
    {
    }
}