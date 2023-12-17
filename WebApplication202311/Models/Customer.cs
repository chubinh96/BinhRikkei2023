using Microsoft.EntityFrameworkCore;

namespace WebApplication202311.Models
{
    [Keyless]
    public class Customer
    {
        public int Customer_Cd { get; set; }

        public String Customer_Nm { get; set; } = null!;
    }
}
