using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : IsaleAble
{
    static string filePath = @"../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    List<Sale> list;
    public int Create(Sale item)
    {
        int code = Config.CodeSale;
        Sale sale = new Sale(code, item.ProductId, item.MinAmount, item.Price, item.Club, item.StartSaleDate, item.EndSaleDate);
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
            list.Add(sale);
        }
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
        return item.ProductId;
    }

    public void Delete(int id)
    {
        List<Sale> list;
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        var toRemove = list.FirstOrDefault(sale => sale.codeIndex == id);
        if (toRemove != null)
        {
            list.Remove(toRemove);
        }

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
    }

    public Sale? Read(int id)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        return list.FirstOrDefault(s=>s.ProductId==id);
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {

        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        return list.FirstOrDefault(filter);
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        if (filter != null)
            return list?.Where(filter!).ToList() ?? throw new Exception();
        return list;
    }

    public void Update(Sale item)
    {
        Delete(item.codeIndex);
        Create(item);
    }
}
