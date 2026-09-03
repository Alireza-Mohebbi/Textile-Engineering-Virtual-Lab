namespace TextileEngineeringVirtualLaboratory.Textiles
{
    public class Weave
    {
        /// Weave physical properties ///
        public int WarpCount { get; set; }
        public int WeftCount { get; set; }
        public float YarnWidth { get; set; }        // (mm)
        public float YarnThickness { get; set; }    // (mm)
        public float YarnSpacing { get; set; }      // (mm)
        public bool[,] IsWarpOverWeft { get; set; }
        public int RepeatX { get; set; }
        public int RepeatY { get; set; }
        public float FabricWidth    // (mm)
        {
            get { return ((YarnWidth + YarnSpacing) * WarpCount * RepeatX) - YarnSpacing;}
        }
        public float FabricHeight   // (mm)
        {
            get { return ((YarnWidth + YarnSpacing) * WeftCount * RepeatY) - YarnSpacing; }
        }
        public float FabricThickness    // (mm)
        {
            get { return 2 * YarnThickness;}
        }

        /// Weave mechanical properties ///
        public float YoungsModulusX { get; set; }       // (MPa)
        public float YoungsModulusY { get; set; }       // (MPa)
        public float FabricArialDensity { get; set; }   // (Kg/mm^2)

        /// Other general properties ///
        private const float gravitaionalAcceleration = 9810f;   // (mm/s^2)

        public Weave(int warps, int wefts)
        {
            WarpCount = warps;
            WeftCount = wefts;
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