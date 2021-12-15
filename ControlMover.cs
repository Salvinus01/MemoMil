// Decompiled with JetBrains decompiler
// Type: MemoMil.ControlMover
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoMil
{
  internal class ControlMover
  {
    public static void Init(Control control) => ControlMover.Init(control, ControlMover.Direction.Any);

    public static void Init(Control control, ControlMover.Direction direction) => ControlMover.Init(control, control, direction);

    public static void Init(Control control, Control container, ControlMover.Direction direction)
    {
      bool Dragging = false;
      Point DragStart = Point.Empty;
      control.MouseDown += (MouseEventHandler) ((sender, e) =>
      {
        Dragging = true;
        DragStart = new Point(e.X, e.Y);
        control.Capture = true;
      });
      control.MouseUp += (MouseEventHandler) ((sender, e) =>
      {
        Dragging = false;
        control.Capture = false;
      });
      control.MouseMove += (MouseEventHandler) ((sender, e) =>
      {
        if (!Dragging)
          return;
        if (direction != ControlMover.Direction.Vertical)
          container.Left = Math.Max(0, e.X + container.Left - DragStart.X);
        if (direction == ControlMover.Direction.Horizontal)
          return;
        container.Top = Math.Max(0, e.Y + container.Top - DragStart.Y);
      });
    }

    public enum Direction
    {
      Any,
      Horizontal,
      Vertical,
    }
  }
}
