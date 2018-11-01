using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtyEntityLibrary;

namespace BtyLibrary
{
    public abstract class BaseDbController
    {
        public zdbEntities bde;
    

        public BaseDbController()
        {
            bde = new zdbEntities();
        }

    }
}
