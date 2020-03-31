using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Chemistree_GUI_V1
{
    class RoundedPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 20, 20, 195, 100);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 70, 70, 280, 60);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 40, 50, 50, -10, 100);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 30, 30, 35, 100, 90);
            this.Region = new Region(GraphPath);
        }
    }
}
