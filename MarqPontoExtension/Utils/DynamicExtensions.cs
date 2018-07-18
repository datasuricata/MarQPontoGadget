using Newtonsoft.Json.Linq;

namespace MarqPontoExtension.Utils
{
    public static class DynamicExtensions
    {
        public static T ToObject<T>(this object obj) where T : class
        {
            JObject jObj = JObject.FromObject(obj);
            var result = jObj.ToObject(typeof(T));

            return result as T;
        }
    }
}
