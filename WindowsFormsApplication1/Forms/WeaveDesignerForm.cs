using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApplication1.Renderer;
using WindowsFormsApplication1.Textiles;

namespace WindowsFormsApplication1
{
    public partial class WeaveDesigner : Form
    {
        public Weave DesignedWeave { get; set; }
        private Rectangle[,] interactiveIntersectionsOfWeave;

        private const int marginFromScreenCoord = 50;
        private const float displayScale = 50f;

        public WeaveDesigner()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
        }

        private void weaveButton_Click(object sender, EventArgs e)
        {
            NewWeave = new Weave((int)warpCountInput.Value, (int)weftCountInput.Value);
            NewWeave.YarnThickness = (float)yarnThicknessInput.Value;
            NewWeave.YarnWidth = (float)yarnWidthInput.Value;
            NewWeave.YarnSpacing = (float)yarnSpacingInput.Value;
            NewWeave.RepeatX = (int)repeatXInput.Value;
            NewWeave.RepeatY = (int)repeatYInput.Value;

            DefineInteractiveIntersectionsOfWeave();
            insertWeaveButton.Enabled = true;
            Invalidate();
        }

        private void DefineInteractiveIntersectionsOfWeave()
        {
            if (NewWeave == null)
                return;

            interactiveIntersectionsOfWeave = new Rectangle[NewWeave.WarpCount, NewWeave.WeftCount];
            int interactiveAreaSize = Math.Max(10, (int)(NewWeave.YarnWidth * displayScale));

            for (int i = 0; i < NewWeave.WarpCount; i++)
            {
                for (int j = 0; j < NewWeave.WeftCount; j++)
                {
                    int x = marginFromScreenCoord + (int)(i * NewWeave.YarnSpacing * displayScale);
                    int y = marginFromScreenCoord + (int)(j * NewWeave.YarnSpacing * displayScale);

                    interactiveIntersectionsOfWeave[i, j] = new Rectangle(x - interactiveAreaSize / 2, y - interactiveAreaSize / 2, interactiveAreaSize, interactiveAreaSize);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (NewWeave == null || interactiveIntersectionsOfWeave == null)
            {
                return;
            }

            for (int x = 0; x < NewWeave.WarpCount; x++)
            {
                for (int y = 0; y < NewWeave.WeftCount; y++)
                {
                    if (interactiveIntersectionsOfWeave[x, y].Contains(e.Location))
                    {
                        NewWeave.IsWarpOverWeft[x, y] = !NewWeave.IsWarpOverWeft[x, y];
                        Invalidate();
                        return;
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (NewWeave == null)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(marginFromScreenCoord, marginFromScreenCoord);
            e.Graphics.ScaleTransform(displayScale, displayScale);

            WeaveRenderer weaveRenderer = new WeaveRenderer();
            weaveRenderer.Draw(NewWeave, e.Graphics);
        }

        private void insertWeaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}