using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication202311.Models;
using Microsoft.AspNetCore.Http;
using WebApplication202311.DBContext;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebApplication202311.Services;
using NuGet.Packaging.Signing;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApplication202311.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHttpContextAccessor contxt;

        private readonly MyDbContext _db;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, MyDbContext dBContext)
        {
            _logger = logger;

            contxt = httpContextAccessor;

            _db = dBContext;
        }

        public IActionResult Index()
        {
            //List<Customer> list = getCustomerList(_db);

            Dictionary<string, object> dynamicConditions = new Dictionary<string, object>
            {
                { "Shain_Cd", 1 }
            };

            string tableName = "Shain";

            dynamic objectNm = CustomerService.GetCustomer(_db, tableName, dynamicConditions);

            string dbName = CustomerService.GetDbName(_db);
            regist();
            //OnPost();

            int hour = DateTime.Now.Hour;
            ViewBag.Hello = hour < 12 ? "Good morning" : "Good afternoon";
            ViewBag.Title = "Chu Binh";

            //HttpContext.Session.SetString("customer_cd", "CUS001");

            //Session["KeyName"] = "Hello, World!";

            contxt.HttpContext.Session.SetString("customer_cd", "1");
            contxt.HttpContext.Session.SetString("customer_nm", "CUS001");

            

                return View("myView");
        }

        public void regist()
        {


            var newProduct = new Kaisha
            {
                KaishaName = "Kaisha 002",
                KaishaAdress = "Japan 002",
                KaishaCode = "002-003",
                UpdateTime = new System.DateTime(),
        };

            // Thêm đối tượng vào DbSet (trong trường hợp này là Products)
            _db.Kaishas.Add(newProduct);

            // Lưu thay đổi vào cơ sở dữ liệu
            _db.SaveChanges();
        }

        public void OnPost()
        {
            //var employ = _db.Kaishas.Find(keyValues);
            var employ = _db.Kaishas
                .FirstOrDefault(e => e.KaishaId == 2);

            employ.KaishaName = "Kaisha 0011";

            employ.KaishaAdress = "Japan 0011";
            employ.KaishaCode = "001-0022";

            try
            {
                _db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException ex) {

                throw ex;
            }

        }

        public List<Customer> getCustomerList(MyDbContext db)
        {
            List<Customer> customers = db.Customers
                .OrderBy(u => u.Customer_Cd)
                .ToList();

            return customers;
        }

        public IActionResult Privacy()
        {
            //string storedValue = HttpContext.Session.GetString("customer_cd");

            contxt.HttpContext.Session.GetString("customer_cd");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Index2()
        {
            return "Index2 is me !";
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                Reposity.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ListStudents()
        {
            return View(Reposity.GetStudents());
        }

        /*public IActionResult DeleteStudent(Student student)
        {
            Reposity.DeleteStudent(student);
        }*/
    }
}