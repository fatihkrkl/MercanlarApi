using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MercanlarApi.Model;

public class AracModel
{
    [Key]
    public string Plaka { get; set; }
    public string Sofor { get; set; }
    public string Sube { get; set; }
    public string Per { get; set; }
}