using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;

namespace Dal
{
    internal class CustomerImplementation : IcustomerAble
    {
        static string filePath = @"../xml/customers.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> list;
        public int Create(Customer item)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                list = serializer.Deserialize(sr) as List<Customer>;
                Customer isExist = list.FirstOrDefault(i => i.Identity == item.Identity);
                if (isExist == null)
                    list.Add(item);
               
                
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, list);
            }
            return item.Identity;
        }
        public void Delete(int id)
        {
            List<Customer> list;
            using (StreamReader sr = new StreamReader(filePath))
            {
                list = serializer.Deserialize(sr) as List<Customer>;
            }
            var toRemove = list.FirstOrDefault(customer => customer.Identity == id);
            if (toRemove != null)
            {
                list.Remove(toRemove);
            }
           

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, list);
            }
        }
        public Customer? Read(int id)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                try
                {
                    list = serializer.Deserialize(sr) as List<Customer>;
                }
               catch { return null; }
            }
            return list.FirstOrDefault(customer => customer.Identity == id);
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                list = serializer.Deserialize(sr) as List<Customer>;
            }
            return list.FirstOrDefault(filter);
        }

        public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                list = serializer.Deserialize(sr) as List<Customer>;
            }
            if (filter != null)
                return list?.Where(filter!).ToList() ?? throw new Exception();
            return list;
        }

        public void Update(Customer item)
        {

            Delete(item.Identity);
            Create(item);
        }
    }
}
