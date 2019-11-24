using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook.WinApi
{
    internal static class KeyboardNativeMethods
    {
        //values from Winuser.h in Microsoft SDK.
        public const byte VK_SHIFT = 0x10;

        public const byte VK_CAPITAL = 0x14;
        public const byte VK_NUMLOCK = 0x90;
        public const byte VK_LSHIFT = 0xA0;
        public const byte VK_RSHIFT = 0xA1;
        public const byte VK_LCONTROL = 0xA2;
        public const byte VK_RCONTROL = 0xA3;
        public const byte VK_LMENU = 0xA4;
        public const byte VK_RMENU = 0xA5;
        public const byte VK_LWIN = 0x5B;
        public const byte VK_RWIN = 0x5C;
        public const byte VK_SCROLL = 0x91;

        public const byte VK_INSERT = 0x2D;

        //may be possible to use these aggregates instead of L and R separately (untested)
        public const byte VK_CONTROL = 0x11;

        public const byte VK_MENU = 0x12;

        public const byte VK_PACKET = 0xE7;

        //Used to pass Unicode characters as if they were keystrokes. The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods
        private static int lastVirtualKeyCode;

        private static int lastScanCode;
        private static byte[] lastKeyState = new byte[255];
        private static bool lastIsDead;

        internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int fuState, out char[] chars)
        {
            var dwhkl = GetActiveKeyboard();
            var scanCode = MapVirtualKeyEx(virtualKeyCode, (int) MapType.MAPVK_VK_TO_VSC, dwhkl);
            TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, dwhkl, out chars);
        }

        internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState,
            out char[] chars)
        {
            var dwhkl = GetActiveKeyboard(); //get the active keyboard layout
            TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, dwhkl, out chars);
        }

        internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState, IntPtr dwhkl,
            out char[] chars)
        {
            var pwszBuff = new StringBuilder(64);
            var keyboardState = KeyboardState.GetCurrent();
            var currentKeyboardState = keyboardState.GetNativeState();
            var isDead = false;

            if (keyboardState.IsDown(Keys.ShiftKey))
                currentKeyboardState[(byte) Keys.ShiftKey] = 0x80;

            if (keyboardState.IsToggled(Keys.CapsLock))
                currentKeyboardState[(byte) Keys.CapsLock] = 0x01;

            var relevantChars = ToUnicodeEx(virtualKeyCode, scanCode, currentKeyboardState, pwszBuff, pwszBuff.Capacity,
                fuState, dwhkl);

            switch (relevantChars)
            {
                case -1:
                    isDead = true;
                    ClearKeyboardBuffer(virtualKeyCode, scanCode, dwhkl);
                    chars = null;
                    break;

                case 0:
                    chars = null;
                    break;

                case 1:
                    if (pwszBuff.Length > 0) chars = new[] {pwszBuff[0]};
                    else chars = null;
                    break;

                // Two or more (only two of them is relevant)
                default:
                    if (pwszBuff.Length > 1) chars = new[] {pwszBuff[0], pwszBuff[1]};
                    else chars = new[] {pwszBuff[0]};
                    break;
            }

            if (lastVirtualKeyCode != 0 && lastIsDead)
            {
                if (chars != null)
                {
                    var sbTemp = new StringBuilder(5);
                    ToUnicodeEx(lastVirtualKeyCode, lastScanCode, lastKeyState, sbTemp, sbTemp.Capacity, 0, dwhkl);
                    lastIsDead = false;
                    lastVirtualKeyCode = 0;
                }

                return;
            }

            lastScanCode = scanCode;
            lastVirtualKeyCode = virtualKeyCode;
            lastIsDead = isDead;
            lastKeyState = (byte[]) currentKeyboardState.Clone();
        }


        private static void ClearKeyboardBuffer(int vk, int sc, IntPtr hkl)
        {
            var sb = new StringBuilder(10);

            int rc;
            do
            {
                var lpKeyStateNull = new byte[255];
                rc = ToUnicodeEx(vk, sc, lpKeyStateNull, sb, sb.Capacity, 0, hkl);
            } while (rc < 0);
        }

        private static IntPtr GetActiveKeyboard()
        {
            var hActiveWnd = ThreadNativeMethods.GetForegroundWindow(); //handle to focused window
            int dwProcessId;
            var hCurrentWnd = ThreadNativeMethods.GetWindowThreadProcessId(hActiveWnd, out dwProcessId);
            //thread of focused window
            return GetKeyboardLayout(hCurrentWnd); //get the layout identifier for the thread whose window is focused
        }

        [Obsolete("Use ToUnicodeEx instead")]
        [DllImport("user32.dll")]
        public static extern int ToAscii(
            int uVirtKey,
            int uScanCode,
            byte[] lpbKeyState,
            byte[] lpwTransKey,
            int fuState);

        [DllImport("user32.dll")]
        public static extern int ToUnicodeEx(int wVirtKey,
            int wScanCode,
            byte[] lpKeyState,
            [Out] [MarshalAs(UnmanagedType.LPWStr, SizeConst = 64)] StringBuilder pwszBuff,
            int cchBuff,
            int wFlags,
            IntPtr dwhkl);

        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        /// <remarks>http://msdn.microsoft.com/en-us/library/ms646301.aspx</remarks>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int MapVirtualKeyEx(int uCode, int uMapType, IntPtr dwhkl);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetKeyboardLayout(int dwLayout);

        internal enum MapType
        {
            MAPVK_VK_TO_VSC,

            MAPVK_VSC_TO_VK,

            MAPVK_VK_TO_CHAR,

            MAPVK_VSC_TO_VK_EX
        }
    }
}