using System.Globalization;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace System
{
    public class IFormattableBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            ValidateBindingContext(bindingContext);
            if (!bindingContext.ValueProvider.ContainsPrefix(bindingContext.ModelName) || !CanBindType(bindingContext.ModelType))
            {
                return false;
            }
            var culture = CultureInfo.GetCultureInfo("pt-BR");
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (bindingContext.ModelType == typeof(double) || bindingContext.ModelType == typeof(double?))
            {
                double val = 0;
                double.TryParse(value.RawValue.ToString(), NumberStyles.Any, culture, out val);
                bindingContext.Model = val;
            }
            else if (bindingContext.ModelType == typeof(float) || bindingContext.ModelType == typeof(float?))
            {
                float val = 0;
                float.TryParse(value.RawValue.ToString(), NumberStyles.Any, culture, out val);
                bindingContext.Model = val;
            }
            else if (bindingContext.ModelType == typeof(decimal) || bindingContext.ModelType == typeof(decimal?))
            {
                decimal val = 0;
                decimal.TryParse(value.RawValue.ToString(), NumberStyles.Any, culture, out val);
                bindingContext.Model = val;
            }
            else if (bindingContext.ModelType == typeof(bool))
            {
                string[] values = new string[] { "on", "yes", "true", "t" };
                String rawVal = value.RawValue.ToString();
                bindingContext.Model = values.Contains(rawVal);

            }
            else if (bindingContext.ModelType == typeof(bool?))
            {
                string[] values = new string[] { "on", "yes", "true", "t" };
                String rawVal = value.RawValue.ToString();
                if (!String.IsNullOrEmpty(rawVal))
                    bindingContext.Model = values.Contains(rawVal);
            }
            else
                bindingContext.Model = value.ConvertTo(bindingContext.ModelType, culture);
            bindingContext.ValidationNode.ValidateAllProperties = true;
            return true;
        }

        private static void ValidateBindingContext(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException("bindingContext");

            if (bindingContext.ModelMetadata == null)
                throw new ArgumentException("ModelMetadata cannot be null", "bindingContext");
        }

        public static bool CanBindType(Type modelType)
        {
            return
                   modelType == typeof(DateTime)
                || modelType == typeof(DateTime?)
                || modelType == typeof(double)
                || modelType == typeof(double?)
                || modelType == typeof(decimal?)
                || modelType == typeof(decimal)
                || modelType == typeof(bool)
                || modelType == typeof(bool?)
                || modelType == typeof(float?)
                || modelType == typeof(float);
        }
    }
}
