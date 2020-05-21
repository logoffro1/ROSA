using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
   public class Table
    {
        public int tableId { get; set; }
        public int capacity { get; set; }
        public bool isAvailable { get; set; }
        public bool isReserved { get; set; }
        public TableStatus status { get; set; }
        public DateTime orderdate { get; set; }

    }
}
