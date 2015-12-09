using System.Diagnostics;
using MbTest4Net.Exception;

namespace MbTest4Net.Helpers
{
    public static class Check
    {
        public static bool UseAssertions { get; set; }

        private static bool UseExceptions
        {
            get { return !UseAssertions; }
        }

        public static void Require(bool assertion, string message)
        {
            if (UseExceptions)
            {
                if (assertion)
                {
                    throw new MbTest4NetException(message);
                }
            }
            else
            {
                Trace.Assert(!assertion, "Precondition: " + message);
            }
        }
    }
}