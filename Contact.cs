using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contextapp_yash.Classes
{
    class Contact
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        public override string ToString() => $"{Name} -- {Email} -- {Phone}";

    }
}
