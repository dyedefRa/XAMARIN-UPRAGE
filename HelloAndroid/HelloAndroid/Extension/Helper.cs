using Newtonsoft.Json;

namespace HelloAndroid.Extension
{
    public static class Helper
    {
        public static string ToJson(this object item)
        {
            return JsonConvert.SerializeObject(item);
        }
        public static T JsonToData<T>(this string item)
        {
            return JsonConvert.DeserializeObject<T>(item);
        }
    }
}