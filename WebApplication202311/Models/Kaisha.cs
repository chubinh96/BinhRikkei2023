using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace WebApplication202311.Models
{
    public class Kaisha
    {
        [Timestamp]
        public byte[]? RowVersion { get; set; }
        public int KaishaId { get; set; }

        public String KaishaName { get; set; } = null!;

        public String KaishaAdress { get; set; } = null!;

        public String KaishaCode { get; set; } = null!;

        [ConcurrencyCheck]
        public DateTime UpdateTime { get; set; }
    }
}
