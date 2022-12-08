﻿using System;

namespace ProgramInput.Internal.PInvoke.Mouse
{
    [Flags]
    internal enum MouseInputEvent : uint
    {
        Move = 0x0001,
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        RightDown = 0x0008,
        RightUp = 0x0010,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        XDown = 0x0080,
        XUp = 0x0100,
        Wheel = 0x0800,
        HorizontalWheel = 0x01000,
        MoveNoCoalesce = 0x2000,
        VirtualDesktop = 0x4000,
        Absolute = 0x8000,
    }
}
