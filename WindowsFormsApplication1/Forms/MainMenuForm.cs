using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms;
using WindowsFormsApplication1.Plotter;
using WindowsFormsApplication1.Renderer;
using WindowsFormsApplication1.Textiles;


namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        private Weave Weave { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void newWeaveButton_Click(object sender, EventArgs e)
        {
            WeaveDesigner weaveDesigner = new WeaveDesigner();

            if (weaveDesigner.ShowDialog() == DialogResult.OK)
            {
                Weave = weaveDesigner.NewWeave;
                float scale;

                if (Weave.WarpCount > Weave.WeftCount)
                {
                    scale = (float)1 / Weave.WarpCount;
                }
                else
                {
                    scale = (float)1 / Weave.WeftCount;
                }

                Graphics g = weaveViewer.CreateGraphics();
                g.Clear(Color.White);
                g.ScaleTransform(scale, scale);
                g.TranslateTransform(10f, 10f);

                weavePropertiesButton.Enabled = true;

                WeaveRenderer weaveRenderer = new WeaveRenderer();
                weaveRenderer.Draw(Weave, g);
            }
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            Graphics g = plotViewer.CreateGraphics();
            g.Clear(Color.White);
            g.ScaleTransform(0.5f, 0.5f);

            switch (plotTypeComboBox.SelectedIndex)
            {
                case 1 :
                    AbstractPlotter bendingMomentCurvaturePlotter = new BendingMomentCurvaturePlotter(
                    (float)input1.Value,
                    (float)input2.Value,
                    (float)input3.Value,
                    (float)input4.Value);
                    bendingMomentCurvaturePlotter.Plot(g); break;

                case 3 :
                    AbstractPlotter drapePlotter = new DrapePlotter(Weave);
                    drapePlotter.Plot(g); break;

                default : break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(plotTypeComboBox.SelectedIndex)
            {
                // Stress-Strain inputs setting
                case 0 :
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Stress 1";
                    inputLabel2.Text = "Strain 1";
                    inputLabel3.Text = "Stress 2";
                    inputLabel4.Text = "Strain 2"; break;

                // Bendind moment-Curvature inputs setting
                case 1 :
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Bending Moment 1";
                    inputLabel2.Text = "Curvature 1";
                    inputLabel3.Text = "Bending Moment 2";
                    inputLabel4.Text = "Curvature 2"; break;

                // Shear stiffness inputs setting
                case 2:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Shear Stress 1";
                    inputLabel2.Text = "Shear Strain 1";
                    inputLabel3.Text = "Shear Stress 2";
                    inputLabel4.Text = "Shear Strain 2"; break;

                // Drape curve inputs setting
                case 3:
                    input1.Visible = false;
                    input2.Visible = false;
                    input3.Visible = false;
                    input4.Visible = false;
                    inputLabel1.Text = "";
                    inputLabel2.Text = "";
                    inputLabel3.Text = "";
                    inputLabel4.Text = ""; break;

                default:
                    input1.Visible = false;
                    input2.Visible = false;
                    input3.Visible = false;
                    input4.Visible = false;
                    inputLabel1.Text = "";
                    inputLabel2.Text = "";
                    inputLabel3.Text = "";
                    inputLabel4.Text = ""; break;
            }
        }

        private void weavePropertiesButton_Click(object sender, EventArgs e)
        {
            WeavePropertiesConfigurer weavePropertiesConfigurer = new WeavePropertiesConfigurer(Weave);
            if (weavePropertiesConfigurer.ShowDialog() == DialogResult.OK)
            {
                Weave = weavePropertiesConfigurer.Weave;
                plotInputsPanel.Enabled = true;
            }
        }
    }
}
