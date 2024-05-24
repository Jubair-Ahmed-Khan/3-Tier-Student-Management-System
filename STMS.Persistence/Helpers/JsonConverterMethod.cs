using Newtonsoft.Json;

namespace STMS.Persistence.Helpers
{
    //JSON Serialize and Deserialize Method
    public static class JsonConverterMethod
    {
        //Serialize
        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        //Deserialize
        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
