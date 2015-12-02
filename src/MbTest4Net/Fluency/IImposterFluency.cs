using System;
using System.Linq.Expressions;
using MbTest4Net.Model;

namespace MbTest4Net.Fluency
{
    public interface IImposterFluency<out TModel> : IFluency<TModel>
        where TModel : ModelBase
    {
        IImposterActionFluency Do { get; }
        IImposterFluency<Imposter> With(Expression<Func<Imposter, object>> property, object value);
    }
}