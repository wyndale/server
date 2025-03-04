using System.ComponentModel.DataAnnotations.Schema;

namespace server.Entities;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public Guid CategoryId { get; set; }
}
