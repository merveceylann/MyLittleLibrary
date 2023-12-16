using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleLibrary.Data.Model
{
    public class Members : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Punishment { get; set; }
        public char Authority { get; set; }
        public char State { get; set; }

        public List<Move> Moves { get; set; }
    }
}
