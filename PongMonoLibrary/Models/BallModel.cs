using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMonoLibrary
{
    public class BallModel : IRectangleConvertable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int SpeedHorizontal { get; set; }
        public int SpeedHorizontalMin { get; set; }
        public int SpeedHorizontalMax { get; set; }
        public int SpeedVertical { get; set; }
        public int SpeedVerticalMin { get; set; }
        public int SpeedVerticalMax { get; set; }

        public LeftRight LeftRightValue { get; set; }
        public UpDown UpDownValue { get; set; }
    }
}
