using System.Web.Http.ModelBinding;

namespace System
{
    public class EnumBinder : IModelBinder
    {
        public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            ValidateBindingContext(bindingContext);
            if (!bindingContext.ValueProvider.ContainsPrefix(bindingContext.ModelName) || !CanBindType(bindingContext.ModelType))
            {
                return false;
            }

            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (value == null)
                return false;
            try
            {
                bindingContext.Model = Enum.Parse(bindingContext.ModelType, value.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ValidateBindingContext(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException("bindingContext");

            if (bindingContext.ModelMetadata == null)
                throw new ArgumentException("ModelMetadata cannot be null", "bindingContext");
        }

        public static bool CanBindType(Type modelType)
        {
            return modelType.IsEnum;
        }
    }
}