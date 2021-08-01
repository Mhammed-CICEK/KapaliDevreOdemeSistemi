using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StockGroup : CommonPlace
    {
        private string stokName;

        public string StokName { get => stokName; set => stokName = value; }
    }
}
