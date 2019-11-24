using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.WinApi
{
    internal static class MouseNativeMethods
    {
        ///     http://msdn.microsoft.com/en-us/library/ms646258(VS.85).aspx
        /// </remarks>
        [DllImport("user32")]
        internal static extern int GetDoubleClickTime();
    }
}