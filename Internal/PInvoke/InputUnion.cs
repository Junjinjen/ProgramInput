﻿using ProgramInput.Internal.PInvoke.Keyboard;
using ProgramInput.Internal.PInvoke.Mouse;
using System.Runtime.InteropServices;

namespace ProgramInput.Internal.PInvoke
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct InputUnion
    {
        [FieldOffset(0)]
        public MouseInput MouseInput;

        [FieldOffset(0)]
        public KeyboardInput KeyboardInput;
    }
}
