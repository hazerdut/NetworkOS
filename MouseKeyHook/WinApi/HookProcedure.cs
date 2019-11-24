using System;

namespace Gma.System.MouseKeyHook.WinApi
{
    ///     http://msdn.microsoft.com/library/default.asp?url=/library/en-us/winui/winui/windowsuserinterface/windowing/hooks/hookreference/hookfunctions/callwndproc.asp
    public delegate IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam);
}