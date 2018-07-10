using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class DecimalConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(double)
                || objectType == typeof(double?)
                || objectType == typeof(float)
                || objectType == typeof(float?)
                || objectType == typeof(decimal)
                || objectType == typeof(decimal?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null || reader.Value.ToString() == string.Empty)
                return 0d;
            return double.Parse(reader.Value.ToString(), CultureInfo.GetCultureInfo("pt-BR"));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string s = String.Format("{0:#,0.0000}", value, CultureInfo.GetCultureInfo("pt-BR"));
            writer.WriteValue(s);
        }
    }

    public class BooleanConverter : JsonConverter
    {
        static string[] possibleBoolTrueValue = new string[] { "on", "true", "t", "yes", "y" };
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool) || objectType == typeof(bool?);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == "" || reader.Value == null)
                return null;
            if (reader.Value != null)
            {
                string value = reader.Value.ToString().ToLower();
                return possibleBoolTrueValue.Contains(value);
            }

            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }


    public class DateConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(DateTime?) && reader.Value == null)
                return null;
            try
            {
                return DateTime.ParseExact(reader.Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch
            {

            }

            try
            {
                return DateTime.ParseExact(reader.Value.ToString(), "dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch
            {

            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
