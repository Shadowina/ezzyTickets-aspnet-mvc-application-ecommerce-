using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ezzyTickets.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
