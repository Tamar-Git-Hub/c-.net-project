using DO;
using DalApi;
using System.Reflection;
namespace Dal;

internal class SaleImplementation : IsaleAble
{
    public int Create(Sale item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale");
        Sale s = item with { ProductId = DataSource.Config.SaleCode };
        DataSource.sales.Add(s);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {s} Sale");
        return s.ProductId;
    }
    public Sale? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Sale");
        Sale q = DataSource.sales.FirstOrDefault(x => x.codeIndex == id);
        if (q.codeIndex != id)
            throw new DalIdNotFoundException("not exists id");
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {q} Sale");
            return q;
        }
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Sale");
        if (filter == null)
            return new List<Sale?>(DataSource.sales);
        var q = DataSource.sales.Where(x => filter(x));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Sale");
        return q.ToList();

    }
    public void Update(Sale item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale");
        Delete(item.ProductId);
        DataSource.sales.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale");
    }
    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale");
        Sale s = Read(id);
        DataSource.sales.Remove(s);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {s} Sale");
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Sale");
        Sale s = DataSource.sales.FirstOrDefault(x => filter(x));
        if (s == null)
            throw new DalIdNotFoundException("id not found");
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {s} Sale");
        return s;
    }
}
