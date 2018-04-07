namespace JenkinsClient.Utilities
{
    using System;

    public static class ValidationExtensions
    {
        public static void EnsureIsNotNull<T>(this T parameter, string name = null)
            where T : class
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
