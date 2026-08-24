using System.Windows.Forms;
using WindowsFormsApplication1.Textiles;

namespace WindowsFormsApplication1.Forms
{
    public partial class WeavePropertiesConfigurer : Form
    {
        public Weave Weave { get; set; }

        public WeavePropertiesConfigurer()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
