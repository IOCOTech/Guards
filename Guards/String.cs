using Guards.Attributes;
using System;

namespace Guards
{
    public static partial class Guard
    {

        /// <summary>
        ///     Checks if string Value is null or empty. Throws a ArgumentNullException if Value is null and 
        ///     a ArgumentException if Value is an empty string with the specified error message.
        /// </summary>
        /// <param name="paramName">Name of parameter that caused the exception</param>
        /// <param name="value">The value that will be checked for null</param>
        /// <param name="message">A message that describes the error</param>
        /// <exception cref="ArgumentNullException">The <paramref name="value" /> parameter is null.</exception>
        /// <exception cref="ArgumentException">The <paramref name="value" /> parameter is empty.</exception>
        public static void ArgumentNotNullOrEmpty([ValidatedNotNull] string value, string message)
        {
            ArgumentNotNull(value, nameof(value), message);
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        ///     Checks if string value is null or empty. Throws a ArgumentNullException if Value is null and 
        ///     a ArgumentException if Value is empty with the specified error message and name of the parameter that causes this exception.
        /// </summary>
        /// <param name="paramName">Name of parameter that caused the exception</param>
        /// <param name="value">The value that will be checked for null</param>
        /// <param name="message">A message that describes the error. If null, then the message will default to 'Value cannot be null.'</param>
        /// <exception cref="ArgumentNullException">The <paramref name="value" /> parameter is null.</exception>
        /// <exception cref="ArgumentException">The <paramref name="value" /> parameter is empty.</exception>
        public static void ArgumentNotNullOrEmpty([ValidatedNotNull] string value, string message, string paramName)
        {
            if (message == null)
                message = "Value cannot be null.";

            ArgumentNotNull(value, paramName, message);
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException(message, paramName);
            }
        }
    }
}
