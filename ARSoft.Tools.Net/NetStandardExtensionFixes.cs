using System;

namespace ARSoft.Tools.Net
{
    public static class NetStandardExtensionFixes
    {
        public static StringComparison GetDefaultIgnoreCaseComparison()
        {
#if NETSTANDARD
            return StringComparison.OrdinalIgnoreCase;
#else
            return StringComparison.InvariantCultureIgnoreCase;
#endif
        }
    }
}
