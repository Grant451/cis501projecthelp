using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class BidItemLibrary
    {

        //contains the current bidItems in the system.
        public List<BidItem> Items = new List<BidItem>();

        /// <summary>
        /// adds an item to the Items list
        /// </summary>
        public void add()
        {
            
        }

        /// <summary>
        /// searches for an item with the given criteria
        /// </summary>
        public void find()
        {

        }

        /// <summary>
        /// returns the current list of bidItems
        /// </summary>
        /// <returns></returns>
        public List<BidItem> getAll()
        {
            return Items;
        }
    }
}
