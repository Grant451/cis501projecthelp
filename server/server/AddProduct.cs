/*Grant Clothier
 * this form allows for one of 4 products to be added.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class AddProduct : Form
    {
        //represents the item selected by the user:
        public int selected = 0;//(adds the first item by default)

        public AddProduct()
        {
            InitializeComponent();
            //add the initial items:
            lstproduct.Items.Add("Nintendo Switch");//0
            lstproduct.Items.Add("Renaissance Artwork");//1
            lstproduct.Items.Add("Antique Knife");//2
            lstproduct.Items.Add("Racing Hourse");//3
        }

        /// <summary>
        /// when an Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            selected = lstproduct.SelectedIndex;
            this.Close();
        }
    }
}
