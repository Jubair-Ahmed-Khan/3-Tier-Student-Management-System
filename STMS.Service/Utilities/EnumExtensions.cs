namespace STMS.Service.Utilities
{
    public static class EnumExtensions
    {
        public static int GetEnumLength(this Type enumType)
        {
            return Enum.GetNames(enumType).Length;
        }
    }
}
