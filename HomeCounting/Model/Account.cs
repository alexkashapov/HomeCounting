using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCounting
{
    class Account
    {
        private String name;
        private double balance;
        private String description;

        public Account(String name)
        {
            this.name = name;
            this.balance = 0;
            this.description = "";
        }

        public Account(String name,double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public Account(string name, double balance, string description) : this(name, balance)
        {
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Description { get => description; set => description = value; }
    }
}
