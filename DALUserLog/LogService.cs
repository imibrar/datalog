using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUserLog
{
    public static class LogService
    {
        public static DataLogDbEntities _db = new DataLogDbEntities();

        public static List<UserLog> GetLogs(int skip = 0, int take = 30)
        {
            return _db.UserLogs.OrderByDescending(x => x.Id).Skip(skip).Take(take).ToList();
        }
        public static List<UserLog> GetLogs(string userId, int skip = 0, int take = 30)
        {
            return _db.UserLogs.Where(x=>x.UserId == userId).OrderByDescending(x => x.Id).Skip(skip).Take(take).ToList();
        }
        public static UserLog AddLog(UserLog userLog)
        {
            _db.UserLogs.Add(userLog);
            _db.SaveChanges();
            return userLog;
        }
        public static UserLog UpdateLog(UserLog userLog)
        {
            _db.UserLogs.AddOrUpdate(userLog);
            _db.SaveChanges();
            return userLog;
        }
        public static UserLog SingleLog(int logId)
        {
            return _db.UserLogs.Find(logId);
        }
        public static bool DeleteLog(int logId)
        {
            var log = _db.UserLogs.Find(logId);
            if (log != null)
            {
                _db.UserLogs.Remove(log);
                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
