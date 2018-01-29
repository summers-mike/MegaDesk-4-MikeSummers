using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MikeSummers
{
    class DeskQuote
    {

        private decimal pwidth;
        private decimal pdepth;
        private int pnumOfDrawers;
        private string pmaterial;
        private int prushDays;

        private decimal BASESIZE = 1000;
        private decimal SURFACECOST = 1; // cost per square inch over the base size

        public string customerName { get; set; }
        public DateTime quoteDate { get; set; }

        public DeskQuote(decimal width, decimal depth, int numOfDrawers, string material, int rushDays)
        {
            pwidth = width;
            pdepth = depth;
            pnumOfDrawers = numOfDrawers;
            pmaterial = material;
            prushDays = rushDays;
        }

        public decimal surfaceAreaCost()
        {
            // determine if the size of the desk is large enough for additional charge
            if ( pwidth * pdepth > BASESIZE)
            {
                return (pwidth * pdepth - BASESIZE) * SURFACECOST;
            }
            else
            {
                return 0;
            }
        }
    }

    
}
