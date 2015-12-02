using MbTest4Net.Model;

namespace MbTest4Net.Fluency
{
    public interface IFluency<out TModel> where TModel : ModelBase
    {
        TModel Build();
    }
}