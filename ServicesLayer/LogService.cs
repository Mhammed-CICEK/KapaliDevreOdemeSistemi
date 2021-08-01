using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using DataLayer;
namespace ServicesLayer
{
    
    public static class LogService
    {
        public static void LogSave(string pDetay, byte plogTipi)
        {
            LogDAL.LogSave(pDetay, plogTipi);
        }
    }
}
