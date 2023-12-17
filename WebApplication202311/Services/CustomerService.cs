

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication202311.DBContext;
using WebApplication202311.Models;

namespace WebApplication202311.Services
{
    public class CustomerService
    {
        public CustomerService() { }

        public static dynamic GetCustomer(MyDbContext db, string tableNm, Dictionary<string, object> dynamicConditions)
        {
            Customer cus = new Customer();
            Shain shain = new Shain();

            if (tableNm == "Customer")
            {
                var query = db.Customers
                .Where(BuildWhereExpression<Customer>(dynamicConditions));

                foreach (var result in query)
                {
                    cus.Customer_Cd = result.Customer_Cd;
                    cus.Customer_Nm = result.Customer_Nm;
                }
                return cus;
            }
            else if(tableNm == "Shain")
            {
                var query = db.Shains
                .Where(BuildWhereExpression<Shain>(dynamicConditions));

                foreach (var result in query)
                {
                    shain.Shain_Cd = result.Shain_Cd;
                    shain.Shain_Nm = result.Shain_Nm;
                }

                return shain;
            }

            string tbNm = db.GetDbCustomerName();

            return "";
        }

        public static string GetDbName(MyDbContext db)
        {

            string tbNm = db.GetDbCustomerName();

            return tbNm;
        }

        static Expression<Func<T, bool>> BuildWhereExpression<T>(Dictionary<string, object> dynamicConditions)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var conditions = dynamicConditions.Select(pair =>
            {
                var property = Expression.Property(parameter, pair.Key);
                var constant = Expression.Constant(pair.Value);
                return Expression.Equal(property, constant);
            });

            var body = conditions.Aggregate(Expression.And);
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }

        public static bool Chk(MyDbContext db, string tableName, Dictionary<string, object> dynamicConditions, DateTime? updateTime)
        {
            bool chk = false;

            Customer customer = db.Customers
                .Where(u => u.Customer_Cd == 1)
                .FirstOrDefault();


            return chk;
        }
    }
}
