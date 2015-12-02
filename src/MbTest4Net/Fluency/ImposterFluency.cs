using System;
using System.Linq.Expressions;
using MbTest4Net.Extensions;
using MbTest4Net.Model;

namespace MbTest4Net.Fluency
{
    public class ImposterFluency : FluencyBase<Imposter>, IImposterFluency<Imposter>
    {
        public virtual IImposterFluency<Imposter> With(Expression<Func<Imposter, object>> property, object value)
        {
            Model.SetValue(property, value);
            return this;
        }

        public IImposterActionFluency Do
        {
            get { return new ImposterActionFluency(Model, DefaultBaseUrl); }
        }
    }
}