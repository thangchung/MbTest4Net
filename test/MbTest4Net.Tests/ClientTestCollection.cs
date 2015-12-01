using System.Net;
using MbTest4Net.Model;
using MbTest4Net.Tests.Helpers;
using Xunit;

namespace MbTest4Net.Tests
{
    [Collection("Client collection")]
    public class ClientTestCollection
    {
        private readonly ClientFixture _fixture;

        public ClientTestCollection(ClientFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact, TestPriority(1)]
        public void Can_Instance_Client()
        {
            Assert.NotNull(_fixture.Client);
        }

        [Fact, TestPriority(2)]
        public void Is_Client_Alive()
        {
            var result = _fixture.Client.StillAlive();
            Assert.True(result);
        }

        [Fact, TestPriority(3)]
        public void Can_Create_Imposter_On_Port_6666()
        {
            var imposter = new Imposter
            {
                Port = 6666,
                Protocol = "http"
            };
            var result = _fixture.Client.CreateImposter(imposter);
            Assert.True(result == HttpStatusCode.Created);
        }

        [Fact, TestPriority(4)]
        public void Can_Delete_Imposter_On_Port_6666()
        {
            var result = _fixture.Client.DeleteImposter(6666);
            Assert.True(result == HttpStatusCode.OK);
        }

        [Fact, TestPriority(5)]
        public void Can_Count_Imposter()
        {
            var result = _fixture.Client.CountImposter();
            Assert.True(result >= 1);
        }
    }
}