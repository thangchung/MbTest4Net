using System;
using System.Net;
using MbTest4Net.Extensions;
using MbTest4Net.Model;

namespace MbTest4Net.Fluency
{
    public class ImposterActionFluency : IImposterActionFluency
    {
        private readonly string _builtUrl;
        private readonly Imposter _model;

        public ImposterActionFluency(Imposter model, string defaultUrl)
        {
            _model = model;
            _builtUrl = defaultUrl + "/imposters";
        }

        public HttpStatusCode Create()
        {
            _model.IsValid();
            var uri = new Uri(_builtUrl);
            var result = uri.Post(_model);
            return result;
        }

        public HttpStatusCode Delete()
        {
            var uri = new Uri(_builtUrl + "/" + _model.Port);
            var result = uri.Delete();
            return result;
        }

        public int Count()
        {
            var uri = new Uri(_builtUrl);
            var result = uri.Get<ImposterJson>();
            return result.Imposters.Count;
        }
    }
}