using BtyEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtyLibrary
{
    public class BtyOperations : BaseDbController
    {
        public oc_category[] getCategories ()
        {
            oc_category[]  result = (from p in bde.oc_category select p).ToArray();
            return result;
            
        }

        public oc_product[] getProducts()
        {
            oc_product[] result = (from p in bde.oc_product select p).ToArray();
            return result;

        }
    }
}
