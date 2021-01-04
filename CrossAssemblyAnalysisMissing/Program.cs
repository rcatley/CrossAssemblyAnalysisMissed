using System;
using System.Diagnostics.Contracts;
using PureAssembly;

namespace CrossAssemblyAnalysisMissing
{
    class Program
    {
        static void Main(string[] args)
        {
            //without the discard, the following line will cause the build to fail as expected.
            var _ = PureMethod();

            //the following line should also require a discard:
            HasNoState.PureMethod();
            Console.WriteLine("Test failed! This should not compile as CA1806 has a severity of error.");
        }

        [Pure]
        public static int PureMethod()
        {
            return 101;
        }
    }
}
