using System.Text;

namespace PokeMaui.Business.Helpers
{
    internal static class FormattingHelpers
    {

        #region UppercaseFirstCharacter
        /// <summary>
        /// Uppercase the first character of a string using a StringBuilder
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static  string UppercaseFirstCharacter(string name)
        {
            var builder = new StringBuilder();

            var nameToFormat = name.ToLower().Trim();

            var results = builder
                .Append(char.ToUpper(nameToFormat[0]))
                .Append(nameToFormat[1..])
                .ToString();

            if (!String.IsNullOrEmpty(results)) return results;

            builder.Clear();
            return string.Empty;
        }
        #endregion
    }
}
