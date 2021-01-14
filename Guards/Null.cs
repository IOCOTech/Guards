using Guards.Attributes;
using System;

namespace Guards
{
    public static partial class Guard
    {
        /// <summary>
        ///     Checks that Value is NOT null. Throws a ArgumentNullException if Value is null with the
        ///     name of the parameter that causes this exception.
        /// </summary>
        /// <param name="paramName">Name of parameter that caused the exception</param>
        /// <param name="value">The value that will be checked for null</param>
        /// <exception cref="ArgumentNullException">The <paramref name="value" /> parameter is null.</exception>
        public static void ArgumentNotNull<T>([ValidatedNotNull] T value, string paramName = nameof(T))
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        ///     Checks that Value is NOT null. Throws a ArgumentNullException if Value is null with the
        ///     specified error message and name of the parameter that causes this exception.
        /// </summary>
        /// <param name="paramName">Name of parameter that caused the exception</param>
        /// <param name="value">The value that will be checked for null</param>
        /// <param name="message">A message that describes the error</param>
        /// <exception cref="ArgumentNullException">The <paramref name="value" /> parameter is null.</exception>
        public static void ArgumentNotNull<T>([ValidatedNotNull] T value, string paramName, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName, message);
            }
        }
    }
}
