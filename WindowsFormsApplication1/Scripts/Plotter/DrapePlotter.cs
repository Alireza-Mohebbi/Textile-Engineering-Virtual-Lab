using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApplication1.Textiles;

namespace WindowsFormsApplication1.Plotter
{
    public partial class DrapePlotter : AbstractPlotter
    {
        private Weave weave;
        private float bendingRigidity;
        private float arialDensity;
        private float length;
        private float secondMomentOfInertia;

        public DrapePlotter(Weave weave)
        {
            this.weave = weave;
            secondMomentOfInertia = weave.FabricWidth * (float)Math.Pow(weave.FabricThickness, 3) / 12;
            bendingRigidity = weave.YoungsModulusY * secondMomentOfInertia;
            arialDensity = weave.FabricArialDensity;
            length = weave.FabricHeight;
        }

        public override void Plot(Graphics g)
        {
            int plotDomainX = 30;
            PointF[] points = new PointF[plotDomainX];

            for (int x = 0; x < plotDomainX; x++)
            {
                float y = ((arialDensity * x * x) / (24 * bendingRigidity)) * ((6 * length * length) - (4 * length * x) + (x * x));
                points[x] = new PointF(x, y);
            }

            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TranslateTransform(100, 100);
                g.ScaleTransform(5f, 5f);

                PointF clampWallStartPoint = new PointF(points[0].X, points[0].Y - 20);
                PointF clampWallEndPoint = new PointF(points[0].X, points[0].Y + 20);

                g.DrawCurve(Pens.Blue, points);
                g.DrawLine(Pens.Black, clampWallStartPoint, clampWallEndPoint);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values. Please check the inputs.");
            }

            // Textual info
            g.DrawString(
                "Bendinf Rigidity = " + bendingRigidity.ToString(),
                new Font("Arial", 10),
                Brushes.Black,
                20,
                20);

            g.DrawString(
                "Arial Density = " + arialDensity.ToString(),
                new Font("Arial", 10),
                Brushes.Black,
                20,
                40);

            g.DrawString(
                "Length = " + length.ToString("0.000"),
                new Font("Arial", 10),
                Brushes.Black,
                20,
                60);
        }
    }
}