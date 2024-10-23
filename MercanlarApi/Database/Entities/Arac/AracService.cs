namespace MercanlarApi.Database.Entities;

public class AracService(MercanDb _dbContext)
{
    public List<AracReadVM> GetProducts()
    {
        var productList = _dbContext.AracList;
        return productList.Select(arac => new AracReadVM
        {
            Plaka = arac.Plaka,
            Sofor = arac.Sofor,
            Sube = arac.Sube,
            Per = arac.Per
        }).ToList();
    }
 
    public void CreateProduct(AracCreateVM arac)
    {
        var productModel = new Arac
        {
            Plaka = arac.Plaka,
            Sofor = arac.Sofor,
            Sube = arac.Sube,
            Per = arac.Per
        };
        _dbContext.AracList.Add(productModel);
    }
}