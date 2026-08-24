using System.Drawing;
using System.Drawing.Drawing2D;
using WindowsFormsApplication1.Textiles;

namespace WindowsFormsApplication1.Renderer
{
    public class WeaveRenderer
    {
        private Weave weave;
        private Graphics weaveGraphics;

        public void Draw(Weave weave, Graphics g)
        {
            if (weave == null || g == null)
                return;

            this.weave = weave;

            weaveGraphics = g;

            DrawTopView();
            DrawCrossSection();
        }

        private void DrawTopView()
        {
            using (Pen warpPen = new Pen(Color.Red, weave.YarnWidth))
            using (Pen weftPen = new Pen(Color.Blue, weave.YarnWidth))
            {
                // Draw warp yarns
                for (int i = 0; i < weave.WarpCount; i++)
                {
                    int x = i * weave.YarnSpacing;

                    weaveGraphics.DrawLine(warpPen, x, 0, x, (weave.WeftCount - 1) * weave.YarnSpacing);
                }

                // Draw weft yarns
                for (int i = 0; i < weave.WeftCount; i++)
                {
                    int y = 0 + i * weave.YarnSpacing;

                    weaveGraphics.DrawLine(weftPen, 0, y, (weave.WarpCount - 1) * weave.YarnSpacing, y);
                }
            }

            // Draw the over/under intersections
            int gap = 18;

            for (int x = 0; x < weave.WarpCount; x++)
            {
                for (int y = 0; y < weave.WeftCount; y++)
                {
                    int cx = x * weave.YarnSpacing;
                    int cy = y * weave.YarnSpacing;

                    using (Pen redPen = new Pen(Color.Red, weave.YarnWidth))
                    using (Pen bluePen = new Pen(Color.Blue, weave.YarnWidth))
                    {
                        if (weave.IsWarpOverWeft[x, y])
                        {
                            weaveGraphics.DrawLine(bluePen, cx - gap, cy, cx + gap, cy);
                            weaveGraphics.DrawLine(redPen, cx, cy - gap, cx, cy + gap);
                        }
                        else
                        {
                            weaveGraphics.DrawLine(redPen, cx, cy - gap, cx, cy + gap);
                            weaveGraphics.DrawLine(bluePen, cx - gap, cy, cx + gap, cy);
                        }
                    }
                }
            }
        }

        private void DrawCrossSection()
        {
            int crossSectionY = weave.WeftCount * weave.YarnSpacing;
            int bottomRowWeft = weave.WeftCount - 1;

            using (Pen weftPen = new Pen(Color.Blue, weave.YarnThickness))
            {
                weftPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Flat);
                PointF[] weftCurveControlPoints = new PointF[weave.WarpCount];

                for (int i = 0; i < weave.WarpCount; i++)
                {
                    int crossSectionX = i * weave.YarnSpacing;
                    bool isWarpOverWeft = weave.IsWarpOverWeft[i, bottomRowWeft];
                    int warpY;
                    int weftY;

                    if (isWarpOverWeft)
                    {
                        warpY = crossSectionY - weave.YarnThickness / 2;
                        weftY = crossSectionY + weave.YarnThickness / 2;
                    }
                    else
                    {
                        warpY = crossSectionY + weave.YarnThickness / 2;
                        weftY = crossSectionY - weave.YarnThickness / 2;
                    }
                    weftCurveControlPoints[i] = new PointF(crossSectionX, weftY);

                    // Draw warp cross-section
                    using (Brush warpBrush = new SolidBrush(Color.Red))
                    {
                        weaveGraphics.FillEllipse(warpBrush, crossSectionX - weave.YarnWidth / 2, warpY - weave.YarnThickness / 2, weave.YarnWidth, weave.YarnThickness);
                    }
                }

                // Draw weft cross-section (curve)
                weaveGraphics.DrawCurve(weftPen, weftCurveControlPoints);
            }
        }    
    }
}
