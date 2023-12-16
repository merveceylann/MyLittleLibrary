using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleLibrary.Data.Model
{
    public class Move : BaseEntity
    {
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
