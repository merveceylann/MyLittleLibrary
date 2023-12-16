using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleLibrary.Data.Model
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string OrderNo { get; set; }
        public int Adet { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int AuthotId { get; set; }
        public Author? Author { get; set; }
    }
}
