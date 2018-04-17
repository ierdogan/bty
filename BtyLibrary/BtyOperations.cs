using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtyLibrary
{
    class BtyOperations : BaseDbController
    {
        public void getMaterial ()
        {
            var query = (from p in bde.Product select p).ToArray();

            
        }
    }
}
