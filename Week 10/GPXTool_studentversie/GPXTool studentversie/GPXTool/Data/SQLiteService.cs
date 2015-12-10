using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPXTool.Data
{
    public class SQLiteService
    {
        public static void InitSQLite()
        {
            String path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "GPXTool.sqlite");
            using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                CreateTrkTB(conn);
                CreateTrkPtTB(conn);
            }

        }
        private static void CreateTrkTB(SQLiteConnection conn)
        {
            string createtrk = "create table if not exists trk ("
                + "id integer primary key,"
                + "title text not null,"
                + "tijdstip text not null"
                + ")";
            SQLiteCommand cc = conn.CreateCommand(createtrk);
            cc.ExecuteNonQuery();
        }
        private static void CreateTrkPtTB(SQLiteConnection conn)
        {
            string createtrkpt = "create table if not exists trkpt ("
                + "id integer primary key,"
                + "trackid integer foreign key,"
                + "longitude double not null,"
                + "latitude double not null,"
                + "tijdstip text not null"
                + ")";
            SQLiteCommand cc = conn.CreateCommand(createtrkpt);
            cc.ExecuteNonQuery();
        }
    }
}
