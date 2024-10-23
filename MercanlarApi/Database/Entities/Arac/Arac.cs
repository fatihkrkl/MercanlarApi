using System.ComponentModel.DataAnnotations;

namespace MercanlarApi.Database.Entities;

public class Arac
{
    [Key]
    public String Plaka { get; set; }
    public string Sofor { get; set; }
    public string Sube { get; set; }
    public string Per { get; set; }
}