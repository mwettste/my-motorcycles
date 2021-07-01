using System;

namespace shared
{
    public class MotorcycleDto
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public uint BuildYear { get; set; }
        public DateTime BoughtInYear { get; set; }
        public DateTime? SoldInYear { get; set; }
        public uint KmWhenBought { get; set; }
        public uint KmNow { get; set; }
        public DateTime UpdateDate { get; set; }
    }

}
