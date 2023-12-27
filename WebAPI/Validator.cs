namespace WebAPI
{
    public static class Validator
    {
        public static void GuidValidator(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid), "Идентификатор не определён.");
            }
        }

        public static void StringValidator(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str), "Название не определено.");
            }
        }
    }
}
