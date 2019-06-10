using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCounting.Repository
{
    class AccountRepository
    {
        private static List<Account> accounts = new List<Account>();

        public static void addAccount(Account acc)
        {
            accounts.Add(acc);
        }

        public static void removeAccount(int index)
        {
            accounts.RemoveAt(index);
        }
    }
}
