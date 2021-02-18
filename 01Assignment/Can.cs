using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01Assignment
{
    public class Can
     {
        public readonly Flavor TheFlavor = Flavor.REGULAR;


        public Can()
        {

        }


        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}
