using System;
using System.Windows.Forms;

namespace Gma.System.MouseKeyHook
{
    public interface IMouseEvents
    {
        event MouseEventHandler MouseMove;

        event EventHandler<MouseEventExtArgs> MouseMoveExt;

        event MouseEventHandler MouseClick;

        event MouseEventHandler MouseDown;

        event EventHandler<MouseEventExtArgs> MouseDownExt;

        event MouseEventHandler MouseUp;

        event EventHandler<MouseEventExtArgs> MouseUpExt;

        event MouseEventHandler MouseDoubleClick;

        event MouseEventHandler MouseDragStarted;

        event EventHandler<MouseEventExtArgs> MouseDragStartedExt;

        event MouseEventHandler MouseDragFinished;

        event EventHandler<MouseEventExtArgs> MouseDragFinishedExt;
    }
}