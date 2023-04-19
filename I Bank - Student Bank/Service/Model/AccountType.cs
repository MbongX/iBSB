using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Service.Model
{
    public class AccountType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AccountType() { }
        public AccountType(int id, string name) {
            this.Id = id;
            this.Name = name;
        }

    }
}
