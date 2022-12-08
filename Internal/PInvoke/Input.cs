﻿using System.Runtime.InteropServices;

namespace ProgramInput.Internal.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Input
    {
        public static readonly int Size = Marshal.SizeOf<Input>();

        public InputType Type;

        public InputUnion Union;
    }
}
