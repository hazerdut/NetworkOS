using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook
{
    public class KeyEventArgsExt : KeyEventArgs
    {
        public KeyEventArgsExt(Keys keyData)
            : base(keyData)
        {
        }

        internal KeyEventArgsExt(Keys keyData, int scanCode, int timestamp, bool isKeyDown, bool isKeyUp,
            bool isExtendedKey)
            : this(keyData)
        {
            ScanCode = scanCode;
            Timestamp = timestamp;
            IsKeyDown = isKeyDown;
            IsKeyUp = isKeyUp;
            IsExtendedKey = isExtendedKey;
        }
        public int ScanCode { get; }

        public int Timestamp { get; }

        public bool IsKeyDown { get; }

        public bool IsKeyUp { get; }

        public bool IsExtendedKey { get; }

        internal static KeyEventArgsExt FromRawDataApp(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            //http://msdn.microsoft.com/en-us/library/ms644984(v=VS.85).aspx

            const uint maskKeydown = 0x40000000; // for bit 30
            const uint maskKeyup = 0x80000000; // for bit 31
            const uint maskExtendedKey = 0x1000000; // for bit 24

            var timestamp = Environment.TickCount;

            var flags = (uint) lParam.ToInt64();

            //bit 30 Specifies the previous key state. The value is 1 if the key is down before the message is sent; it is 0 if the key is up.
            var wasKeyDown = (flags & maskKeydown) > 0;
            //bit 31 Specifies the transition state. The value is 0 if the key is being pressed and 1 if it is being released.
            var isKeyReleased = (flags & maskKeyup) > 0;
            //bit 24 Specifies the extended key state. The value is 1 if the key is an extended key, otherwise the value is 0.
            var isExtendedKey = (flags & maskExtendedKey) > 0;


            var keyData = AppendModifierStates((Keys) wParam);
            var scanCode = (int) (((flags & 0x10000) | (flags & 0x20000) | (flags & 0x40000) | (flags & 0x80000) |
                                   (flags & 0x100000) | (flags & 0x200000) | (flags & 0x400000) | (flags & 0x800000)) >>
                                  16);

            var isKeyDown = !isKeyReleased;
            var isKeyUp = wasKeyDown && isKeyReleased;

            return new KeyEventArgsExt(keyData, scanCode, timestamp, isKeyDown, isKeyUp, isExtendedKey);
        }

        internal static KeyEventArgsExt FromRawDataGlobal(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;
            var keyboardHookStruct =
                (KeyboardHookStruct) Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

            var keyData = AppendModifierStates((Keys) keyboardHookStruct.VirtualKeyCode);

            var keyCode = (int) wParam;
            var isKeyDown = keyCode == Messages.WM_KEYDOWN || keyCode == Messages.WM_SYSKEYDOWN;
            var isKeyUp = keyCode == Messages.WM_KEYUP || keyCode == Messages.WM_SYSKEYUP;

            const uint maskExtendedKey = 0x1;
            var isExtendedKey = (keyboardHookStruct.Flags & maskExtendedKey) > 0;

            return new KeyEventArgsExt(keyData, keyboardHookStruct.ScanCode, keyboardHookStruct.Time, isKeyDown,
                isKeyUp, isExtendedKey);
        }

        // See more at http://www.tech-archive.net/Archive/DotNet/microsoft.public.dotnet.framework.windowsforms/2008-04/msg00127.html #

        private static bool CheckModifier(int vKey)
        {
            return (KeyboardNativeMethods.GetKeyState(vKey) & 0x8000) > 0;
        }

        private static Keys AppendModifierStates(Keys keyData)
        {
            // Is Control being held down?
            var control = CheckModifier(KeyboardNativeMethods.VK_CONTROL);
            // Is Shift being held down?
            var shift = CheckModifier(KeyboardNativeMethods.VK_SHIFT);
            // Is Alt being held down?
            var alt = CheckModifier(KeyboardNativeMethods.VK_MENU);


            return keyData |
                   (control ? Keys.Control : Keys.None) |
                   (shift ? Keys.Shift : Keys.None) |
                   (alt ? Keys.Alt : Keys.None);
        }
    }
}