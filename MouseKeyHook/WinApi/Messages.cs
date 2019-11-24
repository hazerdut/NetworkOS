// This code is distributed under MIT license. 
// Copyright (c) 2015 George Mamaladze
// See license.txt or https://mit-license.org/

namespace Gma.System.MouseKeyHook.WinApi
{
    internal static class Messages
    {
        public const int WM_MOUSEMOVE = 0x200;

        public const int WM_LBUTTONDOWN = 0x201;

        public const int WM_RBUTTONDOWN = 0x204;

        public const int WM_MBUTTONDOWN = 0x207;

        public const int WM_LBUTTONUP = 0x202;

        public const int WM_RBUTTONUP = 0x205;

        public const int WM_MBUTTONUP = 0x208;

        public const int WM_LBUTTONDBLCLK = 0x203;

        public const int WM_RBUTTONDBLCLK = 0x206;

        public const int WM_MBUTTONDBLCLK = 0x209;

        public const int WM_MOUSEWHEEL = 0x020A;

        public const int WM_XBUTTONDOWN = 0x20B;

        public const int WM_XBUTTONUP = 0x20C;

        public const int WM_XBUTTONDBLCLK = 0x20D;

        public const int WM_MOUSEHWHEEL = 0x20E;

        public const int WM_KEYDOWN = 0x100;

        public const int WM_KEYUP = 0x101;

        public const int WM_SYSKEYDOWN = 0x104;

        public const int WM_SYSKEYUP = 0x105;
    }
}