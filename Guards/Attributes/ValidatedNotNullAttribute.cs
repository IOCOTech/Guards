using System;
using System.Collections.Generic;
using System.Text;

namespace Guards.Attributes
{
    /// <summary>
    /// ValidatedNotNullAttribute signals to static code analysis (CA1062)
    /// to trust that this function will check the marked parameters for null references.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
