using System.Drawing;

namespace TextileEngineeringVirtualLaboratory.Plotter
{
    public abstract class PlotterTemplate
    {
        public const int axesRange = 30;
        public const int margin = 600;
        public const int scale = 15;

        public void DrawCoordinateSystem(Graphics g, int range, string labelX, string labelY)
        {
            Font textsFont = new Font("Arial", 1);
            Pen axesPen = new Pen(Color.Black, 0.2f);
            Pen gridPen = new Pen(Color.LightGray, 0.1f);

            // Grid
            for (int x = -range; x <= range; x++)
            {
                g.DrawLine(gridPen, x, -range, x, range);
            }
            for (int y = -range; y <= range; y++)
            {
                g.DrawLine(gridPen, -range, y, range, y);
            }

            // Axes
            g.DrawLine(axesPen, -range, 0, range, 0);
            g.DrawLine(axesPen, 0, -range, 0, range);

            // Labels
            g.DrawString(labelX, textsFont, Brushes.Black, axesRange * 1.08f, 0);
            g.DrawString(labelY, textsFont, Brushes.Black, 0, -axesRange * 1.08f);
        }

        public abstract void Plot(Graphics g);
    }
}
