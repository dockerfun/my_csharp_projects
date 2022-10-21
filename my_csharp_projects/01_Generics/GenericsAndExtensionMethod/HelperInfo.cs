
using AttributeAndFields;

namespace CustomExtension
{
    public static class HelperInfo
    {
        public static string GetSql<T>(this A<T> _)
        {
            return _.GetData();
        }
    }
}