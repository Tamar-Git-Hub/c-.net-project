
using DO;
using DalApi;
using System.Reflection;
namespace Dal;

internal class CustomerImplementation : IcustomerAble
{
    
    public int Create(Customer item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Customer");
        var q = DataSource.customers.Any(c => c.Identity == item.Identity);
        if (q)
            throw new DalExistAlreadyException("exists already");
        else
                {
            DataSource.customers.Add(item);
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {q} Customer");
            return item.Identity;
        }
     
    }
    public Customer? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Customer");
        Customer q = DataSource.customers.FirstOrDefault(x => x.Identity == id);
        if (q.Identity != id)
            throw new DalIdNotFoundException("not exists id");
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {q} Customer");
            return q;
        }
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read All Customer");
            if (filter == null)
            return new List<Customer?>(DataSource.customers);
        var q = DataSource.customers.Where(x => filter(x));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read All Customer");
        return q.ToList();

    }
    public void Update(Customer item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Customer");
        Delete(item.Identity);
        DataSource.customers.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Customer");
    }
    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Customer");
        Customer c = Read(id);
        DataSource.customers.Remove(c);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {c} Customer");
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Customer");
        Customer c = DataSource.customers.FirstOrDefault(x => filter(x));
        if (c== null)
            throw new DalIdNotFoundException("id not found");
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer");
        return c;
    }
}
