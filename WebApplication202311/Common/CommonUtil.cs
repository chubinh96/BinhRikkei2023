using WebApplication202311.DBContext;
using WebApplication202311.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication202311.Common
{
    public class CommonUtil
    {
        public static bool Chk(MyDbContext db, string tableName, Dictionary<string, object> dynamicConditions, DateTime? updateTime)
        {
            bool chk = false;

            Customer customer = db.Customers
                .Where(u => u.Customer_Cd == 1)
                .FirstOrDefault();

            //var someEntity = dbSet.Find(keyValue);

            var cnn = (SqlConnection)db.Database.GetDbConnection();
            cnn.Open();
            string coomandtext = @"";
            using (var cmd = new SqlCommand(coomandtext, cnn))
            using (var rdr = cmd.ExecuteReader(CommandBehavior.SingleResult))


            return chk;
        }
    }
}
