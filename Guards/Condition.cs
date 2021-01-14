using System;

namespace Guards
{
    /// <summary>
    /// Helpers for implementing NetAnalyzers
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        ///     Checks if Value is true. Throws an ArgumentException if Value is false
        ///     with the specified error message and name of the parameter that causes this exception.
        /// </summary>
        /// <param name="paramName">Name of parameter that caused the exception</param>
        /// <param name="value">The value that will be checked for null</param>
        /// <param name="message">A message that describes the error</param>
        /// <exception cref="ArgumentException">The <paramref name="value" /> parameter is false.</exception>
        public static void ConditionIsTrue(bool value, string message, string paramName)
        {
            if (!value)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        /// <summary>
        ///     Checks if Value is true. Throws an ArgumentException if Value is false
        ///     with the specified error message.
        /// </summary>
        /// <param name="value">The value that will be checked for null</param>
        /// <param name="message">A message that describes the error</param>
        /// <exception cref="ArgumentException">The <paramref name="value" /> parameter is false.</exception>
        public static void ConditionIsTrue(bool value, string message)
        {
            if (!value)
            {
                throw new ArgumentException(message);
            }
        }
    }
}