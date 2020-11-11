/*Grant Clothier
 * this class handles login information for each login attempt. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace server
{
    class LoginControl
    {
        //the list of all the login credentials
        private List<string[]> logincred;

        /// <summary>
        /// this is a public methode that will check the login credentials to see if they are valid.
        /// </summary>
        /// <param name="cred"></param>
        /// <returns>true if the credentials are valid</returns>
        public bool checkcredentials(string[] cred)
        {
            //check to see if the account is in the system.
            
            return false;
        }

        /// <summary>
        /// this methode is called by the login control 
        /// and tells logincontrol to load in all the accounts
        /// </summary>
        public void loadcred()
        {
            //var a = new Account();
            //a.Username = "Admin";
            //a.Password = "secret";
            //var save = new AccountsfileIO();
            //save.accountToFile(a);
        }

    }
}
