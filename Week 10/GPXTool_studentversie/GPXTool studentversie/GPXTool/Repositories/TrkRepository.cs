using GPXTool.Data;
using GPXTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPXTool.Repositories
{
    public class TrkRepository
    {
        public void SaveTrk(Trk trk)
        {
            string ins = $"insert into trk values(?,?,?)";
            object[] qrgs = new object[] { null, trk.Title, trk.Tijdstip.ToString("yyyy MM dd HH:mm:ss") };
            int id = SQLiteService.ExecuteInsert(ins, args);
            trk.ID = id;
        }
    }
}
