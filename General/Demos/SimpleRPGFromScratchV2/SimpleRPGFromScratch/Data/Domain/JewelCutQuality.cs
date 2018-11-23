﻿using System.Collections.Generic;

namespace SimpleRPGFromScratch
{
    public partial class JewelCutQuality
    {
        public JewelCutQuality()
        {
            Jewels = new HashSet<Jewel>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public double Factor { get; set; }

        public ICollection<Jewel> Jewels { get; set; }
    }
}
