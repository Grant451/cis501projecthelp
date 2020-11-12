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
        private List<Account> logincred;

        //this class has an accountfileIO object for reading and writing accounts
        private AccountsfileIO accountIO = new AccountsfileIO();

        /// <summary>
        /// this is a public methode that will check the login credentials to see if they are valid.
        /// </summary>
        /// <param name="cred"></param>
        /// <returns>true if the credentials are valid</returns>
        public bool checkcredentials(string[] cred)
        {
            //check to see if the account is in the system.
            var temp = new Account();
            temp.Username = cred[0];
            temp.Password = cred[1];

            foreach(Account x in logincred)
            {
                if(x.Username.CompareTo(temp.Username)==0 && x.Password.CompareTo(temp.Password)==0)
                {
                    return true;
                }
            }
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
            logincred = accountIO.ReadAccounts();
        }

    }
}
