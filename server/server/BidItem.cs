using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class BidItem
    {
        /// <summary>
        /// constructor sets the defaults for the items:
        /// </summary>
        public BidItem()
        {
            name = "box of rocks";
            price = 300;
            bid = 0;
            description = "";
        }

        /// <summary>
        /// constructor for when the item properties are already known
        /// </summary>
        public BidItem(string newname, double newprice, int newbid, string newdescription)
        {
            name = newname;
            price = newprice;
            bid = newbid;
            description = newdescription;
        }

        public double price;
        /// <summary>
        /// the price of the item
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string name;
        /// <summary>
        /// the name of the item
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int bid;
        /// <summary>
        /// the current bid on the item
        /// </summary>
        public int Bid
        {
            get { return bid; }
            set { bid = value; }
        }

        public string description;
        /// <summary>
        /// a brief description for the item
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
