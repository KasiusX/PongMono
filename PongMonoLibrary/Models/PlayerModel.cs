using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMonoLibrary
{
    public class PlayerModel : IRectangleConvertable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; set; }
        public int Speed { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
