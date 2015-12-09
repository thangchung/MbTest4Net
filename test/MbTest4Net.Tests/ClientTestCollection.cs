using System.Net;
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
        public void Can_Build_Imposter_Expression()
        {
            var model = _fixture.Client.Imposter
                .With(x => x.Port, 6667)
                .With(x => x.Protocol, "http")
                .Build();

            Assert.NotNull(model);
        }

        [Fact, TestPriority(4)]
        public void Can_Create_Imposter()
        {
            var result = _fixture.Client
                .Imposter
                .With(x => x.Port, -10)
                .With(x => x.Protocol, "http")
                .Do.Create();

            Assert.True(result == HttpStatusCode.Created);
        }

        [Fact, TestPriority(5)]
        public void Can_Delete_Imposter()
        {
            var result = _fixture.Client
                .Imposter
                .With(x => x.Port, 6667)
                .With(x => x.Protocol, "http")
                .Do.Delete();

            Assert.True(result == HttpStatusCode.OK);
        }

        [Fact, TestPriority(6)]
        public void Can_Count_Imposter()
        {
            var result = _fixture.Client
                .Imposter
                .Do.Count();

            Assert.True(result >= 1);
        }
    }
}