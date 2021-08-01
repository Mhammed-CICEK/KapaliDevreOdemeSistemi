using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserPermissions : CommonPlace
    {
        private int yetkiGrubuId;
        private string aciklama;
        private string yetkiKodu;
        public int YetkiGrubuId { get => yetkiGrubuId; set => yetkiGrubuId = value; }
        public string YetkiKodu { get => yetkiKodu; set => yetkiKodu = value; }
    }
}
