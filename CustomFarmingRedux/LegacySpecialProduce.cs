using System;

namespace CustomFarmingRedux
{
    public class LegacySpecialProduce
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool _useColor { get; set; }
        public bool _usePrefix { get; set; }
        public bool _useSuffix { get; set; }
        public bool uc;
        public bool up;
        public bool us;

        public bool usePrefix
        {
            set
            {
                _usePrefix = value;
                up = true;
            }
        }

        public bool useSuffix
        {
            set
            {
                _useSuffix = value;
                us = true;
            }
        }

        public bool useColor
        {
            set
            {
                _useColor = value;
                uc = true;
            }
        }

        public int ProduceID { get; set; } = -1;
        public string Tilesheet { get; set; }
        public int TileIndex { get; set; } = -1;
        public int Stack { get; set; } = -1;
        public int ProductionTime { get; set; } = -1;
        public int Quality { get; set; } = -9;
        public int MaterialQuality { get; set; } = -1;
        public int Material { get; set; } = 0;
    }
}