using System;
using System.Diagnostics.Contracts;

namespace PureAssembly
{
    public static class HasNoState
    {
        [Pure]
        public static int PureMethod()
        {
            return 101;
        }
    }
}
