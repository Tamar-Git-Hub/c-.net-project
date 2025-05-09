using DO;
using DalApi;
using System.Reflection;
namespace Dal;

internal class ProductImplementation : IproductAble
{
    public int Create(Product item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product");
        Product p = item with { Id = DataSource.Config.ProductCode };
        DataSource.products.Add(p);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" {p} was added");
        return p.Id;
    }
    public Product? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Product");
        Product q = DataSource.products.FirstOrDefault(x => x.Id == id);
        if (q.Id != id)
            throw new DalIdNotFoundException("not exists id");
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product {id}");
            return q;

        }
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Product");
        if (filter == null)
            return new List<Product?>(DataSource.products);
        var q = DataSource.products.Where(x => filter(x));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read All Product");
        return q.ToList();
    }
    public void Update(Product item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Update Product");
        Delete(item.Id);
        DataSource.products.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product");
    }
    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product");
        Product p = Read(id);
        DataSource.products.Remove(p);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {p}  Product");
    }
    public Product? Read(Func<Product, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Product");
        Product p = DataSource.products.FirstOrDefault(x => filter(x));
        if (p == null)
            throw new DalIdNotFoundException("id not found");
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {p} Product");
        return p;
    }
}
