using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace BtyLibrary
{
    public abstract class BaseDbController
    {
        public btydbEntities bde;
    

        public BaseDbController()
        {
            bde = new btydbEntities();
        }

    }
}
