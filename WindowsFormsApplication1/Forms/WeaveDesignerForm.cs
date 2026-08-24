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
        public Weave Weave { get; set; }
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
            Weave = new Weave((int)warpCountInput.Value, (int)weftCountInput.Value);

            Weave.YarnThickness = (int)yarnThicknessInput.Value;
            Weave.YarnWidth = (int)yarnWidthInput.Value;
            Weave.YarnSpacing = (int)yarnSpacingInput.Value;
            Weave.RepeatX = (int)repeatXInput.Value;
            Weave.RepeatY = (int)repeatYInput.Value;

            DefineInteractiveIntersectionsOfWeave();

            Invalidate();
        }

        private void DefineInteractiveIntersectionsOfWeave()
        {
            interactiveIntersectionsOfWeave = new Rectangle[Weave.WarpCount, Weave.WeftCount];

            for (int i = 0; i < Weave.WarpCount; i++)
            {
                for (int j = 0; j < Weave.WeftCount; j++)
                {
                    int x = marginFromScreenCoord + i * Weave.YarnSpacing;
                    int y = marginFromScreenCoord + j * Weave.YarnSpacing;
                    interactiveIntersectionsOfWeave[i, j] = new Rectangle(x - 15, y - 15, 30, 30);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Weave == null)
            {
                return;
            }
            for (int x = 0; x < Weave.WarpCount; x++)
            {
                for (int y = 0; y < Weave.WeftCount; y++)
                {
                    if (interactiveIntersectionsOfWeave[x, y].Contains(e.Location))
                    {
                        Weave.IsWarpOverWeft[x, y] = !(Weave.IsWarpOverWeft[x, y]);
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
            weaveRenderer.Draw(Weave, e.Graphics);
        }

        private void insertWeaveButton_Click(object sender, EventArgs e)
        {
            if (Weave == null)
            {
                MessageBox.Show("Please Make a weave first.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}