using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication202311.Models
{
    public class Employ
    {
        [Timestamp]
        public byte[]? RowVersion {get; set;}
        public int EmployId { get; set; }

        [ConcurrencyCheck]
        public String EmployName { get; set; } = null!;
    }
}
