using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PermissionsGroup:CommonPlace
    {
        private int permissionsGroupId;
        private string grupAdi;

        public int PermissionsGroupId { get => permissionsGroupId; set => permissionsGroupId = value; }
        public string GrupAdi { get => grupAdi; set => grupAdi = value; }
    }
}
