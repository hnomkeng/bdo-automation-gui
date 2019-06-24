using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BDO_GUI
{
    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}
