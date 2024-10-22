using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MercanlarApi.Model;

public class KargoModel
{
    public string Tip { get; set; }
    public string Evrak { get; set; }
    public string Tarih { get; set; }
    [Key]
    public string CariNo { get; set; }
    public string Unvan { get; set; }
    public string Resim { get; set; }
    public string Imza { get; set; }
    public string Teslim_Tarihi { get; set; }
    public string Teslim_Alan { get; set; }
    public string Islem { get; set; }
}