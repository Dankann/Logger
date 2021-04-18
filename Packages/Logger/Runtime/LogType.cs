﻿using System;

namespace Dankann.Debug
{
    [Flags]
    public enum LogType
    {
        Error = 1,
        Assert = 2,
        Warning = 4,
        Log = 8,
        Exception = 16
    }
}
