using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Plotter
{
    public partial class BendingMomentCurvaturePlotter : IPlotter
    {
        private float moment1, moment2, curvature1, curvature2;

        public BendingMomentCurvaturePlotter(float moment1, float moment2, float curvature1, float curvature2)
        {
            this.moment1 = moment1;
            this.moment2 = moment2;
            this.curvature1 = curvature1;
            this.curvature2 = curvature2;
        }

        public void Plot(Graphics g)
        {
            // Curve approximation formula: M = a * c^b
            // M: Moment, C: Curvature, a and b: Experimental constants

            float b = (float)((Math.Log(moment1) - Math.Log(moment2)) / (Math.Log(curvature1) - Math.Log(curvature2)));
            float a = (float)(moment1 / Math.Pow(curvature1, b));

            int pointsCount = 20;
            PointF[] points = new PointF[pointsCount];

            for (int c = 0; c < pointsCount; c++)
            {
                points[c] = new PointF(c, (float)(a * Math.Pow(c, b)));
            }

            try
            {
                using (Pen pen = new Pen(Color.Blue, 1))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TranslateTransform(100, 100);
                    g.ScaleTransform(20, 20);
                    g.DrawCurve(pen, points);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values. Please check the inputs.");
            }

        }
    }
}