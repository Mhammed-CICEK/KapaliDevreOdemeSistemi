using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Card : CommonPlace
    {
        private string kartNo;
        private byte kartTipi;

        public string KartNo { get => kartNo; set => kartNo = value; }
        public byte KartTipi { get => kartTipi; set => kartTipi = value; }
    }
}
