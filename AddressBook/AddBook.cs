using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddBook
    {
        public string Name { get; set; }
        public List<Contact> Contacts { get; } = new List<Contact>();
    }
}
