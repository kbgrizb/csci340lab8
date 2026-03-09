using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Concert
{
    public int Id { get; set; }

    [Required]
    public string? Artist { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public string? Venue { get; set; }

    public string? City { get; set; }
    
    public decimal Price { get; set; }
}