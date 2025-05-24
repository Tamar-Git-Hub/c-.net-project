
using System.Reflection;
using System.Text;


namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                else
                    sb.Append($"{prefix}{prop.Name} = \n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
            }

            return sb.ToString();
        }
        public static DO.Customer ConvertBOcustomerToDOcustomer(this BO.Customer customer)
        {
            return new DO.Customer(customer.Identity, customer.Name,customer.Address, customer.Phone);
        }
        public static DO.Product ConvertBOproductToDOproduct(this BO.Product product)
        {
            return new DO.Product(product.Id, product.Name, product.Price, product.AmountInStock, (DO.Categories)product.category);
        }
        public static DO.Sale ConvertBOsaleToDOsale(this BO.Sale sale)
        {
            return new DO.Sale(sale.codeIndex,sale.ProductId, sale.MinAmount, sale.Price, sale.Club, sale.StartSaleDate, sale.EndSaleDate);
        }



        public static BO.Customer ConvertDOcustomerToBOcustomer(this DO.Customer customer)
        {
            return new BO.Customer(customer.Identity, customer.Name, customer.Address, customer.Phone);
        }
        public static BO.Product ConvertDOproductToBOproduct(this DO.Product product)
        {
            try
            {
                if(product==null)
                {
                    return null;
                }
                return new BO.Product(product.Id, product.Name, product.Price, product.AmountInStock, (BO.Categories)product.category);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static BO.Sale ConvertDOsaleToBOsale(this DO.Sale sale)
        {
            return new BO.Sale(sale.codeIndex, sale.ProductId, sale.MinAmount, sale.Price, sale.Club, sale.StartSaleDate, sale.EndSaleDate);
        }
    }
}
