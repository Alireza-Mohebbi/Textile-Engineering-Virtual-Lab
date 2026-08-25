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
        public Weave NewWeave { get; set; }
        private Rectangle[,] interactiveIntersectionsOfWeave;
        private const int marginFromScreenCoord = 50;

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
            NewWeave.YarnThickness = (int)yarnThicknessInput.Value;
            NewWeave.YarnWidth = (int)yarnWidthInput.Value;
            NewWeave.YarnSpacing = (int)yarnSpacingInput.Value;
            NewWeave.RepeatX = (int)repeatXInput.Value;
            NewWeave.RepeatY = (int)repeatYInput.Value;
            DefineInteractiveIntersectionsOfWeave();

            insertWeaveButton.Enabled = true;

            Invalidate();
        }

        private void DefineInteractiveIntersectionsOfWeave()
        {
            interactiveIntersectionsOfWeave = new Rectangle[NewWeave.WarpCount, NewWeave.WeftCount];

            for (int i = 0; i < NewWeave.WarpCount; i++)
            {
                for (int j = 0; j < NewWeave.WeftCount; j++)
                {
                    int x = marginFromScreenCoord + i * NewWeave.YarnSpacing;
                    int y = marginFromScreenCoord + j * NewWeave.YarnSpacing;
                    interactiveIntersectionsOfWeave[i, j] = new Rectangle(x - 15, y - 15, 30, 30);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (NewWeave == null)
            {
                return;
            }
            for (int x = 0; x < NewWeave.WarpCount; x++)
            {
                for (int y = 0; y < NewWeave.WeftCount; y++)
                {
                    if (interactiveIntersectionsOfWeave[x, y].Contains(e.Location))
                    {
                        NewWeave.IsWarpOverWeft[x, y] = !(NewWeave.IsWarpOverWeft[x, y]);
                        Invalidate();
                        return;
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(marginFromScreenCoord, marginFromScreenCoord);

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