using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace server
{
    class AccountsfileIO
    {

        public void accountToFile(Account x)
        {
            var help = new string[1];
            help[0] = JsonConvert.SerializeObject(x);
            System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\SavedAccounts.txt", help);
        }

        /// <summary>
        /// this will read the file and return all the password information to the logincontrol
        /// </summary>
        /// <returns></returns>
        public List<string[]> ReadAccounts()
        {
            var temp = new List<string[]>();
            string[] AlarmAsString = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\SavedAccounts.txt");
            return temp;
        }
    }
}
