using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    class AuctionControl
    {
        //used to hold and manipulate the bid items:
        public BidItemLibrary lib = new BidItemLibrary();

        /// <summary>
        /// shows the add product form and tells biditem library to add the selected Item
        /// </summary>
        public string AddItem()
        {
            int selection = 0;
            var newitem = new AddProduct();
            using (newitem)
            {
                var result = newitem.ShowDialog();//pause execution until input is recieved
                selection = newitem.selected;
            }
            //MessageBox.Show(selection.ToString());
            var saleitem = new BidItem();
            switch(selection)
            {//name, price, bid, description
                case 0:
                    saleitem.name = "Nintendo Switch";
                    saleitem.price = 200;
                    saleitem.bid = 0;
                    saleitem.description =  "gaming console";
                    break;
                case 1:
                    saleitem.name = "Renaissance Artwork";
                    saleitem.price = 250;
                    saleitem.bid = 0;
                    saleitem.description = "very nice painting";
                    break;
                case 2:
                    saleitem.name = "Antique Knife";
                    saleitem.price = 100;
                    saleitem.bid = 0;
                    saleitem.description = "sharp and fancy";
                    break;
                case 3:
                    saleitem.name = "Racing Horse";
                    saleitem.price = 2000;
                    saleitem.bid = 0;
                    saleitem.description = "he's no Seabuiscuit, but he will get you on the track";
                    break;
                default:
                    break;
            }
            //do not add if item is already in lib.items list ||description: "box of rocks"
            if(!(saleitem.description.CompareTo("box of rocks") == 0))
            {
                bool reapeat = false;
                foreach(BidItem x in lib.Items)
                {
                    if(x.name.CompareTo(saleitem.name)==0)
                    {
                        reapeat = true;
                        break;
                    }
                }
                if(!reapeat)
                {
                    lib.Items.Add(saleitem);
                    return saleitem.name;
                }
            }
            //refresh the items list
            return "";
        }
    }
}
