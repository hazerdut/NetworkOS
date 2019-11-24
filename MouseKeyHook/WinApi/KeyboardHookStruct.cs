using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.WinApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct KeyboardHookStruct
    {
        public int VirtualKeyCode;

        public int ScanCode;

        public int Flags;

        public int Time;

        public int ExtraInfo;
    }
}