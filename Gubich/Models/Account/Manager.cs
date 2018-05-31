using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models.Account
{
    public class Manager
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public DateTime BrithDay { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
