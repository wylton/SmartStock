using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace System
{
    public class BinderProvider : ModelBinderProvider
    {
        readonly IFormattableBinder binder = new IFormattableBinder();
        readonly EnumBinder enumBinder = new EnumBinder();
        public override IModelBinder GetBinder(HttpConfiguration configuration, Type modelType)
        {
            if (IFormattableBinder.CanBindType(modelType))
                return binder;
            else if (EnumBinder.CanBindType(modelType))
                return enumBinder;
            return null;
        }
    }
}
