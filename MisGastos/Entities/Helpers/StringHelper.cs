using System;

namespace MisGastos.Entities.Helpers
{
    public static class StringHelper
    {
        public static string ToUpperFirstLetter(string value)
        {
            return value.Substring(0,1).ToUpper() + value.Substring(1).ToLowerInvariant();
        }
    }
}