using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public static class SystemClock
    {
        private static DateTime? _customDate;

        public static DateTime Now
        {
            get
            {
                return _customDate ?? DateTime.UtcNow;
            }
        }

        public static void Set(DateTime customDate) => _customDate = customDate;

        public static void Reset() => _customDate = null;
    }
}