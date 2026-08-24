namespace WindowsFormsApplication1.Textiles
{
    public class Weave
    {
        /////////////////////////////////
        /// Weave physical properties ///
        /////////////////////////////////
        public int WarpCount { get; set; }
        public int WeftCount { get; set; }
        public int YarnWidth { get; set; }
        public int YarnThickness { get; set; }
        public int YarnSpacing { get; set; }
        public bool[,] IsWarpOverWeft { get; set; }
        public int RepeatX { get; set; }
        public int RepeatY { get; set; }
        public float FabricWidth
        {
            get { return ((YarnWidth + YarnSpacing) * WarpCount * RepeatX) - YarnSpacing; }
        }
        public float FabricHeight
        {
            get { return ((YarnWidth + YarnSpacing) * WeftCount * RepeatY) - YarnSpacing; }
        }
        public float FabricThickness
        {
            get { return YarnThickness; }
        }

        ///////////////////////////////////
        /// Weave mechanical properties ///
        ///////////////////////////////////
        public float YoungsModulusX { get; set; }
        public float YoungsModulusY { get; set; }
        public float FabricArialDensity { get; set; }

        public Weave(int warps, int wefts)
        {
            WarpCount = warps;
            WeftCount = wefts;

            YoungsModulusX = 10;
            YoungsModulusY = 10;

            FabricArialDensity = 10;

            MakeInterlacementMatrix();
        }

        private void MakeInterlacementMatrix()
        {
            IsWarpOverWeft = new bool[WarpCount, WeftCount];

            for (int i = 0; i < WarpCount; i++)
            {
                for (int j = 0; j < WeftCount; j++)
                {
                    IsWarpOverWeft[i, j] = (i + j) % 2 == 0;
                }
            }
        }
    }
}