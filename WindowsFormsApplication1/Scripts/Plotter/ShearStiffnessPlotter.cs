using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Plotter
{
    public partial class ShearStiffnessPlotter : AbstractPlotter
    {
        private float stress1, stress2;     // (MPa)
        private float strain1, strain2;

        public ShearStiffnessPlotter(float stress1, float stress2, float strain1, float strain2)
        {
            this.stress1 = stress1;
            this.stress2 = stress2;
            this.strain1 = strain1;
            this.strain2 = strain2;
        }

        public override void Plot(Graphics g)
        {
            // Curve approximation formula: Stress = a * Strain^b
            // a and b: Experimental constants

            float b = ((float)Math.Log(stress1) - (float)Math.Log(stress2)) / ((float)Math.Log(strain1) - (float)Math.Log(strain2));
            float a = stress1 / (float)Math.Pow(strain1, b);
            List<PointF> points = new List<PointF>();

            for (int x = 0; x < axesRange; x++)
            {
                float y = (float)(a * Math.Pow(x, b));
                if (y > axesRange)
                {
                    break;
                }
                points.Add(new PointF(x, y));
            }

            try
            {
                using (Pen pen = new Pen(Color.Blue, 0.5f))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TranslateTransform(margin, margin);
                    g.ScaleTransform(scale, scale);

                    DrawCoordinateSystem(g, axesRange, "Shear Strain", "Shear Stress (MPa)");
                    g.DrawCurve(pen, points.ToArray());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values. Please check the inputs.");
            }

        }
    }
}