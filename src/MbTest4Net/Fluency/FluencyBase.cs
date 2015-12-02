using MbTest4Net.Model;

namespace MbTest4Net.Fluency
{
    public abstract class FluencyBase<TModel> : IFluency<TModel>
        where TModel : ModelBase, new()
    {
        protected readonly TModel Model;
        protected string DefaultBaseUrl = "http://localhost:2525";

        protected FluencyBase()
        {
            Model = new TModel();
        }

        public virtual TModel Build()
        {
            return Model;
        }
    }
}