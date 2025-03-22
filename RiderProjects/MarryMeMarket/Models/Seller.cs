using Microsoft.VisualBasic.CompilerServices;

namespace MarryMeMarket.Models;

public class Seller
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Item { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public float? Price { get; set; }
    public string? Location { get; set; }
}