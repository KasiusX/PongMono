using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMonoLibrary
{
    public interface IPlayerScoredRequestor
    {
        void Stop(WhoScored whoScored);

    }
}
