using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIKPO_KURSACH
{
    class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public override string ToString() => $"{nameof(id)}: {id}, {nameof(login)}: {login}, {nameof(password)}: {password}";
    }
}
