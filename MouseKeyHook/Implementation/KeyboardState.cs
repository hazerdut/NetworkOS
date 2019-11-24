using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook.Implementation
{
    public class KeyboardState
    {
        private readonly byte[] m_KeyboardStateNative;

        private KeyboardState(byte[] keyboardStateNative)
        {
            m_KeyboardStateNative = keyboardStateNative;
        }
        public static KeyboardState GetCurrent()
        {
            var keyboardStateNative = new byte[256];
            KeyboardNativeMethods.GetKeyboardState(keyboardStateNative);
            return new KeyboardState(keyboardStateNative);
        }

        internal byte[] GetNativeState()
        {
            return m_KeyboardStateNative;
        }
        public bool IsDown(Keys key)
        {
            if ((int)key < 256) return IsDownRaw(key);
            if (key == Keys.Alt) return IsDownRaw(Keys.LMenu) || IsDownRaw(Keys.RMenu);
            if (key == Keys.Shift) return IsDownRaw(Keys.LShiftKey) || IsDownRaw(Keys.RShiftKey);
            if (key == Keys.Control) return IsDownRaw(Keys.LControlKey) || IsDownRaw(Keys.RControlKey);
            return false;
        }

        private bool IsDownRaw(Keys key)
        {
            var keyState = GetKeyState(key);
            var isDown = GetHighBit(keyState);
            return isDown;
        }

        public bool IsToggled(Keys key)
        {
            var keyState = GetKeyState(key);
            var isToggled = GetLowBit(keyState);
            return isToggled;
        }

        public bool AreAllDown(IEnumerable<Keys> keys)
        {
            return keys.All(IsDown);
        }

        private byte GetKeyState(Keys key)
        {
            var virtualKeyCode = (int) key;
            if (virtualKeyCode < 0 || virtualKeyCode > 255)
                throw new ArgumentOutOfRangeException("key", key, "The value must be between 0 and 255.");
            return m_KeyboardStateNative[virtualKeyCode];
        }

        private static bool GetHighBit(byte value)
        {
            return value >> 7 != 0;
        }

        private static bool GetLowBit(byte value)
        {
            return (value & 1) != 0;
        }
    }
}